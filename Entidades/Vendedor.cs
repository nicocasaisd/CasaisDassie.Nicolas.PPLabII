namespace Entidades
{
    public class Vendedor : Usuario
    {
        // Hereda de usuario

        // Constructor que reutiliza el ctor base
        public Vendedor(string email, string password) : base(email, password)
        {
        }

    }
}