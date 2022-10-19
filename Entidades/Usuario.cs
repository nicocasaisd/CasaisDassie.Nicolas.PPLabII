using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Color colorDeFondo = Color.WhiteSmoke;

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

        public Color ColorDeFondo
        {
            get { return this.colorDeFondo; }
            set { this.colorDeFondo = value; }
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

        public virtual string ObtenerDescripcion()
        {
            return "No User";
        }

    }
}
