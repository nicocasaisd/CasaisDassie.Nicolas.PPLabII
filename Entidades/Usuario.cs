using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
    {
        // CLASE ABSTRACTA de la que van a heredar Vendedor y Duenio
        private string email;
        private string password;

        public Usuario()
        {
            this.email = "";
            this.password = "";
        }

        public Usuario(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        // PROPIEDAD DE SOLO LECTURA
        public string Email
        {
            get { return email; }
        }

        /// <summary>
        /// Compara la password recibida con su atributo
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool ValidarPassword(string pass)
        {
            if(pass == this.password)
            {
                return true;
            }
            return false;
        }

        public bool ValidarLogin(string usuario, string pass)
        {
            if (this.Email == usuario)
            {
                return this.ValidarPassword(pass);
            }
            return false;
        }

    }
}
