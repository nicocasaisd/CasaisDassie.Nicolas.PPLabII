﻿using Entidades;
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
        private Factura factura;

        #region CONSTRUCTORES
        public Frm_Factura()
        {
            InitializeComponent();
            factura = new Factura();
        }

        public Frm_Factura( Factura factura) : this()
        {
            this.factura = factura;
        }

        #endregion
        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            txt_importeTotal.Text = this.factura.Total.ToString();
            txt_cliente.Text = this.factura.Cliente;
            txt_medioDePago.Text = this.factura.MedioDePago.ToString();
            txt_puntoDeVenta.Text = this.factura.PuntoDeVenta;
            txt_nroDeFactura.Text = this.factura.NroDeFactura.ToString("D8");
            txt_fecha.Text = this.factura.Fecha.ToShortDateString();
            lst_carrito.DataSource = this.factura.ListaTuplaCarrito;
            lst_carrito.DisplayMember = "Item3";
        }

    }
}
