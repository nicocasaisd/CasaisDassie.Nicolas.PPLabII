using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Frm_Venta : Form
    {
        const decimal recargoCredito = 0.10M;
        List<Tuple<Producto, decimal, string>> listaTuplaCarrito;

        public Frm_Venta()
        {
            InitializeComponent();
            listaTuplaCarrito = new List<Tuple<Producto, decimal, string>>();
        }

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
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
            lst_carrito.DataSource = listaTuplaCarrito;
        }

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
                if(!ExisteStockDeProducto(auxProducto, this.listaTuplaCarrito))
                {
                    MessageBox.Show("No hay stock suficiente del producto que quiere agregar.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ExisteProductoEnCarrito(auxProducto, this.listaTuplaCarrito))
                {
                    int indiceProducto = this.ObtenerIndiceProductoEnCarrito(auxProducto, listaTuplaCarrito);
                    this.ActualizarProductoEnCarrito(indiceProducto, cantidad, listaTuplaCarrito, auxProducto);
                }
                else
                {
                    this.listaTuplaCarrito.Add(Tuple.Create(auxProducto, cantidad, FormatearProductoEnCarrito(auxProducto, cantidad)));
                }
                // actualiza el DataSource de lst_carrito para que muestre los valores
                ActualizarLista();
            }
        }

        private bool ExisteStockDeProducto(Producto auxProducto, List<Tuple<Producto, decimal, string>> listaTuplaCarrito)
        {
            decimal cantidad = nud_cantidad.Value;
            decimal cantidadCargadaEnCarrito = 0;
            int indiceProductoEnCarrito = ObtenerIndiceProductoEnCarrito(auxProducto, listaTuplaCarrito);
            
            if (indiceProductoEnCarrito != -1)
            {
                cantidadCargadaEnCarrito = listaTuplaCarrito[indiceProductoEnCarrito].Item2;
            }
            if( auxProducto.CantidadStock >= (cantidad + cantidadCargadaEnCarrito))
            {
                return true;
            }

            return false;
        }

        private void btn_RemoverProducto_Click(object sender, EventArgs e)
        {
            if(lst_carrito.SelectedIndex >= 0)
            {
                listaTuplaCarrito.RemoveAt(lst_carrito.SelectedIndex);
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

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            // chequeo si hay campos vacíos
            if( String.IsNullOrEmpty(txt_nombreCliente.Text) || String.IsNullOrEmpty(cmb_puntoDeVenta.Text) 
                || String.IsNullOrEmpty(txt_nroDeFactura.Text) || this.listaTuplaCarrito.Count == 0)
            {
                MessageBox.Show("Debe completar todos los campos y el carrito no puede estar vacío.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // asigno los campos del formulario
                string cliente = txt_nombreCliente.Text;
                DateTime fecha = dtp_fecha.Value;
                string puntoDeVenta = cmb_puntoDeVenta.Text;
                int nroDeFactura = int.Parse(txt_nroDeFactura.Text);
                eMedioDePago medioDePago = (eMedioDePago)cmb_medioDePago.SelectedItem;
                decimal total = CalcularTotal(this.listaTuplaCarrito); 
                // instancio el objeto factura
                Factura nuevaFactura = new Factura(cliente, fecha, puntoDeVenta, nroDeFactura, medioDePago, total, this.listaTuplaCarrito);
                // instancio un Frm_Factura
                Frm_Factura frm_Factura = new Frm_Factura(nuevaFactura);
                frm_Factura.Show();
                // limpio los datos
                this.LimpiarCampos();

            }

        }

        private void cmb_medioDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            // actualizo txt_total
            txt_total.Text = CalcularTotal(listaTuplaCarrito).ToString();
        }

        #region METODOS LÓGICA

        private void LimpiarCampos()
        {
            // Cargo el nro de factura
            txt_nroDeFactura.Text = Factura.ProximoNroDeFactura.ToString("D8");
            // Reseteo fecha
            dtp_fecha.Value = DateTime.Now;
            // cmb_puntoDeVenta , opcion por defecto
            cmb_puntoDeVenta.SelectedIndex = 0;
            nud_cantidad.Value = 0;
            // limpio la listaTuplaCarrito y la recargo
            listaTuplaCarrito.Clear();
            this.ActualizarLista();
        }

        private void ActualizarLista()
        {
            lst_carrito.DataSource = null;
            lst_carrito.DataSource = this.listaTuplaCarrito;
            // actualizo txt_total
            txt_total.Text = CalcularTotal(listaTuplaCarrito).ToString();
            lst_carrito.DisplayMember = "Item3";
        }

        private decimal CalcularTotal(List<Tuple<Producto, decimal, string>> listaTuplaCarrito)
        {
            decimal subtotal = 0;
            decimal total = 0;
            foreach (Tuple<Producto, decimal, string> item in listaTuplaCarrito)
            {
                subtotal = item.Item2 * (decimal)item.Item1.Precio;

                total += subtotal;

            }
            // recargo por Crédito
            if (cmb_medioDePago.SelectedItem.Equals(eMedioDePago.Crédito))
            {
                total += total * recargoCredito;
            }

            return total;
        }

        private bool ExisteProductoEnCarrito(Producto auxProducto, List<Tuple<Producto, decimal, string>> listaTuplaCarrito)
        {
            if(ObtenerIndiceProductoEnCarrito(auxProducto, listaTuplaCarrito) != -1)
            {
                return true;
            }

            return false;
        }
        private int ObtenerIndiceProductoEnCarrito(Producto auxProducto, List<Tuple<Producto, decimal, string>> listaTuplaCarrito)
        {
            for (int i = 0; i < listaTuplaCarrito.Count; i++)
            {
                if (listaTuplaCarrito[i].Item1.Id == auxProducto.Id)
                {
                    return i;
                }
            }
            return -1;
        }

        private void ActualizarProductoEnCarrito(int indice, decimal cantidad, List<Tuple<Producto, decimal, string>> listaTuplaCarrito, Producto auxProducto)
        {
            cantidad += this.listaTuplaCarrito[indice].Item2;
            this.listaTuplaCarrito[indice] = Tuple.Create(auxProducto, cantidad, FormatearProductoEnCarrito(auxProducto, cantidad));
        }

        private string FormatearProductoEnCarrito(Producto auxProducto, decimal cantidad)
        {
            //return $"{auxProducto, -20}  {cantidad, 20}";
            return String.Format("{0, -30}  {1, 80}", auxProducto, cantidad);
        }





        #endregion

        
    }
}
