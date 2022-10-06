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
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }


        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = TiendaElectronica.ObtenerColorDeUsuario();
            this.lbl_nombreUsuario.Text = "Bienvenido " + TiendaElectronica.UsuarioLogueado.Email;
            Sonido("ding.wav");
        }


        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Frm_Venta frm_Venta = new Frm_Venta();
            frm_Venta.ShowDialog();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Frm_AdminInventario frm_AdminInventario = new Frm_AdminInventario(Frm_AdminInventario.eAdminInventarioOpcion.ModificarProducto);
            frm_AdminInventario.ShowDialog();
        }

        public void Sonido(string sonido)
        {
            string path = "../../../../media/" + sonido;
            SoundPlayer spl = new SoundPlayer(path);
            spl.Play();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }
    }
}
