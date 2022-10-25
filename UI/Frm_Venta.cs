using Entidades;
using Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Frm_Venta : Frm_Base
    {
        #region ATRIBUTOS
        const decimal recargoCredito = 0.10M;
        //List<Tuple<Producto, decimal, string>> listaTuplaCarrito;
        #endregion

        #region CONSTRUCTORES

        public Frm_Venta()
        {
            InitializeComponent();
            //listaTuplaCarrito = new List<Tuple<Producto, decimal, string>>();
        }

        #endregion

        #region METODOS FORM

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            if(TiendaElectronica.UsuarioLogueado.GetType() == typeof(Vendedor))
            {
                this.HabilitarBotonCerrarSesion();
            }
            // Cargo el nro de factura
            txt_nroDeFactura.Text = Factura.ProximoNroDeFactura.ToString("D8");
            // Agrego data al cmb_medioDePago
            Array eMedio = Enum.GetValues(typeof(eMedioDePago));
            cmb_medioDePago.DataSource = eMedio;
            // Format del DateTimePicker
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.CustomFormat = "dd/MM/yyyy";
            // cmb_puntoDeVenta , opcion por defecto
            cmb_puntoDeVenta.SelectedIndex = 0;
            // cargo la listaCarrito en lst_carrito
            lst_carrito.DataSource = Manager_Carrito.ListaTuplaCarrito;
        }

        /// <summary>
        /// Instancia el Form para Seleccionar Producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llb_SeleccionarProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_AdminInventario frm_Admin = new Frm_AdminInventario(Frm_AdminInventario.eAdminInventarioOpcion.SeleccionarProducto);
            frm_Admin.ShowDialog();
            // cargo el producto
            if (frm_Admin.IdProducto >= 1000)
            {
                this.txt_codigo.Text = frm_Admin.IdProducto.ToString();
                this.btn_AgregarProducto.Enabled = true;
            }

            
            
        }

        /// <summary>
        /// Valida la cantidad, el stock y si ya existe en la lista, y luego agrega la tupla Producto-Cantidad-String a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            decimal cantidad = this.nud_cantidad.Value;
            Producto auxProducto;
           
            if(!String.IsNullOrEmpty(txt_codigo.Text) && cantidad > 0)
            {
                // cargo el producto a partir del idProducto
                int indexProducto = TiendaElectronica.ObtenerIndexProducto(int.Parse(txt_codigo.Text));
                auxProducto = TiendaElectronica.ListaProductos[indexProducto];
                // me fijo si ya existe y lo agrego a la lista
                if(!ExisteStockDeProducto(auxProducto))
                {
                    Sonido("chord.wav");
                    MessageBox.Show("No hay stock suficiente del producto que quiere agregar.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Manager_Carrito.ExisteProductoEnCarrito(auxProducto))
                {
                    int indiceProducto = Manager_Carrito.ObtenerIndiceProductoEnCarrito(auxProducto);
                    Manager_Carrito.ActualizarProductoEnCarrito(indiceProducto, cantidad, auxProducto);
                }
                else
                {
                    Manager_Carrito.ListaTuplaCarrito.Add(Tuple.Create(auxProducto, cantidad, Manager_Carrito.FormatearProductoEnCarrito(auxProducto, cantidad)));
                }
                
                // actualiza el DataSource de lst_carrito para que muestre los valores
                ActualizarLista();
            }
        }


        private void btn_RemoverProducto_Click(object sender, EventArgs e)
        {
            if(lst_carrito.SelectedIndex >= 0)
            {
                Manager_Carrito.ListaTuplaCarrito.RemoveAt(lst_carrito.SelectedIndex);
                ActualizarLista();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult eCancelar;
            eCancelar = MessageBox.Show("¿Desea cerrar el formulario?", "Descartar el formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(eCancelar == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Revisa que todos los campos estén completados, instancia una Factura y abre el modal Factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            // chequeo si hay campos vacíos
            if( String.IsNullOrEmpty(txt_nombreCliente.Text) || String.IsNullOrEmpty(cmb_puntoDeVenta.Text) 
                || String.IsNullOrEmpty(txt_nroDeFactura.Text) || Manager_Carrito.ListaTuplaCarrito.Count == 0)
            {
                MessageBox.Show("Debe completar todos los campos y el carrito no puede estar vacío.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(nud_dineroCliente.Value < Manager_Carrito.CalcularTotal((eMedioDePago)cmb_medioDePago.SelectedItem))
            {
                MessageBox.Show("El dinero ingresado no es suficiente para abonar el total.", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // asigno los campos del formulario
                string cliente = txt_nombreCliente.Text;
                DateTime fecha = dtp_fecha.Value;
                string puntoDeVenta = cmb_puntoDeVenta.Text;
                int nroDeFactura = int.Parse(txt_nroDeFactura.Text);
                eMedioDePago medioDePago = (eMedioDePago)cmb_medioDePago.SelectedItem;
                decimal total = Manager_Carrito.CalcularTotal((eMedioDePago)cmb_medioDePago.SelectedItem);
                decimal vuelto = nud_dineroCliente.Value - total;
                // instancio el objeto factura
                Factura nuevaFactura = new Factura(cliente, fecha, puntoDeVenta, nroDeFactura, medioDePago, total, vuelto, Manager_Carrito.ListaTuplaCarrito);
                // instancio un Frm_Factura
                Frm_Factura frm_Factura = new Frm_Factura(nuevaFactura);
                Sonido("add.wav");
                frm_Factura.Show();
                // limpio los datos
                this.LimpiarCampos();
            }
        }

        /// <summary>
        /// Actualiza el total cuando se cambia el medio de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_medioDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            // actualizo txt_total
            txt_total.Text = Manager_Carrito.CalcularTotal((eMedioDePago)cmb_medioDePago.SelectedItem).ToString();
        }

        /// <summary>
        /// Instancia el Form Historial de Facturas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llb_historialDeFacturas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_HistorialDeFacturas frm_historial = new Frm_HistorialDeFacturas();
            frm_historial.ShowDialog();
        }

        #endregion

        #region METODOS LÓGICA


        /// <summary>
        /// Revisa si hay stock suficiente del producto para la cantidad ingresada
        /// </summary>
        /// <param name="auxProducto"></param>
        /// <param name="listaTuplaCarrito"></param>
        /// <returns></returns>
        private bool ExisteStockDeProducto(Producto auxProducto)
        {
            decimal cantidad = nud_cantidad.Value;
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

        private void LimpiarCampos()
        {
            // Cargo el nro de factura
            txt_nroDeFactura.Text = Factura.ProximoNroDeFactura.ToString("D8");
            // Reseteo fecha
            dtp_fecha.Value = DateTime.Now;
            // cmb_puntoDeVenta , opcion por defecto
            cmb_puntoDeVenta.SelectedIndex = 0;
            nud_cantidad.Value = 0;
            nud_dineroCliente.Value = 0;
            // limpio la listaTuplaCarrito y la recargo
            Manager_Carrito.ListaTuplaCarrito.Clear();
            this.ActualizarLista();
        }

        private void ActualizarLista()
        {
            lst_carrito.DataSource = null;
            lst_carrito.DataSource = Manager_Carrito.ListaTuplaCarrito;
            // actualizo txt_total
            txt_total.Text = Manager_Carrito.CalcularTotal((eMedioDePago)cmb_medioDePago.SelectedItem).ToString();
            lst_carrito.DisplayMember = "Item3";
        }

        #endregion

    }
}
