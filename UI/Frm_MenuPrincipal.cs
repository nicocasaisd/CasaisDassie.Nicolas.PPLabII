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
    public partial class Frm_MenuPrincipal : Form
    {
        private Duenio auxDuenio;

        public Frm_MenuPrincipal()
        {
            auxDuenio = new Duenio();
            InitializeComponent();
        }

        public Frm_MenuPrincipal(Duenio auxDuenio) :this()
        {
            this.auxDuenio = auxDuenio;
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Frm_AdminInventario frm_AdminInventario = new Frm_AdminInventario();
            frm_AdminInventario.Show();
        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lbl_nombreUsuario.Text = "Bienvenido " + auxDuenio.Email;
        }
    }
}
