using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public static class TiendaElectronica
    {
        #region ATRIBUTOS

        private static string nombreTienda;
        private static Usuario usuarioLogueado;
        private static List<Factura> listaFacturas;
        private static List<Vendedor> listaVendedores;
        private static List<Duenio> listaDuenios;
        private static List<Producto> listaProductos;

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor estático que inicializa las colecciones y hardcodea datos.
        /// </summary>
        static TiendaElectronica()
        {
            nombreTienda = "Electrónica Casais";
            listaVendedores = new List<Vendedor>();
            listaDuenios = new List<Duenio>();
            listaProductos = new List<Producto>();
            listaFacturas = new List<Factura>();
            HardcodearDatos();
        }

        #endregion

        #region PROPIEDADES
        public static string Nombre
        {
            get { return nombreTienda; }
        }

        public static List<Producto> ListaProductos
        {
            get { return listaProductos; }
        }

        public static List<Factura> ListaFacturas
        {
            get { return listaFacturas; }
        }

        public static Usuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Devuelve el índice del duenio a loguear, en caso de que no exista devuelve -1.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static int ValidarLoginDuenio(string email, string pass)
        {
            int index = 0;

            foreach(Duenio auxDuenio in listaDuenios)
            {
                if(auxDuenio.ValidarDuenio(email, pass))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        /// <summary>
        /// Devuelve el índice del vendedor a loguear, en caso de que no exista devuelve -1.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static int ValidarLoginVendedor(string email, string pass)
        {
            int index = 0;

            foreach (Vendedor auxVendedor in listaVendedores)
            {
                if (auxVendedor.ValidarVendedor(email, pass))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public static Duenio ObtenerDuenio(int index)
        {
            return listaDuenios[index];
        }

        public static Vendedor ObtenerVendedor(int index)
        {
            return listaVendedores[index];
        }

        public static void AsignarUsuarioLogueado(Usuario usuario)
        {
            UsuarioLogueado = usuario;
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
                eMarcaProducto.JBL, 17500, 20
                ));
            listaProductos.Add(new Producto(
                "Teclado inalámbrico", eCategoriaProducto.Computacion, eTipoProducto.Teclado,
                eMarcaProducto.Lenovo, 1270, 10
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

        public static int ObtenerIndexProducto(int id)
        {
            int index = -1;
            int contador = 0;

            foreach(Producto item in listaProductos)
            {
                if(item.Id == id)
                {
                    index = contador;
                }
                contador++;
            }

            return index;
        }

        public static Producto ObtenerProductoPorId(int id)
        {
            int index = ObtenerIndexProducto(id);
            return listaProductos[index];
        }

        public static bool GenerarVenta(List<Tuple<Producto, decimal, string>> carrito)
        {
            //recorro el carrito
            foreach(Tuple<Producto, decimal, string> item in carrito)
            {
                // recorro la lista original
                for(int i=0; i<ListaProductos.Count; i++)
                {
                    Producto producto = ListaProductos[i];
                    if (item.Item1.Id == producto.Id)
                    {
                        producto.CantidadStock -= (int)item.Item2;
                    }
                }
            }

            return false;
        }

        public static Color ObtenerColorDeUsuario()
        {
            if(TiendaElectronica.UsuarioLogueado.GetType() == typeof(Vendedor))
            {
                return Color.LightGray;
            }
            else if(TiendaElectronica.UsuarioLogueado.GetType() == typeof(Duenio))
            {
                return Color.LightSteelBlue;
            }

            return Color.WhiteSmoke;
        }
        
    }

    #endregion

}
