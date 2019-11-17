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
    public partial class VentanaPrincipal : Form
    {
        private String usuarioSeleccionado = "";
        public VentanaPrincipal()
        {
            InitializeComponent();
            llenarCboUsuario();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

   

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //BL_Usuario blUsuario = new BL_Usuario();
            
            Principal principal = new Principal(this);
            principal.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void llenarCboUsuario() {
            BL_Usuario blUsuario = new BL_Usuario();
            cboUsuario.DataSource = blUsuario.CargarUsuarios();
            cboUsuario.ValueMember = "nombreUsuario";
            cboUsuario.DisplayMember = "nombreUsuario";
            usuarioSeleccionado = cboUsuario.SelectedValue.ToString();
        }
    }
}
