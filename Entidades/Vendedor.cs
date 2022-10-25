using System.Drawing;

namespace Entidades
{
    public class Vendedor : Usuario
    {
        public Vendedor(string email, string password) : base(email, password)
        {
            this.ColorDeFondo = Color.LightGray;
        }

        public override string ObtenerDescripcion()
        {
            return "Usuario Vendedor - " + this.Email;
        }

        public static void HardcodearEntradas()
        {
            TiendaElectronica.ListaUsuarios.Add(new Vendedor("nicolas@electronicacasais.com", "asd123"));
            TiendaElectronica.ListaUsuarios.Add(new Vendedor("julieta@electronicacasais.com", "pepe12"));
        }
    }
}