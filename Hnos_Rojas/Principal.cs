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

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ventasEjecucion();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clientesEjecucion();
        }



        //Metodos llamados

        private void restaurarColoresBtns() //Restaura el color default de los botones
        {
            Color color = Color.FromArgb(52, 168, 150);
            btnClientes.BackColor = color;
            btnConfiguracion.BackColor = color;
            btnInventario.BackColor = color;
            btnProductos.BackColor = color;
            btnReportes.BackColor = color;
            btnVentas.BackColor = color;
        }
        private void ventasEjecucion() //evento q se llama al hacer click en el boton o en F1
        {
            pnlCenter.Controls.Clear();
            Ventas otropanel = new Ventas() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlCenter.Controls.Add(otropanel);
            otropanel.Show();
            restaurarColoresBtns();
            btnVentas.BackColor = Color.FromArgb(24, 107, 94);
        }

        private void clientesEjecucion() //evento q se llama al hacer click en el boton o en F2
        {
            pnlCenter.Controls.Clear();
            Clientes otropanel = new Clientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlCenter.Controls.Add(otropanel);
            otropanel.Show();
            restaurarColoresBtns();
            btnClientes.BackColor = Color.FromArgb(24, 107, 94);
        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    {
                        ventasEjecucion();
                        break;
                    }
                case Keys.F2:
                    {
                        clientesEjecucion();
                        break;
                    }
            }
        }

    }
}
