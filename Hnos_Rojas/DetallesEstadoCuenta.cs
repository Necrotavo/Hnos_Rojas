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
    public partial class DetallesEstadoCuenta : Form
    {
        private DO_Cliente cliente;
        public DetallesEstadoCuenta(DO_Cliente _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
            BL_Credito blCredito = new BL_Credito();
            cliente.credito = blCredito.ObtenerCredito(cliente.id);
            llenarGrid();
            formatoGrid();

        }

        public void llenarGrid() {
            DataTable tablaFacturas = new DataTable();
            tablaFacturas.Columns.Add("Codigo");
            tablaFacturas.Columns.Add("Fecha");
            tablaFacturas.Columns.Add("Usuario");
            tablaFacturas.Columns.Add("ClienteNombre");
            tablaFacturas.Columns.Add("Estado");
            tablaFacturas.Columns.Add("Monto");
            tablaFacturas.Columns.Add("Saldo");

            foreach (DO_Factura doFactura in cliente.credito.listaFactura) {
                tablaFacturas.Rows.Add(doFactura.codigoFactura, doFactura.fecha, doFactura.usuario,
                    cliente.nombre + " " + cliente.primerApellido + " " + cliente.segundoApellido,
                    doFactura.estado, doFactura.totalFactura, doFactura.saldo);
            }

            grdFacturas.DataSource = tablaFacturas;

            this.lblMontoCred.Text = cliente.credito.monto.ToString();
        }

        public void formatoGrid() {
            grdFacturas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            grdFacturas.Columns[0].Width = 154;    //codigo
            grdFacturas.Columns[1].Width = 200;    //Fecha
            grdFacturas.Columns[2].Width = 100;    //Usuario
            grdFacturas.Columns[3].Width = 170;    //Cliente
            grdFacturas.Columns[4].Width = 100;    //Estado
            grdFacturas.Columns[5].Width = 75;    //Monto
            grdFacturas.Columns[6].Width = 75;    //Saldo
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desdeFecha = new DateTime(calDesde.SelectionStart.Year, calDesde.SelectionStart.Month, 
                calDesde.SelectionStart.Day, 0, 0, 0);

            DateTime hastaFecha = new DateTime(calHasta.SelectionStart.Year, calHasta.SelectionStart.Month,
                calHasta.SelectionStart.Day, 23, 59, 59);

            BL_Credito blCredito = new BL_Credito();
            cliente.credito = blCredito.ObtenerCredito(cliente.id, desdeFecha, hastaFecha);

            llenarGrid();
            formatoGrid();
        }

        private void grdFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = (DataTable)grdFacturas.DataSource;
            try
            {
                if (grdFacturas.Columns[e.ColumnIndex].Name.Equals("Abonar"))
                {
                    DataRow fila = dataTable.Rows[e.RowIndex];
                    dataTable.Rows.Remove(fila);
                    grdFacturas.DataSource = dataTable;
                    // filaSeleccionada = -1;
                }
            }
            catch (Exception)
            {

            }
            finally { }
        }
    }
}
