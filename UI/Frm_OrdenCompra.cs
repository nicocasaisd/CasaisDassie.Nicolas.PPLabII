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
    public partial class Frm_OrdenCompra : Form
    {

        List<Producto> listaInventario;
        Proveedor auxProveedor;

        public Frm_OrdenCompra()
        {
            InitializeComponent();
            this.listaInventario = new List<Producto>();
            auxProveedor = (Proveedor)cmb_listaProveedores.SelectedItem;
            ActualizarListaInventario();
        }

        private void ActualizarListaInventario()
        {
            if(auxProveedor != null)
            {
                this.listaInventario = new List<Producto>(this.listaInventario);
                this.listaInventario = this.auxProveedor.ListaProductos;

            }
        }

        private void ActualizarDataGridList()
        {
            this.dgv_listaProductos.DataSource = null;
            this.dgv_listaProductos.DataSource = this.listaInventario;
        }

        private void Frm_OrdenCompra_Load(object sender, EventArgs e)
        {
            this.dgv_listaProductos.DataSource = this.listaInventario;
            cmb_listaProveedores.DataSource = TiendaElectronica.ListaProveedores;
        }

        private void cmb_listaProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            auxProveedor = (Proveedor)cmb_listaProveedores.SelectedItem;
            ActualizarDataGridList();
        }
    }
}
