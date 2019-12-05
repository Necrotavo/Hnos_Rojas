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
using System.Threading;

namespace Hnos_Rojas
{
    public partial class PagoProveedor : Form, IConfirmacion
    {
        DO_Pago doPago = new DO_Pago();

        public void positivo() 
        {
            BL_Proveedor blProveedor = new BL_Proveedor();

            if (blProveedor.pagarProveedor(doPago))
            {
                textBox1.Text = "";
                MensajeExito mensajeExito = new MensajeExito("PAGO A " + listBoxProveedor.SelectedValue.ToString() + " REGISTRADO CORRECTAMENTE");
                mensajeExito.Show();
                //MessageBox.Show("El pago a " + listBoxProveedor.SelectedValue.ToString() + " se ha registrado");
                this.ActiveControl = txtBuscarProveedor;
            }
            else
            {
                MensajeError mensajeError = new MensajeError("HA OCURRIDO UN ERROR");
                mensajeError.Show();
                //MessageBox.Show("Ha ocurrido un error");
            }
        }
        public void negativo() 
        { 

        }

        public PagoProveedor(String usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            if (textBox1.Text != "")
            {
                if (listBoxProveedor.SelectedValue != null)
                {
                    doPago.monto = Convert.ToInt32(textBox1.Text);
                    doPago.proveedor = listBoxProveedor.SelectedValue.ToString();
                    doPago.fecha = DateTime.Now;

                    MensajeConfirmacion mensajeConfirmacion = new MensajeConfirmacion("REALIZAR PAGO DE ₡" + textBox1.Text + " A " + listBoxProveedor.SelectedValue.ToString(), this);
                    mensajeConfirmacion.Show();
                }
                else {
                    MensajeError mensajeError = new MensajeError("NO HA ELEGIDO UN PROVEEDOR");
                    mensajeError.Show();
                    //MessageBox.Show("No ha elegido un proveedor");
                }
            }
            else {
                MensajeError mensajeError = new MensajeError("NO HA INGRESADO MONTO A PAGAR");
                mensajeError.Show();
                //MessageBox.Show("No ha ingresado un monto a pagar");
            }
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
