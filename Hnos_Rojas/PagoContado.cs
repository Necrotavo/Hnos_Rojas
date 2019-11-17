using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hnos_Rojas
{
    public partial class PagoContado : Form
    {
        public PagoContado(DO.DO_Factura factura)
        {
            InitializeComponent();
            lblTotal.Text = factura.totalFactura.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblVuelto.Text = (Convert.ToInt32(lblTotal.Text) - Convert.ToInt32(numericUpDown1.Value)).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
