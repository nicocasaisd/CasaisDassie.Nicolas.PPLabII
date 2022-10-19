using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {

        #region ATRIBUTOS

        private static int proximoNroDeFactura = 1;

        private string cliente;
        private DateTime fecha;
        private string puntoDeVenta;
        private int nroDeFactura;
        private eMedioDePago medioDePago;
        private decimal total;
        private decimal vuelto;
        private List<Tuple<Producto, decimal, string>> listaTuplaCarrito;

        #endregion

        #region CONSTRUCTORES

        public Factura()
        {
        }
        public Factura(string cliente, DateTime fecha, string puntoDeVenta, int nroDeFactura, eMedioDePago medioDePago, decimal total, decimal vuelto, List<Tuple<Producto, decimal, string>> listaTuplaCarrito)
        {
            this.cliente = cliente;
            this.fecha = fecha;
            this.puntoDeVenta = puntoDeVenta;
            this.nroDeFactura = nroDeFactura;
            this.medioDePago = medioDePago;
            this.total = total;
            this.vuelto = vuelto;
            this.listaTuplaCarrito = listaTuplaCarrito;
            // aumenta el nro de factura
            Factura.ProximoNroDeFactura++;
        }

        #endregion

        #region PROPIEDADES

        public static int ProximoNroDeFactura
        {
            get { return proximoNroDeFactura; }
            set { proximoNroDeFactura = value; }
        }

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

        public int NroDeFactura
        {
            get { return this.nroDeFactura; }
        }

        public eMedioDePago MedioDePago
        {
            get { return this.medioDePago; }
        }

        public decimal Total
        {
            get { return this.total;  }
        }

        public decimal Vuelto
        {
            get { return this.vuelto; }
        }

        public List<Tuple<Producto, decimal, string>> ListaTuplaCarrito
        {
            get { return this.listaTuplaCarrito; }
            set { listaTuplaCarrito = value; }
        }

        #endregion
    }
}
