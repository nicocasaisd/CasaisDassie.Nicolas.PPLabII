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
        public Frm_Venta()
        {
            InitializeComponent();
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
            
        }

        private void llb_AgregarProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_AdminInventario frm_Admin = new Frm_AdminInventario();
            frm_Admin.ShowDialog();
            // cargo el producto
            if(frm_Admin.IdProducto >= 1000)
            {
                this.txt_codigo.Text = frm_Admin.IdProducto.ToString();
            }
            
        }
    }
}
