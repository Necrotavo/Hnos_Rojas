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
    public partial class AgregarAsociado : Form
    {
        private String proveedor;
        Proveedor padre;
        public AgregarAsociado(String _proveedor, Proveedor _padre)
        {
            InitializeComponent();
            padre = _padre;
            lblTitulo.Text = lblTitulo.Text + _proveedor;
            proveedor = _proveedor;
        }

        private void btnAddAsociado_Click(object sender, EventArgs e)
        {
            BL_Asociado blAsociado = new BL_Asociado();
            DO_Asociado asociado = new DO_Asociado();
            asociado.perNombre = txtNombre.Text.Trim();
            asociado.perPrimerApellido = txtP1erApellido.Text.Trim();
            asociado.perSegundoApellido = txt2doApellido.Text.Trim();
            asociado.perTelefono = txtTelefono.Text.Trim();
            asociado.proveedor = proveedor;

            if (blAsociado.AgregarAsociado(asociado))
            {
                MensajeExito mensajeExito = new MensajeExito("ASOCIADO AGREGADO");
                mensajeExito.Show();
                //MessageBox.Show("Asociado agregado");
                limpiarFormulario();
            }
            else {
                MensajeError mensajeError = new MensajeError("EL ASOCIADO NO SE AGREGÓ");
                mensajeError.Show();
                //MessageBox.Show("El asociado no se agregó");
            }

        }

        private void limpiarFormulario() {
            txtNombre.Clear();
            txtP1erApellido.Clear();
            txt2doApellido.Clear();
            txtTelefono.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            padre.invocarListaAsociados(proveedor);
        }
    }
}
