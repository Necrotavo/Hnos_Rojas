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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            tabControl1.TabPages[0].Controls.Add(new Tickets() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabAgregar"])
            {
                string nombreTicket = "Ticket " + tabControl1.TabPages.Count;
                TabPage tp = crearTicket(nombreTicket);
                tabControl1.TabPages.Insert(tabControl1.TabPages.Count - 1, tp);
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 2];
            }
        }

        //Creador de tickes
        private TabPage crearTicket(string titulo)
        {
            TabPage ticket = new TabPage(titulo);
            ticket.BackColor = Color.Aqua;
            Tickets diseno = new Tickets() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
            ticket.Controls.Add(diseno);

            return ticket;
        }
    }
}
