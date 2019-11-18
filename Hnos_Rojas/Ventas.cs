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
    public partial class Ventas : Form
    {
        List<Tickets> listaTiquetes = new List<Tickets>();
        public Ventas()
        {
            InitializeComponent();
            llenarCboUsuarios();
            String usr = cboUsuarios.SelectedValue.ToString();
            Tickets primer = new Tickets(usr) { TopLevel = false, TopMost = true, Visible = true };
            tabTicket.TabPages[0].Controls.Add(primer);
            listaTiquetes.Add(primer);
            tabTicket.TabPages[0].Text = "Ticket " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabTicket.SelectedTab == tabTicket.TabPages["tabAgregar"])
            {
                string nombreTicket = "Ticket " + DateTime.Now.ToString("hh:mm:ss");
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
            listaTiquetes.RemoveAt(tabTicket.SelectedIndex);
            tabTicket.Controls.Remove(tabTicket.SelectedTab);

            tabTicket.SelectedTab = tabTicket.TabPages[0];
        }
        //Creador de tickes
        private TabPage crearTicket(string titulo)
        {
            TabPage ticket = new TabPage(titulo);
            Tickets diseno = new Tickets(cboUsuarios.SelectedValue.ToString()) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, Visible = true };
            listaTiquetes.Add(diseno);
            ticket.Controls.Add(diseno);

            return ticket;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            agregarProductoCompleto();

        }

        private void agregarProductoCompleto()
        {
            agregarProductoATabla();
            nmCantidad.Value = 1;
            txtCodigo.Clear();
        }

        private void agregarProductoATabla()
        {
            BL_Producto prod = new BL_Producto();
            DO_Producto _DoProd = prod.BuscarProducto(txtCodigo.Text);
            if (_DoProd.codigo != null)
            {
                listaTiquetes.ElementAt<Tickets>(tabTicket.SelectedIndex).agregarProducto(_DoProd, Convert.ToInt32(nmCantidad.Text));
            }
            else
            {
                MessageBox.Show("No existe el producto!");
                return;
            }
        }

        private void llenarCboUsuarios()
        {
            //llamar al bl de usuarios
            BL_Usuario blUsuario = new BL_Usuario();
            cboUsuarios.DataSource = blUsuario.CargarUsuarios();
            cboUsuarios.ValueMember = "nombreUsuario";
            cboUsuarios.DisplayMember = "nombreUsuario";
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Enter:
                    {
                        agregarProductoCompleto();
                        break;
                    }
                case Keys.Up:
                    {
                        if (nmCantidad.Value < nmCantidad.Maximum)
                        {
                            nmCantidad.Value++;
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (nmCantidad.Value > nmCantidad.Minimum)
                        {
                            nmCantidad.Value--;
                        }

                        break;
                    }
                case Keys.F12:
                    {
                        listaTiquetes.ElementAt<Tickets>(tabTicket.SelectedIndex).pagar();
                        break;
                    }
            }

        }

        private void nmCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Enter:
                    {
                        agregarProductoCompleto();
                        break;
                    }
            }
        }
    }
}
