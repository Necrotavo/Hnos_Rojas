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
            listBClientes.DataSource = listaClientes;
            listBClientes.DisplayMember = "nombre";
            listBClientes.ValueMember = "id";
        }

        private void listBClientes_Click(object sender, EventArgs e)
        {
            //llamar a la venta de detallesEstado
            //cliente = (DO_Cliente)listBClientes.SelectedItem;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //hacer otra ventana donde se muestre info del cliente seleccionado
        }

        private void txtEstadoCliente_TextChanged(object sender, EventArgs e)
        {
            llenarListBox();
        }
    }
}
