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
    public partial class Frm_Factura : Form
    {
        #region ATRIBUTOS

        private Factura factura;

        #endregion

        #region CONSTRUCTORES
        public Frm_Factura()
        {
            InitializeComponent();
            factura = new Factura();
        }

        public Frm_Factura( Factura factura) : this()
        {
            this.factura = factura;
            this.factura.ListaTuplaCarrito = new List<Tuple<Producto, decimal, string>>(factura.ListaTuplaCarrito);
        }

        #endregion


        /// <summary>
        /// Completa todos los campos y carga el ListBox carrito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            txt_importeTotal.Text = this.factura.Total.ToString();
            txt_cliente.Text = this.factura.Cliente;
            txt_medioDePago.Text = this.factura.MedioDePago.ToString();
            txt_vuelto.Text = this.factura.Vuelto.ToString();
            txt_puntoDeVenta.Text = this.factura.PuntoDeVenta;
            txt_nroDeFactura.Text = this.factura.NroDeFactura.ToString("D8");
            txt_fecha.Text = this.factura.Fecha.ToShortDateString();
            lst_carrito.DataSource = this.factura.ListaTuplaCarrito;
            lst_carrito.DisplayMember = "Item3";
        }

        /// <summary>
        /// Genera la venta y agrega la Factura a la lista de Facturas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generarVenta_Click(object sender, EventArgs e)
        {
            TiendaElectronica.GenerarVenta(this.factura.ListaTuplaCarrito);
            TiendaElectronica.ListaFacturas.Add(this.factura);
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
