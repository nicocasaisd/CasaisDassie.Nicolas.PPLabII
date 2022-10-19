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
    public partial class Frm_MenuPrincipal : Frm_Base
    {
        public Frm_MenuPrincipal() :base()
        {
            InitializeComponent();
        }


        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.HabilitarBotonCerrarSesion();
            this.lbl_nombreUsuario.Text = "Bienvenido " + TiendaElectronica.UsuarioLogueado.Email;
            this.Sonido("ding.wav");
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

        
    }
}
