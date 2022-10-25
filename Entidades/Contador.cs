using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contador : Usuario
    {
        public Contador(string email, string password) : base(email, password)
        {

        }

        public override string ObtenerDescripcion()
        {
            return "Usuario Contador - " + this.Email;
        }

        public static void HardcodearEntradas()
        {
            TiendaElectronica.ListaUsuarios.Add(new Contador("contador@electronicacasais.com", "asd123"));
        }
    }
}
