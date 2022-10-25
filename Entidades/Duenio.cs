using System.Drawing;

namespace Entidades
{
    public class Duenio : Usuario
    {
        public Duenio(string email, string password) : base(email, password)
        {
            this.ColorDeFondo = Color.LightSteelBlue;
        }

        public override string ObtenerDescripcion()
        {
            return "Usuario Dueño - " + this.Email;
        }

        public static void HardcodearEntradas()
        {
            TiendaElectronica.ListaUsuarios.Add(new Duenio("fernando@electronicacasais.com", "asd123"));
        }
    }
}