namespace Entidades
{
    public class Duenio : Usuario
    {
        public Duenio() : base()
        {}

        public Duenio(string email, string password) : base(email, password)
        {
        }


        /// <summary>
        /// Compara los datos que recibe con sus atributos privados
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
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