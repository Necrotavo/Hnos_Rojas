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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
            invocarListaProveedores();
        }
        

        public void invocarListaProveedores()
        {
            this.panelProveedores.Controls.Clear();
            ListaProveedores listaProveedores = new ListaProveedores() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelProveedores.Controls.Add(listaProveedores);
            listaProveedores.Show();
        }
    }
}
