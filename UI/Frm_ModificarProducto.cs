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
    public partial class Frm_ModificarProducto : Form
    {
        int indexProducto;
        Producto auxProducto;

        public Frm_ModificarProducto()
        {
            InitializeComponent();
            auxProducto = new Producto();
        }

        public Frm_ModificarProducto(int indexProducto) :this()
        {
            this.indexProducto = indexProducto;
        }

        private void Frm_ModificarProducto_Load(object sender, EventArgs e)
        {
            auxProducto = TiendaElectronica.ListaProductos[indexProducto];
            lbl_precioAnteriorContenido.Text = auxProducto.Precio.ToString();
        }
    }
}
 