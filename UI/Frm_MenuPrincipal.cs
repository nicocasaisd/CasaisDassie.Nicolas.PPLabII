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
        //private Duenio auxDuenio;
        public Usuario usuario;

        public Frm_MenuPrincipal()
        {
            usuario = new Duenio();
            InitializeComponent();
        }

        public Frm_MenuPrincipal(Duenio auxDuenio) :this()
        {
            this.usuario = auxDuenio;
        }

        public Frm_MenuPrincipal(Vendedor auxVendedor) : this()
        {
            this.usuario = auxVendedor;
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Frm_AdminInventario frm_AdminInventario = new Frm_AdminInventario();
            frm_AdminInventario.Show();
        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lbl_nombreUsuario.Text = "Bienvenido " + TiendaElectronica.UsuarioLogueado.Email;
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Frm_Venta frm_Venta = new Frm_Venta();
            frm_Venta.Show();
        }
    }
}
