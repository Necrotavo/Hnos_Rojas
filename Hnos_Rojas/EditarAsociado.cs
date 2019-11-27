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
    public partial class EditarAsociado : Form
    {
        private DO_Asociado asociado;
        public EditarAsociado(int idAsociado)
        {
            InitializeComponent();
            rellenarFormulario(idAsociado);
        }

        private void rellenarFormulario(int idAsociado)
        {
            BL_Asociado blAsociado = new BL_Asociado();
            asociado = blAsociado.buscarAsociado(idAsociado);
            txtNombre.Text = asociado.perNombre;
            txt1erApellido.Text = asociado.perPrimerApellido;
            txt2doApellido.Text = asociado.perSegundoApellido;
            txtTelefono.Text = asociado.perTelefono;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //llamar al modificar de blAsociado
            if (validarEspaciosVacios())
            {
                BL_Asociado blAsociado = new BL_Asociado();
                asociado.perNombre = txtNombre.Text.Trim();
                asociado.perPrimerApellido = txt1erApellido.Text.Trim();
                asociado.perSegundoApellido = txt2doApellido.Text.Trim();
                asociado.perTelefono = txtTelefono.Text.Trim();
                if (blAsociado.editarAsociado(asociado))
                {
                    MessageBox.Show("Cambios guardados");
                }
                else {
                    MessageBox.Show("No se pudo modificar el asociado");
                }
            }
            else {
                MessageBox.Show("Por favor rellene todos espacios!");
            }
        }

        private bool validarEspaciosVacios() {
            if (txtNombre.Text.Trim().Equals("") || txt1erApellido.Text.Trim().Equals("") || txt2doApellido.Text.Trim().Equals("")
                || txtTelefono.Text.Trim().Equals("")) {
                return false;
            }
            return true;
        }
    }
}
