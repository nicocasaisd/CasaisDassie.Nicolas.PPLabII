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
        //int idProducto;
        Producto auxProducto;
        List<Producto> listaInventario;
        Proveedor auxProveedor;

        public Frm_OrdenCompra()
        {
            InitializeComponent();
            this.auxProducto = new Producto();
            this.auxProveedor = new Proveedor();
            //auxProveedor = (Proveedor)cmb_listaProveedores.SelectedItem;
            this.listaInventario = new List<Producto>();
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
            this.listaInventario.Clear();

            auxProveedor = (Proveedor)cmb_listaProveedores.SelectedItem;

            foreach (Producto item in auxProveedor.ListaProductos)
            {
                
                this.listaInventario.Add(item);
                
            }
            ActualizarDataGridList();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (auxProducto is not null)
            {
                //this.idProducto = auxProducto.Id;
                //MessageBox.Show(auxProducto.Id.ToString());
                MessageBox.Show(auxProducto.NombreLista);
            }
            
        }


        private void dgv_listaProductos_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgv_listaProductos.SelectedRows.Count > 0)
            {
                //this.auxProducto = (Producto)dgv_listaProductos.SelectedRows[0].DataBoundItem;
            }
        }
    }
}
