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
    public partial class Principal : Form
    {
        Form padre;
        public Principal(Form pariente)
        {
            padre = pariente;
            InitializeComponent();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            padre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test otropanel = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } ;
            pnlCenter.Controls.Add(otropanel);
            otropanel.Show();
        }
    }
}
