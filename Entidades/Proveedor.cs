using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        string nombre;
        string cuil;
        List<Producto> listaProductos = new List<Producto>();


        public Proveedor()
        {
            List<Producto> listaProductos = new List<Producto>();
        }
        public Proveedor(string nombre, string cuil) : this()
        {
            this.nombre = nombre;
            this.cuil = cuil;
        }

        public List<Producto> ListaProductos
        {
            get { return this.listaProductos; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }


        public static void HardcodearProveedores()
        {
            TiendaElectronica.ListaProveedores.Add(new Proveedor("Pepito SRL", "20-36396134-8"
                ));
            TiendaElectronica.ListaProveedores.Add(new Proveedor("Juanelo SA", "20-36396134-8"
                ));
        }

        public static void HardcodearListaProductos()
        {
            foreach(Proveedor prov in TiendaElectronica.ListaProveedores)
            {
                prov.ListaProductos.Add(new Producto(
                "Pancho 14\"", eCategoriaProducto.Video, eTipoProducto.Monitor,
                eMarcaProducto.HP, 35200, 3
                ));

                prov.ListaProductos.Add(new Producto(
                "Micrófono Condenser", eCategoriaProducto.Audio, eTipoProducto.Microfono,
                eMarcaProducto.DyB, 43200, 16
                ));
            }
        }


    }
}
