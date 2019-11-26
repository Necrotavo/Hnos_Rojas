using BL;
using DO;
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
    public partial class AbonarCredito : Form
    {

        DO_Cliente cliente;
        DetallesEstadoCuenta detallesEstadoCuenta;
        public AbonarCredito(DO_Cliente _cliente, DetallesEstadoCuenta _detallesEstadoCuenta)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cliente = _cliente;
            detallesEstadoCuenta = _detallesEstadoCuenta;

            lblMontoCredito.Text = cliente.credito.monto.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtAbono.Text == "")
            {
                MessageBox.Show("No ha ingresado un monto para abonar");
            }
            else {
                BL_Credito blCredito = new BL_Credito();
                blCredito.abonar(Convert.ToInt32(txtAbono.Text), cliente.perIdentificador);
                detallesEstadoCuenta.llenarGrid();
                MessageBox.Show("Abono exitoso");
                this.Dispose();
            }
        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                actualizarLblSaldo();
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                actualizarLblSaldo();
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void actualizarLblSaldo() {
            double saldo = cliente.credito.monto - Convert.ToDouble(txtAbono.Text);
            if (saldo > 0)
            {
                lblSaldoAbono.Text = "Saldo";
                lblSaldo.Text = saldo.ToString();
            }
            else {
                lblSaldoAbono.Text = "Vuelto";
                lblSaldo.Text = (Convert.ToDouble(txtAbono.Text) - cliente.credito.monto).ToString();
            }
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            actualizarLblSaldo();
        }
    }
}
