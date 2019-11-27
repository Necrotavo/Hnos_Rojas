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
   
    public partial class Agregar_ModificarProveedor : Form
    {
        private DO_Proveedor proveedor;
        public Agregar_ModificarProveedor()
        {
            lblTitulo.Text = "Nuevo Proveedor";
            InitializeComponent();
            
        }

        public Agregar_ModificarProveedor(String nombreProveedor)
        {
            lblTitulo.Text = "Editar Proveedor";
            txtNombreProveedor.Enabled = false;
            InitializeComponent();
            
        }

        private void rellenarFormulario(String nombreProveedor) {
            BL_Proveedor blProveedor = new BL_Proveedor();
            proveedor = blProveedor.obtenerProveedor(nombreProveedor);

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            txtNombreProveedor.Enabled = true;
        }
    }
}
