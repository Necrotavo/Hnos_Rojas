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
    public partial class PagoContado : Form
    {
        private DO_Factura factura;
        public PagoContado(DO_Factura _factura)
        {
            InitializeComponent();
            factura = _factura;
            lblTotal.Text = factura.totalFactura.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void cambioValor()
        {
            BL_Factura blFactura = new BL_Factura();

            double total = blFactura.CalcularVuelto(Convert.ToDouble(lblTotal.Text), Convert.ToDouble(nmPaga.Value));

            if (total < 0)
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
            if (Convert.ToDouble(nmPaga.Value) >= Convert.ToDouble(lblTotal.Text))
            {
                registrarFactura();
            }
            else {
                MessageBox.Show("El pago es insuficiente");
            }
        }

        public void registrarFactura() {
            this.factura.clienteExterno = this.txtCliente.Text;
            this.factura.notas = this.txtNotas.Text;
            this.factura.estado = "PAGADA";
            this.factura.tipoPago = "CONTADO";
            BL_Factura blFactura = new BL_Factura();

            blFactura.guardarFactura(factura);

            MessageBox.Show("Pago exitoso");

            this.Dispose();
        }

        private void PagoContado_Load(object sender, EventArgs e)
        {

        }

        private void nmPaga_KeyUp(object sender, KeyEventArgs e)
        {
            cambioValor();
        }

        private void nmPaga_ValueChanged(object sender, EventArgs e)
        {
            cambioValor();
        }
    }
}
