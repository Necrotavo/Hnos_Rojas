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
    public partial class Agregar_EditarCliente : Form
    {
        private bool modificando = false;
        public Agregar_EditarCliente()
        {
            InitializeComponent();
            llenarGridClientes();
            esconderElementos(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DO_Cliente do_Cliente = new DO_Cliente();

            do_Cliente.perNombre = tbNombre.Text.Trim();
            do_Cliente.perPrimerApellido = tbPrimerApellido.Text.Trim();
            do_Cliente.perSegundoApellido = tbSegundoApellido.Text.Trim();
            do_Cliente.direccion = tbDireccion.Text.Trim();
            do_Cliente.perTelefono = tbTelefono.Text.Trim();
            int identificadorPersona = AgregarPersona(do_Cliente);
            do_Cliente.estado = "HABILITADO";
            do_Cliente.perIdentificador = identificadorPersona;

            if (AgregarCliente(do_Cliente))
            {
                AgregarCredito(identificadorPersona,Convert.ToInt32(tbLimite.Text.Trim()));
                MessageBox.Show("Cliente agregado correctamente");
                vaciarCampos();
            }
        }

        public int AgregarPersona(DO_Persona nuevaPersona)
        {
            BL_Persona blPersona = new BL_Persona();

            return blPersona.registrarPersona(nuevaPersona);
        }

        public bool AgregarCliente(DO_Cliente nuevoCliente)
        {
            BL_Cliente blCliente = new BL_Cliente();

            return blCliente.registrarClienteCrediticio(nuevoCliente);
        }
        public bool AgregarCredito(int identificadorCliente, int limiteCredito)
        {
            BL_Credito blCredito = new BL_Credito();

            return blCredito.CrearCredito(identificadorCliente,limiteCredito);
        }
        public void vaciarCampos()
        {
            tbNombre.Text = "";
            tbPrimerApellido.Text = "";
            tbSegundoApellido.Text = "";
            tbDireccion.Text = "";
            tbTelefono.Text = "";
            tbLimite.Text = "";
            tbEstado.Text = "";
        }

        private void tabPageModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí");
          
            vaciarCampos();
            esconderElementos(true);
        }

        private void llenarGridClientes()
        {
            BL_Cliente blCliente = new BL_Cliente();
            dgvClientes.DataSource = blCliente.obtenerListaClientesHabilitados(false,"");
            
            dgvClientes.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Microsoft Sans Serif", 14);
            style.BackColor = Color.LightGray;


            //grdClientes [1] = direccion
            //grdClientes [2] = estado
            //grdClientes [3] = credito
            //grdClientes [4] = identificador
            //grdClientes [5] = telefono
            //grdClientes [6] = nombre
            //grdClientes [7] = primerApellido
            //grdClientes [8] = segundoApellido

            //grdProductos.Columns[0].HeaderCell.Style = style;
            //dgvClientes.Columns[0].Visible = true;    //Estado

            //grdProductos.Columns[1].HeaderCell.Style = style;
            //dgvClientes.Columns[1].Visible = true;    //nombre

            //grdProductos.Columns[2].HeaderCell.Style = style;
            //dgvClientes.Columns[2].Visible = false;    //credito

            // grdProductos.Columns[3].HeaderCell.Style = style;
            //dgvClientes.Columns[3].Visible = false;    //identificador

            ////grdProductos.Columns[4].HeaderCell.Style = style;
            //dgvClientes.Columns[4].Visible = false;    //descripcion


            //dgvClientes.Columns[5].Visible = false;    //catDisponible

            dgvClientes.AutoSize = true;

            

        }
        private void Agregar_EditarCliente_Load(object sender, EventArgs e)
        {
            AlternarColores(dgvClientes);
            //destacarClientesInactivos(dgvClientes);
        }

        public void AlternarColores(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            
            
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "EstadoCliente") {
                if (e.Value.ToString() == "DESHABILITADO") {
                   // e.CellStyle.BackColor = Color.Red;
                    dgvClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["NombreCliente"].Value.ToString();
            tbPrimerApellido.Text = dgvClientes.Rows[e.RowIndex].Cells["ApellidoCliente"].Value.ToString();
            tbSegundoApellido.Text = dgvClientes.Rows[e.RowIndex].Cells["SegundoApellidoCliente"].Value.ToString();
            tbDireccion.Text = dgvClientes.Rows[e.RowIndex].Cells["DireccionCliente"].Value.ToString();
            tbTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells["TelefonoCliente"].Value.ToString();
            tbSegundoApellido.Text = dgvClientes.Rows[e.RowIndex].Cells["SegundoApellidoCliente"].Value.ToString();
            tbEstado.Text = dgvClientes.Rows[e.RowIndex].Cells["EstadoCliente"].Value.ToString();
            modificarClientes();
        }

        private void modificarClientes()
        {
            modificando = true;
            esconderElementos(false);
            verificarColorEstado();
            tabControlClientes.SelectedTab = tabPageAgregarCliente;
        }

        public void esconderElementos(bool esconder)
        {
            if (esconder)
            {
                tbEstado.Visible = false;
                btCambiarEstado.Visible = false;
                lblEstado.Visible = false;
            }
            else
            {
                tbEstado.Visible = true;
                btCambiarEstado.Visible = true;
                lblEstado.Visible = true;

                verificarColorEstado();
            }
        }

        private void tabPageAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void tabControlClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlClientes.SelectedTab == tabPageModificar)
            {
                modificando = false;
                vaciarCampos();
                esconderElementos(true);
            }
        }

        private void btCambiarEstado_Click(object sender, EventArgs e)
        {
            verificarColorEstado();
        }

        public void verificarColorEstado()
        {
            if (tbEstado.Text == "DESHABILITADO")
            {
                tbEstado.Text = "HABILITADO";
                tbEstado.BackColor = Color.LightGreen;
            }
            else
            {
                tbEstado.Text = "DESHABILITADO";
                tbEstado.BackColor = Color.Red;

            }
        }
    }
}
