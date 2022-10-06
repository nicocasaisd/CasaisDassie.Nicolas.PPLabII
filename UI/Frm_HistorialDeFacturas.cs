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
    public partial class Frm_HistorialDeFacturas : Form
    {
        public Frm_HistorialDeFacturas()
        {
            InitializeComponent();
        }

        private void Frm_HistorialDeFacturas_Load(object sender, EventArgs e)
        {
            dgv_historialDeFacturas.DataSource = TiendaElectronica.ListaFacturas;
        }
    }
}
