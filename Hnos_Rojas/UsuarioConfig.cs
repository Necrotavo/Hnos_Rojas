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
    public partial class UsuarioConfig : Form
    {

        public UsuarioConfig()
        {
            InitializeComponent();
            filtrarUsuarios();
            
        }

        private void filtrarTipo()
        {
            BL_Usuario blUsuario = new BL_Usuario();
            cboTipos.DataSource = blUsuario.CargarUsuarios();
            cboTipos.ValueMember = "tipo";
            cboTipos.DisplayMember = "tipo";
        }
        private void filtrarUsuarios()
        {
            BL_Usuario blUsuario = new BL_Usuario();
            listBoxUsuarios.DataSource = blUsuario.CargarUsuarios();
            listBoxUsuarios.ValueMember = "nombreUsuario";
            listBoxUsuarios.DisplayMember = "nombreUsuario";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL_Usuario blUsuario = new BL_Usuario();

            if (blUsuario.iniciarSesion(listBoxUsuarios.SelectedValue.ToString(), txtContrasena.Text) != null)
            {
                txtNombreUsuarioCrear.Text = listBoxUsuarios.SelectedValue.ToString();
                txtContrasenaCrear.Text = txtContrasena.Text;
                txtNombreUsuarioCrear.ReadOnly = true;
                tabControlUsuarios.SelectedTab = tabCrearUsuario;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void limpiarForms()
        {
            txtContrasena.Text = "";
            txtContrasenaCrear.Text = "";
            txtNombreUsuarioCrear.Text = "";
            filtrarUsuarios();
            txtNombreUsuarioCrear.ReadOnly = false;
        }

        private void btnUsuariosConf_Click(object sender, EventArgs e)
        {
            BL_Usuario blUsuario = new BL_Usuario();
            if (txtNombreUsuarioCrear.ReadOnly)
            {
                if (blUsuario.actualizarUsuario(txtNombreUsuarioCrear.Text, cboTipos.Text, txtContrasenaCrear.Text))
                {
                    MessageBox.Show("Se cambió la clave con exito");
                }
                else
                {
                    MessageBox.Show("Se produjo un error");
                }
            }
            else
            {

            }
            limpiarForms();
        }
    }
}
