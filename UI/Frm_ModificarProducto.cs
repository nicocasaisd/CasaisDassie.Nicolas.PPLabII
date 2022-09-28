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
        ModificarProductoOpcion opcion;

        public enum ModificarProductoOpcion
        {
            CambiarPrecio, CambiarCantidad
        }

        #region CONSTRUCTORES
        public Frm_ModificarProducto()
        {
            InitializeComponent();
            auxProducto = new Producto();
        }

        public Frm_ModificarProducto(int indexProducto, 
            ModificarProductoOpcion opcion) : this()
        {
            this.indexProducto = indexProducto;
            this.opcion = opcion;
        }

        #endregion

        private void Frm_ModificarProducto_Load(object sender, EventArgs e)
        {
            auxProducto = TiendaElectronica.ListaProductos[indexProducto];

            if (this.opcion == ModificarProductoOpcion.CambiarPrecio)
            {
                lbl_previoCampo.Text = "Precio anterior:";
                lbl_previoCampoContenido.Text = auxProducto.Precio.ToString();
            }
            else if(this.opcion == ModificarProductoOpcion.CambiarCantidad)
            {
                lbl_previoCampo.Text = "Stock anterior:";
                lbl_previoCampoContenido.Text = auxProducto.CantidadStock.ToString();
            }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string valorComoString = txt_nuevoPrecio.Text;

            if (this.opcion == ModificarProductoOpcion.CambiarPrecio)
            {
                double auxPrecio;
                double.TryParse(valorComoString, out auxPrecio);
                auxProducto.Precio = auxPrecio;
            }
            else if (this.opcion == ModificarProductoOpcion.CambiarCantidad)
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
 