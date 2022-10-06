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
            if(LoguearDuenio(this.txt_usuario.Text, this.txt_password.Text))
            {
                Frm_MenuPrincipal menuPrincipal = new Frm_MenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else if(LoguearVendedor(this.txt_usuario.Text, this.txt_password.Text))
            {
                Frm_Venta frm_Venta = new Frm_Venta();
                frm_Venta.Show();
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

        private bool LoguearDuenio(string usuario, string pass)
        {
            int indexDuenio = TiendaElectronica.ValidarLoginDuenio(this.txt_usuario.Text, this.txt_password.Text);
            //int indexVendedor = TiendaElectronica.ValidarLoginVendedor(this.txt_usuario.Text, this.txt_password.Text);
            if (indexDuenio > -1)
            {
                Duenio auxDuenio = TiendaElectronica.ObtenerDuenio(indexDuenio);
                TiendaElectronica.AsignarUsuarioLogueado(auxDuenio);
                return true;
            }
            return false;
        }

        private bool LoguearVendedor(string usuario, string pass)
        {
            int indexVendedor = TiendaElectronica.ValidarLoginVendedor(this.txt_usuario.Text, this.txt_password.Text);
            if (indexVendedor > -1)
            {
                Vendedor auxVendedor = TiendaElectronica.ObtenerVendedor(indexVendedor);
                TiendaElectronica.AsignarUsuarioLogueado(auxVendedor);
                return true;
            }
            return false;
        }

        #endregion
    }
}