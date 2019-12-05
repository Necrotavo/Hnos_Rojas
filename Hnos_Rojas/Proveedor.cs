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
    public partial class Proveedor : Form, IConfirmacion
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
            btnEliminar.Enabled = true;
            btnModificarProv.Enabled = true;
            btnAsociados.Enabled = true;
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificarProv.Enabled = false;
            btnAsociados.Enabled = false;
            this.panelProveedores.Controls.Clear();
            Agregar_ModificarProveedor agregar_ModificarProveedor = new Agregar_ModificarProveedor(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelProveedores.Controls.Add(agregar_ModificarProveedor);
            agregar_ModificarProveedor.Show();
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificarProv.Enabled = false;
            btnAsociados.Enabled = false;
            this.panelProveedores.Controls.Clear();
            Agregar_ModificarProveedor agregar_ModificarProveedor = new Agregar_ModificarProveedor(tempListaproveedores.obtenerProveedorSeleccionado(), this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelProveedores.Controls.Add(agregar_ModificarProveedor);
            agregar_ModificarProveedor.Show();
        }

        public void invocarListaAsociados(string nombreProveedor)
        {
            btnEliminar.Enabled = false;
            btnModificarProv.Enabled = false;
            btnAsociados.Enabled = false;
            this.panelProveedores.Controls.Clear();
            ListaAsociados listaAsociados = new ListaAsociados(nombreProveedor, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelProveedores.Controls.Add(listaAsociados);
            listaAsociados.Show();

        }

        private void btnAsociados_Click(object sender, EventArgs e)
        {
            invocarListaAsociados(tempListaproveedores.obtenerProveedorSeleccionado());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MensajeConfirmacion mensajeConfirmacion = new MensajeConfirmacion("Seguro que desea eliminar este proveedor?", this);
            mensajeConfirmacion.Show();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificarProv.Enabled = false;
            btnAsociados.Enabled = false;
            HorarioProveedores horarioProveedores = new HorarioProveedores(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelProveedores.Controls.Clear();
            this.panelProveedores.Controls.Add(horarioProveedores);
            horarioProveedores.Show();
        }

        public void positivo()
        {
            
            BL_Proveedor blProveedor = new BL_Proveedor();
            if (blProveedor.eliminarProveedor(tempListaproveedores.obtenerProveedorSeleccionado()))
            {
                MensajeExito mensajeExito = new MensajeExito("PROVEEDOR ELIMINADO");
                invocarListaProveedores();
                mensajeExito.Show();
                //MessageBox.Show("Proveedor eliminado");
            }
            else
            {
                MensajeError mensajeError = new MensajeError("PROVEEDOR NO ELIMINADO");
                invocarListaProveedores();
                mensajeError.Show();
                //MessageBox.Show("Proveedor no eliminado");
            }
            
        }

        public void negativo()
        {
          
        }
    }
}
