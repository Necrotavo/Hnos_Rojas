using BL;
using DO;
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
    public partial class ListaAsociados : Form
    {
        Proveedor abuelo;
        String proveedor;
        public ListaAsociados(String _proveedor, Proveedor _abuelo)
        {
            InitializeComponent();
            abuelo = _abuelo;
            proveedor = _proveedor;
            lblTitulo.Text = lblTitulo.Text + _proveedor;
            proveedor = _proveedor;
            llenarListBox();
            grdAsociados.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void llenarListBox()
        {
            BL_Asociado blAsociado = new BL_Asociado();

            List<DO_Asociado> listaProveedores = blAsociado.obtenerListaAsociados(proveedor);

            DataTable tablaAsociados = new DataTable();
            tablaAsociados.Columns.Add("Identificador");
            tablaAsociados.Columns.Add("Nombre");
            tablaAsociados.Columns.Add("Telefono");
            if (listaProveedores != null)
            {
                foreach (DO_Asociado doAsociado in listaProveedores)
                {
                    tablaAsociados.Rows.Add(doAsociado.perIdentificador,
                        doAsociado.perNombre + " " + doAsociado.perPrimerApellido + " " + doAsociado.perSegundoApellido,
                        doAsociado.perTelefono);
                }
            }

            this.grdAsociados.DataSource = tablaAsociados;
        }

        private void btnAddAsociado_Click(object sender, EventArgs e)
        {
            invocarAgregarAsociado();
        }
        public void invocarAgregarAsociado()
        {
            //MostrarFormulario de agregar asociado
            AgregarAsociado agregarAsociado = new AgregarAsociado(proveedor, abuelo) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Parent.Controls.Add(agregarAsociado);
            this.Hide();
            agregarAsociado.Show();
        }

        private void grdAsociados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = (DataTable)grdAsociados.DataSource;
            if (grdAsociados.Columns[e.ColumnIndex].Name.Equals("Editar"))
            {
                BL_Asociado blAsociado = new BL_Asociado();
                DataRow fila = dataTable.Rows[e.RowIndex];
                int id = Convert.ToInt32(fila[0]);

                EditarAsociado editarAsociado = new EditarAsociado(id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Parent.Controls.Add(editarAsociado);
                this.Dispose();
                editarAsociado.Show();
            }
            else {
                if (grdAsociados.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                {
                    BL_Asociado blAsociado = new BL_Asociado();
                    DataRow fila = dataTable.Rows[e.RowIndex];
                    int id = Convert.ToInt32(fila[0]);
                    if (blAsociado.eliminarAsociado(id))
                    {
                        llenarListBox();
                    }
                    else
                    {
                        MessageBox.Show("el asociado no se eliminó");
                    }

                }
            }     
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            abuelo.invocarListaProveedores();
        }
    }
}
