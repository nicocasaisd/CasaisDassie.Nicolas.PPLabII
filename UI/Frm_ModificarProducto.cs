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
        int indexProducto;
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
        public Frm_ModificarProducto(int indexProducto, 
            eModificarProductoOpcion opcion) : this(opcion)
        {
            this.indexProducto = indexProducto;
        }

        #endregion

        private void Frm_ModificarProducto_Load(object sender, EventArgs e)
        {
            auxProducto = TiendaElectronica.ListaProductos[indexProducto];
            // Agrego data al cmb_categoria
            Array eCategoria = Enum.GetValues(typeof(eCategoriaProducto));
            cmb_categoria.DataSource = eCategoria;
            // Agrego data al cmb_tipo
            Array eTipo = Enum.GetValues(typeof(eTipoProducto));
            cmb_tipo.DataSource = eTipo;
            // Agrego data al cmb_marca
            Array eMarca = Enum.GetValues(typeof(eMarcaProducto));
            cmb_tipo.DataSource = eMarca;

            if (this.opcion == eModificarProductoOpcion.ModificarProducto)
            {
                // no enabled
                txt_id.Enabled = false;
                txt_nombre.Enabled = false;
                cmb_categoria.Enabled = false;
                cmb_tipo.Enabled = false;
                cmb_marca.Enabled = false;
                // completo los campos
                txt_id.Text = auxProducto.Id.ToString();
                txt_nombre.Text = auxProducto.Nombre;
                //cmb_categoria.SelectedItem

            }
            else if(this.opcion ==eModificarProductoOpcion.AgregarProducto)
            {

            }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string valorComoString = txt_precio.Text;

            if (this.opcion == eModificarProductoOpcion.ModificarProducto)
            {
                double auxPrecio;
                double.TryParse(valorComoString, out auxPrecio);
                auxProducto.Precio = auxPrecio;
            }
            else if (this.opcion == eModificarProductoOpcion.AgregarProducto)
            {
                int auxCantidad;
                int.TryParse(valorComoString, out auxCantidad);
                auxProducto.CantidadStock = auxCantidad;
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
 