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
        private static List<Vendedor> listaVendedores;
        private static List<Duenio> listaDuenios;
        private static List<Producto> listaProductos;
        private static List<Contador> listaContadores;

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
            listaContadores = new List<Contador>();
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

        public static List<Contador> ListaContadores
        {
            get { return listaContadores; }
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

        /// <summary>
        /// Devuelve el índice del vendedor a loguear, en caso de que no exista devuelve -1.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static int ValidarLoginContador(string email, string pass)
        {
            int index = 0;

            foreach (Contador auxContador in listaContadores)
            {
                if (auxContador.ValidarContador(email, pass))
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
        public static Duenio ObtenerDuenio(int index)
        {
            return listaDuenios[index];
        }

        /// <summary>
        /// Devuelve el objeto Vendedor de la lista de vendedores.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Vendedor ObtenerVendedor(int index)
        {
            return listaVendedores[index];
        }

        /// <summary>
        /// Devuelve el objeto Vendedor de la lista de vendedores.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Contador ObtenerContador(int index)
        {
            return listaContadores[index];
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
        /// Ingresa datos "hardcodeados" a las listas de productos, dueños y vendedores.
        /// </summary>
        private static void HardcodearDatos()
        {
            HardcodearVendedores();
            HardcodearDuenios();
            HardcodearProductos();
            HardcodearContadores();
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
            listaProductos.Add(new Producto(
                "Monitor 19\"", eCategoriaProducto.Video, eTipoProducto.Monitor,
                eMarcaProducto.Lenovo, 1270, 10
                ));
            listaProductos.Add(new Producto(
                "Notebook I7 8gb RAM", eCategoriaProducto.Computacion, eTipoProducto.Notebook,
                eMarcaProducto.Dell, 123300, 5
                ));
            listaProductos.Add(new Producto(
                "Impresora Profesional", eCategoriaProducto.Impresion, eTipoProducto.Impresora,
                eMarcaProducto.Epson, 45070, 6
                ));
            listaProductos.Add(new Producto(
                "Play Station 5", eCategoriaProducto.Gaming, eTipoProducto.ConsolaGaming,
                eMarcaProducto.PlayStation, 16580, 4
                ));
            listaProductos.Add(new Producto(
                "Micrófono Condenser", eCategoriaProducto.Audio, eTipoProducto.Microfono,
                eMarcaProducto.DyB, 43200, 16
                ));
            listaProductos.Add(new Producto(
                "Monitor 14\"", eCategoriaProducto.Video, eTipoProducto.Monitor,
                eMarcaProducto.HP, 35200, 3
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

        private static void HardcodearContadores()
        {
            listaContadores.Add(new Contador("contador@electronicacasais.com", "asd123"));
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
                    if (item.Item1.Id == producto.Id)
                    {
                        producto.CantidadStock -= (int)item.Item2;
                    }
                }
            }

            return false;
        }

        /// <summary>
        ///  Devuelve el color de fondo de la ventana correspondiente al tipo de Usuario
        /// </summary>
        /// <returns></returns>
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
