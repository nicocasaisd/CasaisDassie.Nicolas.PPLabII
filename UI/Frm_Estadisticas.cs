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
        int totalVentas;
        decimal totalGanacia = 0;
        



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
            CalcularDatos();
        }

        private void CalcularDatos()
        {
            CalcularTotalVentas();
            CalcularTotalGanancia();
            CalcularMasVendido();
        }

        private void CalcularMasVendido()
        {
            
        }

        private void CalcularTotalGanancia()
        {
            foreach(Factura item in TiendaElectronica.ListaFacturas)
            {
                totalGanacia += item.Total;
            }
            txt_totalGanancia.Text = totalGanacia.ToString();
        }

        private void CalcularTotalVentas()
        {
            totalVentas = TiendaElectronica.ListaFacturas.Count;
            txt_ventasTotales.Text = totalVentas.ToString();
        }
    }
}
