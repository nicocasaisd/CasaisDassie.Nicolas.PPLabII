using Entidades;

namespace UI
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
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
                this.Close();
            }
            else if (LoguearContador(this.txt_usuario.Text, this.txt_password.Text))
            {
                Frm_Estadisticas frm_Estadisticas = new Frm_Estadisticas();
                frm_Estadisticas.Show();
                this.Close();
                //MessageBox.Show("Contador");
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

        #region METODOS

        /// <summary>
        /// Si puede loguear el Duenio devuelve true y asigna el indice de lista Duenio a su atributo
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        private bool LoguearDuenio(string usuario, string pass)
        {
            int indexDuenio = TiendaElectronica.ValidarLoginDuenio(this.txt_usuario.Text, this.txt_password.Text);
            if (indexDuenio > -1)
            {
                Duenio auxDuenio = TiendaElectronica.ObtenerDuenio(indexDuenio);
                TiendaElectronica.AsignarUsuarioLogueado(auxDuenio);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Si puede loguear el Vendedor devuelve true y asigna el indice de lista Vendedor a su atributo
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Si puede loguear el Vendedor devuelve true y asigna el indice de lista Vendedor a su atributo
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        private bool LoguearContador(string usuario, string pass)
        {
            int indexContador = TiendaElectronica.ValidarLoginContador(this.txt_usuario.Text, this.txt_password.Text);
            if (indexContador > -1)
            {
                Contador auxContador = TiendaElectronica.ObtenerContador(indexContador);
                TiendaElectronica.AsignarUsuarioLogueado(auxContador);
                return true;
            }
            return false;
        }

        #endregion
    }
}