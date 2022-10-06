using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Frm_ModificarProducto : Form
    {
        int idProducto;
        Producto auxProducto;
        eModificarProductoOpcion opcion;

        public enum eModificarProductoOpcion
        {
            ModificarProducto, AgregarProducto
        }

        #region CONSTRUCTORES
        public Frm_ModificarProducto()
        {
            InitializeComponent();
            auxProducto = new Producto();
        }

        public Frm_ModificarProducto(eModificarProductoOpcion opcion) : this()
        {
            this.opcion = opcion;
        }
        public Frm_ModificarProducto(int idProducto, 
            eModificarProductoOpcion opcion) : this(opcion)
        {
            this.idProducto = idProducto;
            auxProducto = TiendaElectronica.ObtenerProductoPorId(this.idProducto);
        }

        #endregion

        private void Frm_ModificarProducto_Load(object sender, EventArgs e)
        {
            this.BackColor = TiendaElectronica.ObtenerColorDeUsuario();
            // Agrego data al cmb_categoria
            Array eCategoria = Enum.GetValues(typeof(eCategoriaProducto));
            cmb_categoria.DataSource = eCategoria;
            // Agrego data al cmb_tipo
            Array eTipo = Enum.GetValues(typeof(eTipoProducto));
            cmb_tipo.DataSource = eTipo;
            // Agrego data al cmb_marca
            Array eMarca = Enum.GetValues(typeof(eMarcaProducto));
            cmb_marca.DataSource = eMarca;

            
            //if(typeof(TiendaElectronica.UsuarioLogueado))

            if (this.opcion == eModificarProductoOpcion.ModificarProducto)
            {
                this.Text = "Modificar Producto";
                // no enabled
                txt_id.Enabled = false;
                txt_nombre.Enabled = false;
                cmb_categoria.Enabled = true;
                cmb_tipo.Enabled = false;
                cmb_marca.Enabled = false;
                // completo los campos
                txt_id.Text = auxProducto.Id.ToString();
                txt_nombre.Text = auxProducto.Nombre;
                cmb_categoria.SelectedIndex = (int)auxProducto.Categoria;
                cmb_tipo.SelectedIndex = (int)auxProducto.Tipo;
                cmb_marca.SelectedIndex = (int)auxProducto.Marca;
                nud_precio.Value = auxProducto.Precio;
                nud_cantidadStock.Value = auxProducto.CantidadStock;

            }
            else if(this.opcion == eModificarProductoOpcion.AgregarProducto)
            {
                this.Text = "Agregar Producto";
            }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (this.opcion == eModificarProductoOpcion.ModificarProducto)
            {
                if(ModificarProducto())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (this.opcion == eModificarProductoOpcion.AgregarProducto)
            {
                if(AgregarProducto())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }
            
            
        }

        private bool AgregarProducto()
        {
            bool retorno = false;
            if(ValidarCampos())
            {
                Producto auxProducto = new Producto(
                    txt_nombre.Text, 
                    (eCategoriaProducto) cmb_categoria.SelectedItem, 
                    (eTipoProducto) cmb_tipo.SelectedItem, 
                    (eMarcaProducto) cmb_marca.SelectedItem, 
                    nud_precio.Value,
                    (int) nud_cantidadStock.Value);

                TiendaElectronica.ListaProductos.Add(auxProducto);

                retorno = true;
            }
            else
            {
                MessageBox.Show("Error. Se ingresaron datos no válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;
        }

        private bool ValidarCampos()
        {
            return !(   String.IsNullOrEmpty(this.txt_nombre.Text)
                    ||  String.IsNullOrEmpty(this.cmb_categoria.Text) 
                    ||  String.IsNullOrEmpty(this.cmb_tipo.Text)
                    ||  String.IsNullOrEmpty(this.cmb_marca.Text) );
        }

        private bool ModificarProducto()
        {

            auxProducto.Precio = nud_precio.Value;
            auxProducto.CantidadStock = (int) nud_cantidadStock.Value;
            auxProducto.Categoria = (eCategoriaProducto)cmb_categoria.SelectedIndex;

            return true; ;
        }
    }
}
 