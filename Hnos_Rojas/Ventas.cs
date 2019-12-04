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
        private int usuario;
        public bool facturaImpresa;
        public bool facturaContadoRealizada = false;
        public bool facturaCreditoRealizada = false;
        public FacturaContado facturaContadoTemp;
        public FacturaCredito facturaCreditoTemp;
        public Ventas(int _usuario)
        {
            InitializeComponent();
            usuario = _usuario;
            llenarCboUsuarios();
            String usr = cboUsuarios.SelectedValue.ToString();
            Tickets primer = new Tickets(usr, this) { TopLevel = false, TopMost = true, Visible = true };
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
                TabPage tp = crearTicket(nombreTicket, this);
                tabTicket.TabPages.Insert(tabTicket.TabPages.Count - 1, tp);
                tabTicket.SelectedTab = tabTicket.TabPages[tabTicket.TabPages.Count - 2];
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cerrarTicket();
        }

        public void cerrarTicket()
        {
            listaTiquetes.RemoveAt(tabTicket.SelectedIndex);
            tabTicket.Controls.Remove(tabTicket.SelectedTab);

            tabTicket.SelectedTab = tabTicket.TabPages[0];
        }
        //Creador de tickes
        private TabPage crearTicket(string titulo, Ventas parent)
        {
            TabPage ticket = new TabPage(titulo);
            Tickets diseno = new Tickets(cboUsuarios.SelectedValue.ToString(), this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, Visible = true };
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

        public void agregarProductoATabla(DO_Producto producto)
        {

                listaTiquetes.ElementAt<Tickets>(tabTicket.SelectedIndex).agregarProducto(producto, Convert.ToInt32(nmCantidad.Text));

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
                MensajeError mensajeError = new MensajeError("NO EXISTE EL PRODUCTO!");
                mensajeError.Show();
                //MessageBox.Show("No existe el producto!");
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
            cboUsuarios.SelectedIndex = usuario;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Control)
            {
                articuloComun();
            }

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
                case Keys.F10:
                    {
                        invocarPago();
                        break;
                    }
                case Keys.Insert:
                    {
                        ventanaProductoNuevo();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (facturaContadoRealizada)
            {
                facturaContadoTemp.imprimir();
            }
            if (facturaCreditoRealizada)
            {
                facturaCreditoTemp.imprimir();
            }
            if (!facturaCreditoRealizada && !facturaContadoRealizada)
            {
                //reproducir sonidito
            }
        }

        private void cboUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BL_Usuario blUsuario = new BL_Usuario();

            if (blUsuario.iniciarSesion(cboUsuarios.SelectedValue.ToString(), txtContrasena.Text) != null)
            {
                txtContrasena.Clear();
                foreach (Tickets item in listaTiquetes)
                {
                    item.factura.usuario = cboUsuarios.SelectedValue.ToString();
                }
            }
            else
            {
                cboUsuarios.SelectedItem = cboUsuarios.Items[usuario];
                MensajeError mensajeError = new MensajeError("CREDENCIALES INCORRECTOS");
                mensajeError.Show();
                //MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void articuloComun()
        {
            Productos productos = new Productos(true, this);
            productos.FormBorderStyle = FormBorderStyle.FixedDialog;
            productos.Show();
        }

        private void btnArtComun_Click(object sender, EventArgs e)
        {
            articuloComun();
        }

        private void ventanaProductoNuevo()
        {
            NuevoProducto ventanaProducto = new NuevoProducto();
            ventanaProducto.StartPosition = FormStartPosition.CenterScreen;
            ventanaProducto.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            ventanaProductoNuevo();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            invocarPago();
        }

        public void invocarPago() {
            PagoProveedor pagoProveedor = new PagoProveedor(cboUsuarios.SelectedValue.ToString());
            pagoProveedor.Show();
        }

        private void Ventas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F10:
                    {
                        invocarPago();
                        break;
                    }
            }
        }
    }
}
