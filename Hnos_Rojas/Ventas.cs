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
            tabTicket.TabPages[0].Controls.Add(new Tickets() {TopLevel = false, TopMost = true, Visible = true });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabTicket.SelectedTab == tabTicket.TabPages["tabAgregar"])
            {
                string nombreTicket = "Ticket " + tabTicket.TabPages.Count;
                TabPage tp = crearTicket(nombreTicket);
                tabTicket.TabPages.Insert(tabTicket.TabPages.Count - 1, tp);
                tabTicket.SelectedTab = tabTicket.TabPages[tabTicket.TabPages.Count - 2];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cerrarTicket();
        }

        private void cerrarTicket()
        {
            tabTicket.Controls.Remove(tabTicket.SelectedTab);
            tabTicket.SelectedTab = tabTicket.TabPages[0];
        }
        //Creador de tickes
        private TabPage crearTicket(string titulo)
        {
            TabPage ticket = new TabPage(titulo);
            ticket.BackColor = Color.Aqua;
            Tickets diseno = new Tickets() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true, Visible = true };
            ticket.Controls.Add(diseno);

            return ticket;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


    }
}
