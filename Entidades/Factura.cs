using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private string cliente;
        private DateTime fecha;
        private string puntoDeVenta;
        private string nroDeFactura;
        private eMedioDePago medioDePago;
        private List<Tuple<Producto, decimal, string>> listaTuplaCarrito;
        private Producto producto;
        private decimal cantidad;

        #region CONSTRUCTORES

        public Factura(string cliente, DateTime fecha, string puntoDeVenta, string nroDeFactura, eMedioDePago medioDePago, List<Tuple<Producto, decimal, string>> listaTuplaCarrito, Producto producto, decimal cantidad)
        {
            this.cliente = cliente;
            this.fecha = fecha;
            this.puntoDeVenta = puntoDeVenta;
            this.nroDeFactura = nroDeFactura;
            this.medioDePago = medioDePago;
            this.listaTuplaCarrito = listaTuplaCarrito;
            this.producto = producto;
            this.cantidad = cantidad;
        }

        #endregion

        #region PROPIEDADES

        public string Cliente
        {
            get { return this.cliente; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
        }

        public string PuntoDeVenta
        {
            get { return this.puntoDeVenta; }
        }

        public string NroDeFactura
        {
            get { return this.nroDeFactura; }
        }

        public eMedioDePago MedioDePago
        {
            get { return this.medioDePago; }
        }

        public List<Tuple<Producto, decimal, string>> ListaTuplaCarrito
        {
            get { return this.listaTuplaCarrito; }
        }

        public decimal Cantidad
        {
            get { return this.cantidad; }
        }

        public Producto Producto
        {
            get { return this.producto; }
        }



        #endregion
    }
}
