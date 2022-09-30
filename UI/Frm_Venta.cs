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
    public partial class Frm_Venta : Form
    {
        List<Tuple<Producto, decimal>> listaTuplaCarrito;

        public Frm_Venta()
        {
            InitializeComponent();
            listaTuplaCarrito = new List<Tuple<Producto, decimal>>();
        }

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            // Agrego data al cmb_medioDePago
            Array eMedio = Enum.GetValues(typeof(eMedioDePago));
            cmb_medioDePago.DataSource = eMedio;
            // Format del DateTimePicker
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.CustomFormat = "dd/MM/yyyy";
            // cmb_puntoDeVenta , opcion por defecto
            cmb_puntoDeVenta.SelectedIndex = 0;
            // cargo la listaCarrito en lst_carrito
            lst_carrito.DataSource = listaTuplaCarrito;
        }

        private void llb_SeleccionarProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_AdminInventario frm_Admin = new Frm_AdminInventario();
            frm_Admin.ShowDialog();
            // cargo el producto
            if(frm_Admin.IdProducto >= 1000)
            {
                this.txt_codigo.Text = frm_Admin.IdProducto.ToString();
                this.btn_AgregarProducto.Enabled = true;
            }
            
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            decimal cantidad = this.nud_cantidad.Value;

            if(this.btn_AgregarProducto.Enabled && cantidad > 0)
            {
                // cargo el producto a partir del idProducto
                Producto auxProducto;
                int indexProducto = TiendaElectronica.ObtenerIndexProducto(int.Parse(txt_codigo.Text));
                auxProducto = TiendaElectronica.ListaProductos[indexProducto];
                // lo agrego a la lista
                this.listaTuplaCarrito.Add(Tuple.Create(auxProducto, cantidad));
                // actualiza el DataSource de lst_carrito para que muestre los valores
                ActualizarLista();

            }
        }

        private void btn_RemoverProducto_Click(object sender, EventArgs e)
        {
            if(lst_carrito.SelectedIndex >= 0)
            {
                listaTuplaCarrito.RemoveAt(lst_carrito.SelectedIndex);
                ActualizarLista();
            }
        }

        #region METODOS LÓGICA

        private void ActualizarLista()
        {
            lst_carrito.DataSource = null;
            lst_carrito.DataSource = this.listaTuplaCarrito;
            // actualizo txt_total
            txt_total.Text = CalcularTotal(listaTuplaCarrito).ToString();
        }

        private double CalcularTotal(List<Tuple<Producto, decimal>> listaTuplaCarrito)
        {
            double subtotal = 0;
            double total = 0;
            foreach(Tuple<Producto, decimal> item in listaTuplaCarrito)
            {
                subtotal = item.Item1.Precio * (int)item.Item2;

                total += subtotal;

            }

            return total;
        }



        #endregion
    }
}
