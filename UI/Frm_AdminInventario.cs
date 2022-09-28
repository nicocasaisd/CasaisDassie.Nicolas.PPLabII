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
    public partial class Frm_AdminInventario : Form
    {
        public Frm_AdminInventario()
        {
            InitializeComponent();
        }

        private void Frm_AdminInventario_Load(object sender, EventArgs e)
        {
            this.lst_listaProductos.DataSource = TiendaElectronica.ListaProductos;
        }
    }
}
