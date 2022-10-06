namespace Entidades
{
    public class Vendedor : Usuario
    {
        public Vendedor(string email, string password) : base(email, password)
        {}


        /// <summary>
        /// Compara los datos que recibe con sus atributos privados
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
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