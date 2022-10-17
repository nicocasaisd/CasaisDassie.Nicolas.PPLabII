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
    public partial class Frm_Base : Form
    {
        public Frm_Base()
        {
            InitializeComponent();
            this.BackColor = TiendaElectronica.ObtenerColorDeUsuario();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            TiendaElectronica.UsuarioLogueado = null;
            this.Close();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }

    }
}
