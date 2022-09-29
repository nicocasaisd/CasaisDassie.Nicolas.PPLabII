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
        public Frm_Venta()
        {
            InitializeComponent();
        }

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            Array eMedio = Enum.GetValues(typeof(eMedioDePago));

            cmb_medioDePago.DataSource = eMedio;
            //eMedioDePago eMedio = new eMedioDePago();
            //List<string> eLista = eMedio.
            //foreach(string item in eMedio.ToString())
            //{

            //}
            //this.cmb_medioDePago.DataSource = eMedio;
        }
    }
}
