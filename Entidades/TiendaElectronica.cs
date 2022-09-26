using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class TiendaElectronica
    {
        static string nombreTienda;
        static List<Vendedor> listaVendedores;
        static List<Duenio> listaDuenios;
        static List<Producto> listaProductos;

        static TiendaElectronica()
        {
            nombreTienda = "Electrónica Casais";
            listaVendedores = new List<Vendedor>();
            listaDuenios = new List<Duenio>();
            listaProductos = new List<Producto>();
        }
        
    }
}
