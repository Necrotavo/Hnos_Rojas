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
        private Ventas padre;
        public PagoContado(DO_Factura _factura, Ventas padreVentas)
        {
            InitializeComponent();
            factura = _factura;
            padre = padreVentas;
            
            lblTotal.Text = factura.totalFactura.ToString();
            nmPaga.Value = Convert.ToDecimal(factura.totalFactura);
            nmPaga.Select();
            nmPaga.Select(0, nmPaga.Text.Length);
            

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

        private void hacerPago()
        {
            if (Convert.ToDouble(nmPaga.Value) >= Convert.ToDouble(lblTotal.Text))
            {
                registrarFactura();
                FacturaContado factOpt = new FacturaContado(
                    factura.usuario,
                    factura.totalFactura.ToString(),
                    nmPaga.Value.ToString(),
                    lblVuelto.Text,
                    factura.listaProducto,
                    txtNotas.Text,
                    txtCliente.Text
                    );
                padre.facturaContadoTemp = factOpt;
                padre.cerrarTicket();
                this.Dispose();
            }
            else
            {
                MensajeError mensajeError = new MensajeError("EL PAGO ES INSUFICIENTE");
                mensajeError.Show();
                //MessageBox.Show("El pago es insuficiente");
            }
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            hacerPago();
            padre.facturaContadoRealizada = true;
            padre.facturaCreditoRealizada = false;
            
        }

        public void registrarFactura() {
            this.factura.clienteExterno = this.txtCliente.Text;
            this.factura.notas = this.txtNotas.Text;
            this.factura.estado = "PAGADA";
            this.factura.tipoPago = "CONTADO";
            BL_Factura blFactura = new BL_Factura();

            blFactura.guardarFactura(factura);

            MensajeExito mensajeExito = new MensajeExito("PAGO EXITOSO");
            mensajeExito.Show();
            //MessageBox.Show("Pago exitoso");

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


        private void nmPaga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hacerPago();
            }
        }
    }
}
