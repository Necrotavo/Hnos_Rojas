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
            aceptar();
        }

        public void aceptar() {
            BL_Usuario blUsuario = new BL_Usuario();

            if (blUsuario.iniciarSesion(cboUsuario.SelectedValue.ToString(), txtContrasena.Text) != null)
            {
                Principal principal = new Principal(this);
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarVentana();
        }

        public void cerrarVentana() {
            this.Close();
        }

        private void llenarCboUsuario() {
            BL_Usuario blUsuario = new BL_Usuario();
            cboUsuario.DataSource = blUsuario.CargarUsuarios();
            cboUsuario.ValueMember = "nombreUsuario";
            cboUsuario.DisplayMember = "nombreUsuario";
          
        }

        private void VentanaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        cerrarVentana();
                        break;
                    }
                case Keys.Enter:
                    {
                        aceptar();
                        break;
                    }
            }
        }
    }
}
