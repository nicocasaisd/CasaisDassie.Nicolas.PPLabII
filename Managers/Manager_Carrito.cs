using System;
using System.Collections.Generic;

namespace Managers
{
    public static class Manager_Carrito
    {

        List<Tuple<Producto, decimal, string>> listaTuplaCarrito;





        /// <summary>
        /// Actualiza la cantidad del producto en la lista Carrito cuando se agrega un producto que ya estaba.
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="cantidad"></param>
        /// <param name="listaTuplaCarrito"></param>
        /// <param name="auxProducto"></param>
        private static void ActualizarProductoEnCarrito(int indice, decimal cantidad, List<Tuple<Producto, decimal, string>> listaTuplaCarrito, Producto auxProducto)
        {
            cantidad += this.listaTuplaCarrito[indice].Item2;
            this.listaTuplaCarrito[indice] = Tuple.Create(auxProducto, cantidad, FormatearProductoEnCarrito(auxProducto, cantidad));
        }

    }
}
