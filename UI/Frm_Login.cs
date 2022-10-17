using Entidades;

namespace UI
{
    public partial class Frm_Login : Frm_Base
    {
        public Frm_Login() : base()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            this.Text = "Inicio de sesión - " + TiendaElectronica.Nombre;
        }


        /// <summary>
        /// Intenta loguear Duenio o Vendedor y cierra el Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (TiendaElectronica.LoguearUsuario(this.txt_usuario.Text, this.txt_password.Text))
            {
                // de acuerdo al tipo de usuario logueado
                if(TiendaElectronica.UsuarioLogueado is Duenio)
                {
                    Frm_MenuPrincipal menuPrincipal = new Frm_MenuPrincipal();
                    menuPrincipal.Show();
                }
                else if(TiendaElectronica.UsuarioLogueado is Vendedor)
                {
                    Frm_Venta frm_Venta = new Frm_Venta();
                    frm_Venta.Show();
                }
                else if(TiendaElectronica.UsuarioLogueado is Contador)
                {
                    Frm_Estadisticas frm_Venta = new Frm_Estadisticas();
                    frm_Venta.Show();
                }
                this.Hide();
            }
        }

        private void btn_AutoCompletarDuenio_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "fernando@electronicacasais.com";
            txt_password.Text = "asd123";
        }

        private void btn_AutoCompletarVendedor_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "nicolas@electronicacasais.com";
            txt_password.Text = "asd123";
        }
    }
}