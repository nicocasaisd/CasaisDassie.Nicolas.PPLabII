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
    public partial class Frm_Estadisticas : Form
    {
        //int totalVentas;
        //decimal totalGanacia = 0;
        //string productoMasVendido = "";
        eCategoriaProducto categoria;
        



        public Frm_Estadisticas()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }

        private void Frm_Estadisticas_Load(object sender, EventArgs e)
        {
            // cmb
            Array eCategoria = Enum.GetValues(typeof(eCategoriaProducto));
            cmb_categoria.DataSource = eCategoria;
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoria = (eCategoriaProducto)cmb_categoria.SelectedItem;
            
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            CalcularDatos();
        }

        private void CalcularDatos()
        {
            CalcularTotalVentas();
            CalcularTotalGanancia();
            CalcularMasVendido();
            CalcularPromedioGananciaCategoria();
        }

        private void CalcularPromedioGananciaCategoria()
        {
            decimal cantidadVendida = 0;
            decimal totalVendido = 0;
            decimal promedioVendido = 0;

            foreach (Factura item in TiendaElectronica.ListaFacturas)
            {
                foreach (Tuple<Producto, decimal, string> tupla in item.ListaTuplaCarrito)
                {
                    Producto auxProducto = tupla.Item1;
                    decimal auxCantidad = tupla.Item2;
                    if (auxProducto.Categoria == this.categoria)
                    {
                        cantidadVendida += auxCantidad;
                        totalVendido += auxProducto.Precio * auxCantidad;
                    }
                }
            }

            if(cantidadVendida > 0)
            {
                promedioVendido = totalVendido / cantidadVendida;
            }

            txt_promedioDeGanancia.Text = promedioVendido.ToString();
        }

        private void CalcularMasVendido()
        {
            int idProducto;
            string nombreProducto = "";
            decimal cantidadVendida;
            decimal cantidadMaxima = 0;
            string productoMasVendido = "";

            foreach(Producto producto in TiendaElectronica.ListaProductos)
            {
                cantidadVendida = 0;

                if(producto.Categoria == this.categoria)
                {
                    idProducto = producto.Id;
                    nombreProducto = producto.Nombre;

                    foreach (Factura item in TiendaElectronica.ListaFacturas)
                    {
                        foreach (Tuple<Producto, decimal, string> tupla in item.ListaTuplaCarrito)
                        {
                            Producto auxProducto = tupla.Item1;
                            decimal auxCantidad = tupla.Item2;
                            // si es el mismo producto de la categoria que itero
                            if (auxProducto.Id == idProducto)
                            {
                                cantidadVendida += auxCantidad;
                            }
                        }
                    }


                }

                // 
                if(cantidadVendida > cantidadMaxima)
                {
                    productoMasVendido = nombreProducto;
                }
            }

            // asigno el campo

            txt_productoMasVendido.Text = productoMasVendido;
            
        }

        private void CalcularTotalGanancia()
        {
            decimal totalGanancia = 0;

            foreach(Factura item in TiendaElectronica.ListaFacturas)
            {
                totalGanancia += item.Total;
            }
            txt_totalGanancia.Text = totalGanancia.ToString();
        }

        private void CalcularTotalVentas()
        {
            decimal totalVentas = 0;

            totalVentas = TiendaElectronica.ListaFacturas.Count;
            txt_ventasTotales.Text = totalVentas.ToString();
        }

        
    }
}
