namespace Entidades
{
    public class Vendedor : Usuario
    {
        // Hereda de usuario

        // Constructor que reutiliza el ctor base
        public Vendedor(string email, string password) : base(email, password)
        {
        }

        public bool ValidarVendedor(string usuario, string pass)
        {
            if (this.Email == usuario)
            {
                return this.ValidarPassword(pass);
            }
            return false;
        }
    }
}