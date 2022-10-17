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
    public partial class Frm_Base : Form
    {
        public Frm_Base()
        {
            InitializeComponent();
            this.BackColor = TiendaElectronica.ObtenerColorDeUsuario();
        }
    }
}
