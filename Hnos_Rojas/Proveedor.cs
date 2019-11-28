using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO;
using BL;

namespace Hnos_Rojas
{
    public partial class Proveedor : Form
    {
        private ListaProveedores tempListaproveedores;
        public Proveedor()
        {
            InitializeComponent();
            invocarListaProveedores();
        }
        

        public void invocarListaProveedores()
        {
            this.panelProveedores.Controls.Clear();
            ListaProveedores listaProveedores = new ListaProveedores(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            tempListaproveedores = listaProveedores;
            this.panelProveedores.Controls.Add(listaProveedores);
            listaProveedores.Show();
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            this.panelProveedores.Controls.Clear();
            Agregar_ModificarProveedor agregar_ModificarProveedor = new Agregar_ModificarProveedor(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelProveedores.Controls.Add(agregar_ModificarProveedor);
            agregar_ModificarProveedor.Show();
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            this.panelProveedores.Controls.Clear();
            Agregar_ModificarProveedor agregar_ModificarProveedor = new Agregar_ModificarProveedor(tempListaproveedores.obtenerProveedorSeleccionado(), this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelProveedores.Controls.Add(agregar_ModificarProveedor);
            agregar_ModificarProveedor.Show();
        }

        private void btnAsociados_Click(object sender, EventArgs e)
        {
            this.panelProveedores.Controls.Clear();
            ListaAsociados listaAsociados = new ListaAsociados(tempListaproveedores.obtenerProveedorSeleccionado(), this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelProveedores.Controls.Add(listaAsociados);
            listaAsociados.Show();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar al proveedor " + tempListaproveedores.obtenerProveedorSeleccionado() + "?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                BL_Proveedor blProveedor = new BL_Proveedor();
                if (blProveedor.eliminarProveedor(tempListaproveedores.obtenerProveedorSeleccionado()))
                {
                    MessageBox.Show("Proveedor eliminado");
                }
                else
                {
                    MessageBox.Show("Proveedor no eliminado");
                }
                invocarListaProveedores();
            }
            else if (result == DialogResult.No)
            {
                //Que no haga nada
            }
            else
            {
                MessageBox.Show("No ha seleccionado un proveedor");
            }
        }
    }
}
