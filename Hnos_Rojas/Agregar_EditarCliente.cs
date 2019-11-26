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
        public Agregar_EditarCliente()
        {
            InitializeComponent();
            llenarGridClientes();
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
        }

        private void tabPageModificar_Click(object sender, EventArgs e)
        {
            llenarGridClientes();   
        }

        private void llenarGridClientes()
        {
            BL_Cliente blCliente = new BL_Cliente();
            dgvClientes.DataSource = blCliente.obtenerListaClientesHabilitados(false,"");
            dgvClientes.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            //style.Font = new Font("Microsoft Sans Serif", 14);
            //style.BackColor = Color.LightGray;

            //grdProductos.Columns[0].HeaderCell.Style = style;
            dgvClientes.Columns[0].Visible = true;    //Estado

            //grdProductos.Columns[1].HeaderCell.Style = style;
            dgvClientes.Columns[1].Visible = true;    //nombre

            //grdProductos.Columns[2].HeaderCell.Style = style;
            dgvClientes.Columns[2].Visible = false;    //credito

            // grdProductos.Columns[3].HeaderCell.Style = style;
            dgvClientes.Columns[3].Visible = false;    //identificador

            ////grdProductos.Columns[4].HeaderCell.Style = style;
            dgvClientes.Columns[4].Visible = false;    //descripcion


            //dgvClientes.Columns[5].Visible = false;    //catDisponible

            dgvClientes.AutoSize = true;

            destacarClientesInactivos(dgvClientes);

        }

        public void destacarClientesInactivos(DataGridView dgv)
        {
            
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                
                if (fila.Cells[1].Value.ToString().Equals("DESHABILITADO"))
                {
                    
                    
                    fila.DefaultCellStyle.BackColor = Color.Red;                    
                    
                }
            }
            
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
            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "Estado") {
                if (e.Value.ToString() == "DESHABILITADO") {
                   // e.CellStyle.BackColor = Color.Red;
                    dgvClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
