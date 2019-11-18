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
            BL_Factura blFactura = new BL_Factura();

            double total = blFactura.CalcularVuelto(Convert.ToDouble(lblTotal.Text), Convert.ToDouble(nmPaga.Value));
            
            if (total<0)
            {
                lblVuelto.ForeColor = Color.Red;
            }
            else
            {
                lblVuelto.ForeColor = Color.White;
            }
            lblVuelto.Text = total.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FacturaReporte fact = new FacturaReporte();
            fact.Show();
        }

        private void PagoContado_Load(object sender, EventArgs e)
        {

        }
    }
}
