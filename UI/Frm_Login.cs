using Entidades;

namespace UI
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txt_usuario.Text;
            string pass = this.txt_password.Text;
            int indexDuenio = TiendaElectronica.ValidarLoginDuenio(usuario, pass);
            Duenio auxDuenio;

            if( indexDuenio> -1)
            {
                auxDuenio = TiendaElectronica.ObtenerDuenio(indexDuenio);
                Frm_MenuPrincipal menuPrincipal = new Frm_MenuPrincipal(auxDuenio);
                menuPrincipal.Show();
                this.Hide();
            }
            
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            this.Text = "Inicio de sesión - " + TiendaElectronica.Nombre;
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