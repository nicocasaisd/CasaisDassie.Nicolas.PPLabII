using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Entidades
{
    /// <summary>
    /// Clase Estática sobre la que se construye toda la aplicación
    /// </summary>
    public static class TiendaElectronica
    {
        #region ATRIBUTOS

        private static string nombreTienda;
        private static Usuario usuarioLogueado;
        private static List<Factura> listaFacturas;
        private static List<Producto> listaProductos;
        private static List<Usuario> listaUsuarios;

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor estático que inicializa las colecciones y hardcodea datos.
        /// </summary>
        static TiendaElectronica()
        {
            nombreTienda = "Electrónica Casais";
            listaProductos = new List<Producto>();
            listaFacturas = new List<Factura>();
            listaUsuarios = new List<Usuario>();
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

        public static List<Usuario> ListaUsuarios
        {
            get { return listaUsuarios; }
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
        public static int ValidarLoginUsuario(string email, string pass)
        {
            int index = 0;

            foreach (Usuario auxUsuario in TiendaElectronica.listaUsuarios)
            {
                if (auxUsuario.ValidarLogin(email, pass))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        /// <summary>
        /// Devuelve el objeto Duenio de la lista de dueños.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Usuario ObtenerUsuario(int index)
        {
            return listaUsuarios[index];
        }

        /// <summary>
        /// Asigna el Usuario al atributo estático usuarioLogueado
        /// </summary>
        /// <param name="usuario"></param>
        public static void AsignarUsuarioLogueado(Usuario usuario)
        {
            UsuarioLogueado = usuario;
        }

        /// <summary>
        /// Si puede loguear el Duenio devuelve true y asigna el indice de lista Duenio a su atributo
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool LoguearUsuario(string usuario, string pass)
        {
            int index = TiendaElectronica.ValidarLoginUsuario(usuario, pass);
            if (index > -1)
            {
                Usuario auxUsuario = TiendaElectronica.ObtenerUsuario(index);
                TiendaElectronica.AsignarUsuarioLogueado(auxUsuario);
                return true;
            }
            return false;
        }




        /// <summary>
        /// Ingresa datos "hardcodeados" a las listas de productos, dueños y vendedores.
        /// </summary>
        private static void HardcodearDatos()
        {
            Vendedor.HardcodearEntradas();
            Duenio.HardcodearEntradas();
            Contador.HardcodearEntradas();
            Producto.HardcodearProductos();
        }

        /// <summary>
        /// Devuelve el indice del Producto en la lista de productos a partir de su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Devuelve el Producto a partir de su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Producto ObtenerProductoPorId(int id)
        {
            int index = ObtenerIndexProducto(id);
            return listaProductos[index];
        }

        /// <summary>
        /// Recibe una "lista carrito" y genera la venta restando la cantidad en el stock
        /// </summary>
        /// <param name="carrito"></param>
        /// <returns></returns>
        public static bool GenerarVenta(List<Tuple<Producto, decimal, string>> carrito)
        {
            //recorro el carrito
            foreach(Tuple<Producto, decimal, string> item in carrito)
            {
                // recorro la lista original
                for(int i=0; i<ListaProductos.Count; i++)
                {
                    Producto producto = ListaProductos[i];
                    if (item.Item1 == producto)
                    {
                        //producto.CantidadStock -= (int)item.Item2;
                        producto.CantidadStock = producto - (int)item.Item2;
                    }
                }
            }

            return false;
        }
    }

    #endregion

}
