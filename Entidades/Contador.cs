using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contador : Usuario
    {
        public Contador() : base()
        { }

        public Contador(string email, string password) : base(email, password)
        {

        }

        /// <summary>
        /// Compara los datos que recibe con sus atributos privados
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool ValidarContador(string usuario, string pass)
        {
            if (this.Email == usuario)
            {
                return this.ValidarPassword(pass);
            }
            return false;
        }

    }
}
