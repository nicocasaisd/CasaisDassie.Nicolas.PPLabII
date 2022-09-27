using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class TiendaElectronica
    {
        #region ATRIBUTOS

        private static string nombreTienda;
        static List<Vendedor> listaVendedores;
        static List<Duenio> listaDuenios;
        static List<Producto> listaProductos;

        #endregion

        static TiendaElectronica()
        {
            nombreTienda = "Electrónica Casais";
            listaVendedores = new List<Vendedor>();
            listaDuenios = new List<Duenio>();
            listaProductos = new List<Producto>();
            HardcodearDatos();
        }

        public static string Nombre
        {
            get { return nombreTienda; }
        }

        public static bool LoguearDuenio(string email, string pass)
        {
            foreach(Duenio auxDuenio in listaDuenios)
            {
                if(auxDuenio.ValidarDuenio(email, pass))
                {
                    return true;
                }
            }
            return false;
        }

        private static void HardcodearDatos()
        {
            HardcodearVendedores();
            HardcodearDuenios();
            HardcodearProductos();
        }

        private static void HardcodearProductos()
        {
            listaProductos.Add(new Producto(
                "Parlante Bluetooth", eCategoriaProducto.Audio, eTipoProducto.Parlante,
                eMarcaProducto.JBL, "Parlante con bateria", 17500, 20
                ));
            listaProductos.Add(new Producto(
                "Parlante Bluetooth", eCategoriaProducto.Audio, eTipoProducto.Parlante,
                eMarcaProducto.JBL, "Parlante con bateria", 17500, 20
                ));
        }

        private static void HardcodearVendedores()
        {
            listaVendedores.Add(new Vendedor("nicolas@electronicacasais.com", "asd123"));
            listaVendedores.Add(new Vendedor("julieta@electronicacasais.com", "pepe12"));
        }

        private static void HardcodearDuenios()
        {
            listaDuenios.Add(new Duenio("fernando@electronicacasais.com", "asd123"));
        }
    }
}
