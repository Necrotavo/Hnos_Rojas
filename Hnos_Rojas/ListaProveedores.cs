using BL;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hnos_Rojas
{
    public partial class ListaProveedores : Form
    {
        public ListaProveedores()
        {
            InitializeComponent();
            llenarListBox();
            this.ActiveControl = txtNombreProveedor;
        }

        private void llenarListBox()
        {
            BL_Proveedor blProveedor = new BL_Proveedor();

            List<DO_Proveedor> listaProveedores = blProveedor.obtenerListaProveedores(this.txtNombreProveedor.Text.Trim());

            DataTable tablaClientes = new DataTable();
            tablaClientes.Columns.Add("nombre");
            if (listaProveedores != null)
            {
                foreach (DO_Proveedor doProveedor in listaProveedores)
                {
                    tablaClientes.Rows.Add(doProveedor.nombre);
                }
            }

            this.listBoxProveedores.DataSource = tablaClientes;
            this.listBoxProveedores.DisplayMember = "nombre";
            this.listBoxProveedores.ValueMember = "nombre";

            this.listBoxProveedores.SelectedItem = 0;
        }

        private void listBoxProveedores_Click(object sender, EventArgs e)
        {
            ListaAsociados listaAsociados = new ListaAsociados(listBoxProveedores.SelectedValue.ToString());
            listaAsociados.Show();
        }

        private void txtNombreProveedor_TextChanged(object sender, EventArgs e)
        {
            llenarListBox();
        }
    }
}
