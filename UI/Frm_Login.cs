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
            if(TiendaElectronica.LoguearDuenio(usuario, pass))
            {
                Frm_MenuPrincipal menuPrincipal = new Frm_MenuPrincipal();
                menuPrincipal.Show();
            }
            
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            this.Text = "Inicio de sesi�n - " + TiendaElectronica.Nombre;
        }
    }
}