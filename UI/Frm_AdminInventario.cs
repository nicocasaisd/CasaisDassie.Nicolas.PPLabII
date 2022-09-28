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
    public partial class Frm_AdminInventario : Form
    {
        public Frm_AdminInventario()
        {
            InitializeComponent();
        }

        private void Frm_AdminInventario_Load(object sender, EventArgs e)
        {
            this.lst_listaProductos.DataSource = TiendaElectronica.ListaProductos;
        }

        private void lst_listaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el item seleccionado actualmente
            Producto auxProducto = (Producto) lst_listaProductos.SelectedItem;

            // Seteo valores
            lbl_cantidadProducto.Text = auxProducto.CantidadStock.ToString();
            lbl_precioProducto.Text = auxProducto.Precio.ToString();
            lbl_idProducto.Text = auxProducto.Id.ToString();

        }

        private void btn_cambiarPrecio_Click(object sender, EventArgs e)
        {
            // Obtengo el indice del producto seleccionado
            int indexProducto = lst_listaProductos.SelectedIndex;
            // Instancio el form
            Frm_ModificarProducto frm_Modificar = new Frm_ModificarProducto(indexProducto);
            frm_Modificar.ShowDialog();
            //lst_listaProductos.ClearSelected();

        }
    }
}
