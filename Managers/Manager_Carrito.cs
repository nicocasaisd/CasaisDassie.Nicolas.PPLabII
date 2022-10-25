using System;
using System.Collections.Generic;
using Entidades;

namespace Managers
{
    public static class Manager_Carrito
    {
        const decimal RECARGO_CREDITO = 0.10M;
        private static List<Tuple<Producto, decimal, string>> listaTuplaCarrito;


        #region PROPIEDADES
        public static List<Tuple<Producto, decimal, string>> ListaTuplaCarrito
        {
            get { return listaTuplaCarrito; }
            set { listaTuplaCarrito = value; }
        }


        #endregion


        #region CONSTRUCTOR
        static Manager_Carrito()
        {
            listaTuplaCarrito = new List<Tuple<Producto, decimal, string>>();
        }

        #endregion


        /// <summary>
        /// Actualiza la cantidad del producto en la lista Carrito cuando se agrega un producto que ya estaba.
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="cantidad"></param>
        /// <param name="listaTuplaCarrito"></param>
        /// <param name="auxProducto"></param>
        public static void ActualizarProductoEnCarrito(int indice, decimal cantidad, Producto auxProducto)
        {
            cantidad += Manager_Carrito.listaTuplaCarrito[indice].Item2;
            Manager_Carrito.listaTuplaCarrito[indice] = Tuple.Create(auxProducto, cantidad, FormatearProductoEnCarrito(auxProducto, cantidad));
        }

        /// <summary>
        /// Formatea el string para que aparezca en la ListBox
        /// </summary>
        /// <param name="auxProducto"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static string FormatearProductoEnCarrito(Producto auxProducto, decimal cantidad)
        {
            return String.Format("{0, -30}  {1, 80}", auxProducto, cantidad);
        }

        /// <summary>
        /// Devuelve el índice del producto en la lista Carrito, si no existe devuelve -1
        /// </summary>
        /// <param name="auxProducto"></param>
        /// <param name="listaTuplaCarrito"></param>
        /// <returns></returns>
        public static int ObtenerIndiceProductoEnCarrito(Producto auxProducto)
        {
            for (int i = 0; i < Manager_Carrito.listaTuplaCarrito.Count; i++)
            {
                if (Manager_Carrito.listaTuplaCarrito[i].Item1.Id == auxProducto.Id)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Devuelve true si el producto ya existe en el carrito
        /// </summary>
        /// <param name="auxProducto"></param>
        /// <param name="listaTuplaCarrito"></param>
        /// <returns></returns>
        public static bool ExisteProductoEnCarrito(Producto auxProducto)
        {
            if (ObtenerIndiceProductoEnCarrito(auxProducto) != -1)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Calcula el valor total de los Productos en la lista Carrito
        /// </summary>
        /// <param name="listaTuplaCarrito"></param>
        /// <returns></returns>
        public static decimal CalcularTotal(eMedioDePago medio)
        {
            decimal subtotal = 0;
            decimal total = 0;
            foreach (Tuple<Producto, decimal, string> item in Manager_Carrito.ListaTuplaCarrito)
            {
                subtotal = item.Item2 * (decimal)item.Item1.Precio;

                total += subtotal;

            }
            // recargo por Crédito
            if (medio == eMedioDePago.Crédito)
            {
                total += total * RECARGO_CREDITO;
            }

            return total;
        }

        /// <summary>
        /// Revisa si hay stock suficiente del producto para la cantidad ingresada
        /// </summary>
        /// <param name="auxProducto"></param>
        /// <param name="listaTuplaCarrito"></param>
        /// <returns></returns>
        public static bool ExisteStockDeProducto(Producto auxProducto, decimal cantidad)
        {
            decimal cantidadCargadaEnCarrito = 0;
            int indiceProductoEnCarrito = Manager_Carrito.ObtenerIndiceProductoEnCarrito(auxProducto);

            if (indiceProductoEnCarrito != -1)
            {
                cantidadCargadaEnCarrito = Manager_Carrito.ListaTuplaCarrito[indiceProductoEnCarrito].Item2;
            }
            if (auxProducto.CantidadStock >= (cantidad + cantidadCargadaEnCarrito))
            {
                return true;
            }

            return false;
        }

    }
}
