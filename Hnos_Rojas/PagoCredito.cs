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
    public partial class PagoCredito : Form
    {
        private DO_Cliente cliente = new DO_Cliente();
        private DO_Factura factura = new DO_Factura();
        public PagoCredito(DO.DO_Factura _factura)
        {
            InitializeComponent();
            factura = _factura;
            lblTotal.Text = factura.totalFactura.ToString();
            filtrarClientes();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //private void mostrarClientes() {
          //  BL_Cliente clientes = new BL_Cliente();
            //List<DO_Cliente> listaClientes = clientes.obtenerListaClientes();
            //listBClientes.DataSource = listaClientes;
            //listBClientes.DisplayMember = "nombre";
            //listBClientes.ValueMember = "id";
       // }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cliente.nombre);
            //cliente.credito.monto += factura.totalFactura;
            this.Visible = false;
        }

        private void filtrarClientes() {

            BL_Cliente clientes = new BL_Cliente();
            List<DO_Cliente> listaClientes = clientes.filtrarClientes(txtBuscarCliente.Text.Trim());
            listBClientes.DataSource = listaClientes;
            listBClientes.DisplayMember = "nombre";
            listBClientes.ValueMember = "id";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarClientes();
        }

        private void listBClientes_Click(object sender, EventArgs e)
        {
            BL_Credito blCredito = new BL_Credito();
            DO_Credito credito = new DO_Credito();

            cliente = (DO_Cliente)listBClientes.SelectedItem;
            credito = blCredito.ObtenerDatosCredito(cliente.id);

            lbCreditoActual.Text = credito.monto.ToString();//cliente.credito.monto; Aqui es lo que debo
            lbCreditoDisp.Text = (blCredito.CalcularSaldo(credito.limiteCredito,credito.monto)).ToString();//cliente.credito.monto; el limite menos lo que debe
            //cliente.monto;
            //cliente.limiteCredito - cliente.monto;
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            filtrarClientes();
            txtBuscarCliente.Focus();
        }

        private void listBClientes_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void PagoCredito_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //llamar a la ventana de Agregar cliente
        }
    }
}
