using System.Drawing;

namespace Entidades
{
    public class Duenio : Usuario
    {
        public Duenio(string email, string password) : base(email, password)
        {
            this.ColorDeFondo = Color.LightSteelBlue;
        }

    }
}