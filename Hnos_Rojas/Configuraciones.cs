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
    public partial class Configuraciones : Form
    {
        public Configuraciones()
        {
            InitializeComponent();
        }
        private void restaurarColoresBtns() //Restaura el color default de los botones
        {
            Color color = Color.FromArgb(52, 168, 150);
            btnUsuariosConf.BackColor = color;
            btnPlantilla.BackColor = color;
            
        }
        private void btnUsuariosConf_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UsuarioConfig otropanel = new UsuarioConfig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(otropanel);
            restaurarColoresBtns();
            btnUsuariosConf.BackColor = Color.FromArgb(24, 107, 94);
            otropanel.Show();

        }

        private void btnPlantilla_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            PlantillaConfig otropanel = new PlantillaConfig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(otropanel);
            restaurarColoresBtns();
            btnPlantilla.BackColor = Color.FromArgb(24, 107, 94);
            otropanel.Show();
        }
    }
}
