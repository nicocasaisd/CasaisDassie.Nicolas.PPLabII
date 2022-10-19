using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            
        }

        private void Frm_Base_Load(object sender, EventArgs e)
        {
            ObtenerColorDeUsuario();
            AsignarTitulo();
        }

        public void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            TiendaElectronica.UsuarioLogueado = null;
            this.Close();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }

        public void ObtenerColorDeUsuario()
        {
            if (TiendaElectronica.UsuarioLogueado is not null)
            {
                this.BackColor = TiendaElectronica.UsuarioLogueado.ColorDeFondo;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        public void HabilitarBotonCerrarSesion()
        {
            this.btn_CerrarSesion.Visible = true;
        }

        public void Sonido(string sonido)
        {
            string path = "../../../../media/" + sonido;
            SoundPlayer spl = new SoundPlayer(path);
            spl.Play();
        }

        public void AsignarTitulo()
        {
            if(TiendaElectronica.UsuarioLogueado is not null)
            {
                this.Text += " - " + TiendaElectronica.UsuarioLogueado.ObtenerDescripcion();
            }
        }


    }
}
