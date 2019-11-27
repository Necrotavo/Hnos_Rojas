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
        Proveedor padre;
        private DO_Proveedor proveedor;
        public Agregar_ModificarProveedor(Proveedor _padre)
        {
            InitializeComponent();
            padre = _padre;
            lblTitulo.Text = "Nuevo Proveedor";

        }

        public Agregar_ModificarProveedor(String nombreProveedor, Proveedor _padre)
        {
            InitializeComponent();
            padre = _padre;
            lblTitulo.Text = "Editar Proveedor";
            txtNombreProveedor.Enabled = false;
            rellenarFormulario(nombreProveedor);
        }

        private void rellenarFormulario(String nombreProveedor) {
            BL_Proveedor blProveedor = new BL_Proveedor();
            proveedor = blProveedor.obtenerProveedor(nombreProveedor);
            txtNombreProveedor.Text = proveedor.nombre;
            txtFechaVisita.Text = proveedor.fechaVisita;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            BL_Proveedor blProveedor = new BL_Proveedor();
            if (proveedor != null)
            {
                // modificar
                if (validarFormulario())
                {
                    proveedor.fechaVisita = txtFechaVisita.Text.Trim();
                    if (blProveedor.modificarProveedor(proveedor))
                    {
                        MessageBox.Show("Proveedor modificado");
                    }
                    else {
                        MessageBox.Show("error al modificar datos del proveedor");
                    }
                    txtNombreProveedor.Enabled = true;

                }
            }
            else {
                // agregar
               
                if (validarFormulario()) {
                    DO_Proveedor proveedor = new DO_Proveedor();
                    proveedor.nombre = txtNombreProveedor.Text.Trim();
                    proveedor.fechaVisita = txtFechaVisita.Text.Trim();
                    if (blProveedor.ingresarProveedor(proveedor))
                    {
                        MessageBox.Show("Proveedor ingresado");
                        limpiarFormulario();
                    }
                    else {
                        MessageBox.Show("error al ingresar el proveedor");
                    }
                }

            }
        }

        private bool validarFormulario() {
            if (txtNombreProveedor.Text.Trim().Equals("") || txtFechaVisita.Text.Trim().Equals("")) {
                return false;
            }
            return true;
        }

        private void limpiarFormulario() {
            txtNombreProveedor.Clear();
            txtFechaVisita.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            padre.invocarListaProveedores();
        }
    }
}
