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
    }
}