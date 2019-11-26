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
        }

        private void llenarListBox()
        {
            BL_Proveedor blProveedor = new BL_Proveedor();

            List<DO_Proveedor> listaClientes = blProveedor.obtenerListaProveedores();

            //DataTable tablaClientes = new DataTable();
            //tablaClientes.Columns.Add("id");
            //tablaClientes.Columns.Add("nombre");
            //if (listaClientes != null)
            //{
            //    foreach (DO_Cliente doCliente in listaClientes)
            //    {
            //        tablaClientes.Rows.Add(doCliente.perIdentificador, doCliente.perNombre + " "
            //            + doCliente.perPrimerApellido + " " + doCliente.perSegundoApellido);
            //    }
            //}


            //listBClientes.DataSource = tablaClientes;
            //listBClientes.DisplayMember = "nombre";
            //listBClientes.ValueMember = "id";

            //listBClientes.SelectedItem = 0;
        }
    }
}
