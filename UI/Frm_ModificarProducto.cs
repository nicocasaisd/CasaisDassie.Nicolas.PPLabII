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
        }

        #endregion

        private void Frm_ModificarProducto_Load(object sender, EventArgs e)
        {
            auxProducto = TiendaElectronica.ObtenerProductoPorId(this.idProducto);
            // Agrego data al cmb_categoria
            Array eCategoria = Enum.GetValues(typeof(eCategoriaProducto));
            cmb_categoria.DataSource = eCategoria;
            // Agrego data al cmb_tipo
            Array eTipo = Enum.GetValues(typeof(eTipoProducto));
            cmb_tipo.DataSource = eTipo;
            // Agrego data al cmb_marca
            Array eMarca = Enum.GetValues(typeof(eMarcaProducto));
            cmb_marca.DataSource = eMarca;

            if (this.opcion == eModificarProductoOpcion.ModificarProducto)
            {
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
                txt_precio.Text = auxProducto.Precio.ToString();
                txt_cantidadStock.Text = auxProducto.CantidadStock.ToString();

            }
            else if(this.opcion ==eModificarProductoOpcion.AgregarProducto)
            {

            }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string precioComoString = txt_precio.Text;
            string cantidadComoString = txt_cantidadStock.Text;

            if (this.opcion == eModificarProductoOpcion.ModificarProducto)
            {
                decimal auxPrecio;
                int auxCantidad;

                if(decimal.TryParse(precioComoString, out auxPrecio)
                    && int.TryParse(cantidadComoString, out auxCantidad) )
                {
                    auxProducto.Precio = auxPrecio;
                    auxProducto.CantidadStock = auxCantidad;
                    auxProducto.Categoria = (eCategoriaProducto)cmb_categoria.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Error. Se ingresaron datos no válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




                
            }
            else if (this.opcion == eModificarProductoOpcion.AgregarProducto)
            {
                
                
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
 