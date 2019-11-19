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
    public partial class ClienteNuevo : Form
    {
        public ClienteNuevo()
        {
            InitializeComponent();
        }

        public void NuevoCliente(DO_Cliente nuevoCliente) {
            BL_Cliente daoCliente = new BL_Cliente();
            daoCliente.registrarClienteCrediticio(nuevoCliente);
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Equals("") || txtPriApellido.Equals("") || txtDireccion.Equals("") || txtTelefono.Equals("") || txtLimiteCredito.Equals(""))
            {
                MessageBox.Show("EXISTEN CAMPOS OBLIGATORIOS POR LLENAR");
            } else {
                DO_Cliente nuevoCliente = new DO_Cliente();
                nuevoCliente.nombre = txtNombre.Text.Trim();
                nuevoCliente.estado = "HABILITADO";
                nuevoCliente.primerApellido = txtPriApellido.Text.Trim();
                nuevoCliente.segundoApellido = txtSegApellido.Text.Trim();
                nuevoCliente.direccion = txtDireccion.Text.Trim();
                nuevoCliente.telefono = Convert.ToInt32(txtTelefono.Text.Trim());
                NuevoCliente(nuevoCliente);
            } //seguir aqui
            int limiteCredito = Convert.ToInt32(txtLimiteCredito.Text.Trim());
        }
    }
}
