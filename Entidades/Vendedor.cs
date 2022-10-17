using System.Drawing;

namespace Entidades
{
    public class Vendedor : Usuario
    {
        public Vendedor(string email, string password) : base(email, password)
        {
            this.ColorDeFondo = Color.LightGray;
        }
    }
}