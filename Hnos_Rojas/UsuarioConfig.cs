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
                if (blUsuario.actualizarUsuario(listBoxUsuarios.SelectedValue.ToString(), txtNuevaContrasena.Text))
                {
                    MensajeExito mensajeExito = new MensajeExito("SE CAMBIÓ LA CLAVE CON ÉXITO");
                    mensajeExito.Show();
                    //MessageBox.Show("Se cambió la clave con exito");
                }
                else
                {
                    MensajeError mensajeError = new MensajeError("SE PRODUJO UN ERROR");
                    mensajeError.Show();
                    //MessageBox.Show("Se produjo un error");
                }
            }
            else
            {
                MensajeError mensajeError = new MensajeError("CREDENCIALES INCORRECTOS");
                mensajeError.Show();
                //MessageBox.Show("Credenciales incorrectas");
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

                if (blUsuario.insertarUsuario(txtNombreUsuarioCrear.Text, txtContrasenaCrear.Text))
                {
                MensajeExito mensajeExito = new MensajeExito("SE AGREGÓ USUARIO CON ÉXITO");
                mensajeExito.Show();
                    //MessageBox.Show("Se agregó nuevo usuario con exito");
                }
                else
                {
                MensajeError mensajeError = new MensajeError("SE PRODUJO UN ERROR");
                mensajeError.Show();
                    //MessageBox.Show("Se produjo un error");
                }
            limpiarForms();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BL_Usuario blUsuario = new BL_Usuario();
            string name = listBoxUsuarios.SelectedValue.ToString();
            if (blUsuario.iniciarSesion(name, txtContrasena.Text) != null)
            {
                if (blUsuario.eliminarUsuario(name))
                {
                    MensajeExito mensajeExito = new MensajeExito("SE ELIMINÓ USUARIO CON ÉXITO A " + name);
                    mensajeExito.Show();
                    //MessageBox.Show("Se eliminó con exito a " + name);
                }
                else
                {
                    MensajeError mensajeError = new MensajeError("SE PRODUJO UN ERROR");
                    mensajeError.Show();
                    //MessageBox.Show("Se produjo un error");
                }


            }
            else
            {
                MensajeError mensajeError = new MensajeError("CREDECIALES INCORRECTOS");
                mensajeError.Show();
                //MessageBox.Show("Credenciales incorrectas");
            }
            

            limpiarForms();
        }
    }
}
