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

namespace Hnos_Rojas
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            estadoCuentaCliente();

        }

        public void estadoCuentaCliente() {
            panelClientes.Controls.Clear();
            EstadoCuentaCliente otropanel = new EstadoCuentaCliente() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelClientes.Controls.Add(otropanel);
            otropanel.Show();
        }

        public void nuevoCliente() {
            panelClientes.Controls.Clear();
            ClienteNuevo otropanel = new ClienteNuevo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelClientes.Controls.Add(otropanel);
            otropanel.Show();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Agregar_EditarCliente agregar_Editar = new Agregar_EditarCliente();
            agregar_Editar.StartPosition = FormStartPosition.CenterScreen;
            agregar_Editar.Show();
            
        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            estadoCuentaCliente();
        }


        private void Clientes_Load(object sender, EventArgs e)
        {
            estadoCuentaCliente();
        }
    }
}
