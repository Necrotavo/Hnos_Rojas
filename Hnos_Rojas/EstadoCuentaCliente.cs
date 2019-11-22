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
    public partial class EstadoCuentaCliente : Form
    {
        DO_Cliente cliente = new DO_Cliente();
        public EstadoCuentaCliente()
        {
            InitializeComponent();
            llenarListBox();
            txtEstadoCliente.Focus();
        }

        private void llenarListBox()
        {
            BL_Cliente clientes = new BL_Cliente();

            List<DO_Cliente> listaClientes = clientes.filtrarClientes(txtEstadoCliente.Text.Trim());

            DataTable tablaClientes = new DataTable();
            tablaClientes.Columns.Add("id");
            tablaClientes.Columns.Add("nombre");

            foreach (DO_Cliente doCliente in listaClientes)
            {
                tablaClientes.Rows.Add(doCliente.perIdentificador, doCliente.perNombre + " "
                    + doCliente.perPrimerApellido + " " + doCliente.perSegundoApellido);
            }

            listBClientes.DataSource = tablaClientes;
            listBClientes.DisplayMember = "nombre";
            listBClientes.ValueMember = "id";

            listBClientes.SelectedItem = 0;
        }

        private void listBClientes_Click(object sender, EventArgs e)
        {
            //llamar a la venta de detallesEstado\
            BL_Cliente blCliente = new BL_Cliente();
            cliente = blCliente.buscarCliente(Convert.ToInt32(this.listBClientes.SelectedValue));
            
            DetallesEstadoCuenta detallesEstadoCuenta = new DetallesEstadoCuenta(cliente) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            
            Parent.Controls.Add(detallesEstadoCuenta);
            detallesEstadoCuenta.Show();
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //hacer otra ventana donde se muestre info del cliente seleccionado
        }

        private void txtEstadoCliente_TextChanged(object sender, EventArgs e)
        {
            llenarListBox();
        }

        private void EstadoCuentaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
