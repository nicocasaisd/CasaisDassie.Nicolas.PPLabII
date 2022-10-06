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
            int indexDuenio = TiendaElectronica.ValidarLoginDuenio(this.txt_usuario.Text, this.txt_password.Text);

            if( indexDuenio> -1)
            {
                Duenio auxDuenio = TiendaElectronica.ObtenerDuenio(indexDuenio);
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

        #region METODOS

        private bool ValidarLogin(string usuario, string pass)
        {

            return false;
        }

        #endregion
    }
}