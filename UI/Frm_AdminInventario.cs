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
        List<Producto> listaInventario;

        #region CONSTRUCTORES

        public Frm_AdminInventario()
        {
            InitializeComponent();
            this.auxProducto = new Producto();
            this.listaInventario = new List<Producto>(TiendaElectronica.ListaProductos);
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
            this.dgv_listaProductos.DataSource = this.listaInventario;
            this.dgv_listaProductos.Columns["nombreLista"].Visible = false;

        }

        private void btn_SeleccionarProducto_Click(object sender, EventArgs e)
        {
            if (auxProducto is not null)
            {
                this.idProducto = auxProducto.Id;
            }
            this.Hide();
        }

        private void dgv_listaProductos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_listaProductos.SelectedRows.Count > 0)
            {
                this.auxProducto = (Producto)dgv_listaProductos.SelectedRows[0].DataBoundItem;
            }
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
                // Instancio el form
                Frm_ModificarProducto frm_Modificar = new Frm_ModificarProducto(this.idProducto, eModificarProductoOpcion.ModificarProducto);
                frm_Modificar.ShowDialog();
                // Chequeo respuesta
                if (frm_Modificar.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Se ha modificado el producto");
                    //lst_listaProductos.ClearSelected();
                }
                // Actualizo la lista
                ActualizarListaInventario();

            }
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            if (dgv_listaProductos.SelectedRows is not null)
            {
                // Instancio el form
                Frm_ModificarProducto frm_Modificar = new Frm_ModificarProducto(eModificarProductoOpcion.AgregarProducto);
                frm_Modificar.ShowDialog();
                // Chequeo respuesta
                if (frm_Modificar.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Se ha agregado el producto");
                }
                // Actualizo la lista
                ActualizarListaInventario();

            }
        }

        private void ActualizarListaInventario()
        {
            this.listaInventario.Clear();
            this.listaInventario.AddRange(TiendaElectronica.ListaProductos);
            this.dgv_listaProductos.DataSource = null;
            this.dgv_listaProductos.DataSource = this.listaInventario;
            this.dgv_listaProductos.Columns["nombreLista"].Visible = false;
        }

    }
}
