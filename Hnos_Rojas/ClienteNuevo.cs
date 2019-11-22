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

        public int NuevaPersona(DO_Persona nuevaPersona) {
            BL_Persona daoPersona = new BL_Persona();
            return daoPersona.registrarPersona(nuevaPersona);
        }

        public void NuevoCliente(DO_Cliente nuevoCliente) {
            BL_Cliente daoCliente = new BL_Cliente();
            daoCliente.registrarClienteCrediticio(nuevoCliente);
        }

        public void vaciarCamposTexto() {
            txtDireccion.Text = "";
            txtLimiteCredito.Text = "";
            txtNombre.Text = "";
            txtPriApellido.Text = "";
            txtSegApellido.Text = "";
            txtTelefono.Text = "";

            MessageBox.Show("CLIENTE AGREGADO EXITÓSAMENTE");
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtPriApellido.Text.Equals("") || txtDireccion.Text.Equals("") || txtTelefono.Text.Equals("") || txtLimiteCredito.Text.Equals(""))
            {
                MessageBox.Show("EXISTEN CAMPOS OBLIGATORIOS POR LLENAR");
            } else {
                DO_Cliente cliente = new DO_Cliente();
                cliente.perTelefono = txtTelefono.Text.Trim();
                cliente.perNombre = txtNombre.Text.Trim();
                cliente.perPrimerApellido = txtPriApellido.Text.Trim();
                cliente.perSegundoApellido = txtSegApellido.Text.Trim();
                cliente.direccion = txtDireccion.Text.Trim();
                cliente.estado = "HABILITADO";
                int identificadorCliente = NuevaPersona(cliente);
                cliente.perIdentificador = identificadorCliente;
                
                NuevoCliente(cliente);

                BL_Credito daoCredito = new BL_Credito();
                daoCredito.CrearCredito(cliente.perIdentificador, Convert.ToInt32(txtLimiteCredito.Text.Trim()));
                vaciarCamposTexto();
            }
            
        }
    }
}
