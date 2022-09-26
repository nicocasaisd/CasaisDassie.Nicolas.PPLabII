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

    }
}
