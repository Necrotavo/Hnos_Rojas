using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        public PagoCredito(DO.DO_Factura factura)
        {
            InitializeComponent();
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
            //cliente = (DO_Cliente)listBClientes.SelectedItem;
            //BL_Credito blCredito = new BL_Credito();
            //DO_Credito doCredito = blCredito.obtenerDatosCredito(cliente.id);
            //lbCreditoActual.Text = ""+ doCredito.monto;//cliente.credito.monto; Aqui es lo que debo
            //double credDisp = doCredito.limiteCredito - doCredito.monto;
            //lbCreditoDisp.Text = ""+(credDisp);//cliente.credito.monto; el limite menos lo que debe
            //if (credDisp < 0) {
            //    SystemSounds.Exclamation.Play();
            //}
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            filtrarClientes();
            txtBuscarCliente.Focus();
        }

        private void listBClientes_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
