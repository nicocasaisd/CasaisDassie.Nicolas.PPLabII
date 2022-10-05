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
        private Factura factura;

        public Frm_Factura()
        {
            InitializeComponent();
            factura = new Factura();
        }

        public Frm_Factura( Factura factura) : this()
        {
            this.factura = factura;
        }

        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            txt_importeTotal.Text = this.factura.Total.ToString();
        }

    }
}
