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
using static UI.Frm_ModificarProducto;

namespace UI
{
    public partial class Frm_AdminInventario : Form
    {
        int idProducto = -1;
        Producto auxProducto;
        List<Producto> listaProductos;

        #region CONSTRUCTORES

        public Frm_AdminInventario()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public int IdProducto
        {
            get { return idProducto; }
        }

        #endregion

        private void Frm_AdminInventario_Load(object sender, EventArgs e)
        {
            listaProductos = new List<Producto>(TiendaElectronica.ListaProductos);
            this.lst_listaProductos.DataSource = TiendaElectronica.ListaProductos;
            this.dgv_listaProductos.DataSource = this.listaProductos;
            this.dgv_listaProductos.Columns["descripcion"].Visible = false;
            this.dgv_listaProductos.Columns["nombreLista"].Visible = false;
            this.dgv_listaProductos.Columns["categoria"].Visible = false;
        }

        private void lst_listaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lo mismo con dgv

            // Obtener el item seleccionado actualmente
            if(lst_listaProductos.SelectedItem != null)
            {
                Producto auxProducto = (Producto) lst_listaProductos.SelectedItem;
                // Seteo valores
                lbl_cantidadProducto.Text = auxProducto.CantidadStock.ToString();
                lbl_precioProducto.Text = auxProducto.Precio.ToString();
                lbl_idProducto.Text = auxProducto.Id.ToString();
            }
            else
            {
                // Seteo valores
                lbl_cantidadProducto.Text = String.Empty;
                lbl_precioProducto.Text = String.Empty;
                lbl_idProducto.Text = String.Empty;
            }

            

        }

        //private void btn_cambiarPrecio_Click(object sender, EventArgs e)
        //{
        //    if(lst_listaProductos.SelectedIndex  >= 0)
        //    {
        //        // Obtengo el indice del producto seleccionado
        //        int indexProducto = lst_listaProductos.SelectedIndex;
        //        // Instancio el form
        //        Frm_ModificarProducto frm_Modificar = new Frm_ModificarProducto(indexProducto, ModificarProductoOpcion.CambiarPrecio);
        //        frm_Modificar.ShowDialog();

        //        if(frm_Modificar.DialogResult == DialogResult.OK)
        //        {
        //            MessageBox.Show("Se ha modificado el precio de un producto");
        //            lst_listaProductos.ClearSelected();
        //        }
        //    }
        //}

        //private void btn_cambiarCantidad_Click(object sender, EventArgs e)
        //{
        //    if (lst_listaProductos.SelectedIndex >= 0)
        //    {
        //        // Obtengo el indice del producto seleccionado
        //        int indexProducto = lst_listaProductos.SelectedIndex;
        //        // Instancio el form
        //        Frm_ModificarProducto frm_Modificar = new Frm_ModificarProducto(indexProducto, ModificarProductoOpcion.CambiarCantidad);
        //        frm_Modificar.ShowDialog();
        //        // Chequeo respuesta
        //        if (frm_Modificar.DialogResult == DialogResult.OK)
        //        {
        //            MessageBox.Show("Se ha modificado el stock de un producto");
        //            lst_listaProductos.ClearSelected();
        //        }
        //    }
        //}

        private void btn_SeleccionarProducto_Click(object sender, EventArgs e)
        {
            if (lst_listaProductos.SelectedIndex >= 0)
            {
                // Obtengo el indice del producto seleccionado
                int indexProducto = lst_listaProductos.SelectedIndex;
                // Guardo en un aux de producto
                Producto auxProducto = (Producto) lst_listaProductos.Items[indexProducto];
                // Obtengo la id
                this.idProducto = auxProducto.Id;
            }
            this.Hide();
        }

        private void dgv_listaProductos_SelectionChanged(object sender, EventArgs e)
        {
            auxProducto = (Producto)dgv_listaProductos.SelectedRows[0].DataBoundItem;
            // seteo la id
            this.idProducto = auxProducto.Id;
            // muestro en labels
            lbl_idProducto.Text = auxProducto.Id.ToString();
            lbl_cantidadProducto.Text = auxProducto.CantidadStock.ToString();
        }

        private void btn_ModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgv_listaProductos.SelectedRows is not null)
            {
                // Obtengo el indice del producto seleccionado
                //int indexProducto = 
                // Instancio el form
                Frm_ModificarProducto frm_Modificar = new Frm_ModificarProducto(this.idProducto, eModificarProductoOpcion.ModificarProducto);
                frm_Modificar.ShowDialog();
                // Chequeo respuesta
                if (frm_Modificar.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Se ha modificado el producto");
                    //lst_listaProductos.ClearSelected();
                }
            }
        }
    }
}
