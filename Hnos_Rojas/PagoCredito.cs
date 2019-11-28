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
        private int cliente = 0;
        private DO_Factura factura = new DO_Factura();
        private Ventas parent;
        BL_Credito blCredito = new BL_Credito();
        DO_Credito credito = new DO_Credito();
        public PagoCredito(DO.DO_Factura _factura, Ventas padre)
        {
            InitializeComponent();
            parent = padre;
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
            
            this.factura.clienteExterno = "";
            this.factura.notas = this.txtNotas.Text;
            this.factura.estado = "PENDIENTE";
            this.factura.tipoPago = "CREDITO";
            BL_Factura blFactura = new BL_Factura();
            blFactura.guardarFacturaCredito(factura, Convert.ToInt32(listBClientes.SelectedValue.ToString()));


            FacturaCredito factCred = new FacturaCredito(
                factura.usuario,
                factura.totalFactura.ToString(),
                lbCreditoDisp.Text,
                factura.listaProducto,
                txtNotas.Text,
                listBClientes.Text,
                lbCreditoAnterior.Text);

            
            parent.facturaCreditoTemp = factCred;
            parent.facturaContadoRealizada = false;
            parent.facturaCreditoRealizada = true;

            MessageBox.Show("Pago exitoso");
            parent.cerrarTicket();
            this.Dispose();
        }

        private void filtrarClientes() {

            BL_Cliente clientes = new BL_Cliente();
            List<DO_Cliente> listaClientes = clientes.filtrarClientes(txtBuscarCliente.Text.Trim());
            DataTable tablaClientes = new DataTable();
            tablaClientes.Columns.Add("id");
            tablaClientes.Columns.Add("nombre");
            if (listaClientes != null)
            {
                foreach (DO_Cliente doCliente in listaClientes)
                {
                    tablaClientes.Rows.Add(doCliente.perIdentificador, doCliente.perNombre + " "
                        + doCliente.perPrimerApellido + " " + doCliente.perSegundoApellido);
                }
            
            }
            listBClientes.DataSource = tablaClientes;
            listBClientes.DisplayMember = "nombre";
            listBClientes.ValueMember = "id";

            this.ActiveControl = this.txtBuscarCliente;

            listBClientes.SelectedItem = 0;

            obtenerCreditoSeleccionado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarClientes();
            colorDefaultLblCredDisp();
        }

        private void listBClientes_Click(object sender, EventArgs e)
        {
            obtenerCreditoSeleccionado();
            this.ActiveControl = this.txtBuscarCliente;
        }

        public void obtenerCreditoSeleccionado() {
            cliente = Convert.ToInt32(listBClientes.SelectedValue);
            if (blCredito.ObtenerDatosCredito(cliente) != null) {
                credito = blCredito.ObtenerDatosCredito(cliente);

                lbCreditoAnterior.Text = credito.monto.ToString();//cliente.credito.monto; Aqui es lo que debo
                Double credDisp = blCredito.CalcularSaldo(credito.limiteCredito, credito.monto);
                lbCreditoDisp.Text = (credDisp).ToString();//cliente.credito.monto; el limite menos lo que debe
                lblCredActual.Text = (factura.totalFactura + credito.monto).ToString();
                if (credDisp <= 0)
                {
                    SystemSounds.Exclamation.Play();
                    lblCredActual.BackColor = Color.Maroon;
                }
                else
                {
                    colorDefaultLblCredDisp();
                }
            }
        }

        public void colorDefaultLblCredDisp() {
            lblCredActual.BackColor = Color.FromArgb(24, 107, 94);
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
            Agregar_EditarCliente agregarEditarCliente = new Agregar_EditarCliente();
            agregarEditarCliente.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listBClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   
    }
}
