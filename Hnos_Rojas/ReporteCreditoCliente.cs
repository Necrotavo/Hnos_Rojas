using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO;
using BL;


namespace Hnos_Rojas
{
    public partial class ReporteCreditoCliente : Form
    {
        public ReporteCreditoCliente(List<DO_Factura> facturas)
        {
            InitializeComponent();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
