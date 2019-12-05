using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DO;

namespace Hnos_Rojas
{
    public partial class TodasFacturas : Form
    {
        public TodasFacturas()
        {
            InitializeComponent();
        }

        private void llenarGrdFacturas()
        {
            BL_Factura blFactura = new BL_Factura();
            grdFacturas.DataSource = blFactura.obtenerTodasLasFacturas("2019-10-4", "2019-12-4");
        }
    }
}
