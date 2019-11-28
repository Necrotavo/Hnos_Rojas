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
    public partial class PagoProveedor : Form
    {
        DO_Pago doPago = new DO_Pago();

        public PagoProveedor(String usuario)
        {
            InitializeComponent();
            llenar();
            doPago.usuario = usuario;
        }

        public void llenar() {
            BL_Proveedor blProveedor = new BL_Proveedor();
            List<DO_Proveedor> listaClientes = blProveedor.obtenerListaProveedores(txtBuscarProveedor.Text.Trim(), false);
            listBoxProveedor.DataSource = listaClientes;
            listBoxProveedor.DisplayMember = "nombre";
            listBoxProveedor.ValueMember = "nombre";

            this.ActiveControl = this.txtBuscarProveedor;

            listBoxProveedor.SelectedItem = 0;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            doPago.monto = Convert.ToInt32(textBox1.Text);
            doPago.proveedor = listBoxProveedor.SelectedValue.ToString();
                            
            BL_Proveedor blProveedor = new BL_Proveedor();
            blProveedor.pagarProveedor(doPago);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenar();
        }

        private void listBoxProveedor_DoubleClick(object sender, EventArgs e)
        {
            //llenar();
        }
    }
}
