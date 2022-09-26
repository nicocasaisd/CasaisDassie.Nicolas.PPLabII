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

            
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            this.Text = "Inicio de sesión - " + TiendaElectronica.Nombre;
        }
    }
}