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
    public partial class AbonarFactura : Form
    {
        DetallesEstadoCuenta estCuenta;
        DO_Factura doFactura;
        public AbonarFactura(DO_Factura _doFactura, DetallesEstadoCuenta _detallesEstadoCuenta)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            doFactura = _doFactura;
            estCuenta = _detallesEstadoCuenta;
            llenarLbls();
        }

        public void llenarLbls() {
            this.lblCodigo.Text = doFactura.codigoFactura.ToString();
            this.lblSaldoActual.Text = doFactura.saldo.ToString();
        }

        public void actualizarLblSaldo()
        {
            double saldo = doFactura.saldo - Convert.ToDouble(txtAbono.Text);
            if (saldo > 0)
            {
                lblSaldoAbono.Text = "Saldo";
                lblSaldo.Text = saldo.ToString();
            }
            else
            {
                lblSaldoAbono.Text = "Vuelto";
                lblSaldo.Text = (Convert.ToDouble(txtAbono.Text) - doFactura.saldo).ToString();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtAbono.Text == "")
            {
                MessageBox.Show("No ha ingresado un monto para abonar");
            }
            else
            {
                BL_Factura blFactura = new BL_Factura();
                blFactura.abonarFactura(doFactura, Convert.ToDouble(txtAbono.Text));
                estCuenta.llenarGrid();
                MessageBox.Show("Abono exitoso");
                this.Dispose();
            }
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            actualizarLblSaldo();
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
    }
}
