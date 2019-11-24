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

        }
    }
}
