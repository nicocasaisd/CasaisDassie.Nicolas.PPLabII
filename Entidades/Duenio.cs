namespace Entidades
{
    public class Duenio : Usuario
    {
        // Hereda de usuario

        // Constructor que reutiliza el ctor base
        public Duenio(string email, string password) : base(email, password)
        {
        }

        public bool ValidarDuenio(string usuario, string pass)
        {
            if(this.Email == usuario)
            {
                return this.ValidarPassword(pass);
            }
            return false;
        }
    }
}