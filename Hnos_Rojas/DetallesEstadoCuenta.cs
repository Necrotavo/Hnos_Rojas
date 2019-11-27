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
        private BL_Credito blCredito = new BL_Credito();
        private DO_Cliente cliente;
        public DetallesEstadoCuenta(DO_Cliente _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
            refrescarCreditoCompleto();
            llenarGrid();
            formatoGrid();

        }

        public void refrescarCreditoCompleto() {
            cliente.credito = blCredito.ObtenerCredito(cliente.perIdentificador);
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
                    cliente.perNombre + " " + cliente.perPrimerApellido + " " + cliente.perSegundoApellido,
                    doFactura.estado, doFactura.totalFactura, doFactura.saldo);
            }

            grdFacturas.DataSource = tablaFacturas;

            this.lblMontoCred.Text = cliente.credito.monto.ToString();
        }

        public void formatoGrid() {
            grdFacturas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            grdFacturas.Columns[0].Width = 50;    //codigo
            grdFacturas.Columns[1].Width = 200;    //Fecha
            grdFacturas.Columns[2].Width = 100;    //Usuario
            grdFacturas.Columns[3].Width = 150;    //Cliente
            grdFacturas.Columns[4].Width = 70;    //Estado
            grdFacturas.Columns[5].Width = 50;     //Monto
            grdFacturas.Columns[6].Width = 50;     //Saldo
            grdFacturas.Columns[7].Width = 20;  //Abonar
            grdFacturas.Columns[7].Width = 20; //imprimir
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            EstadoCuentaCliente otropanel = new EstadoCuentaCliente() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Parent.Controls.Add(otropanel);
            otropanel.Show();
            this.Dispose();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desdeFecha = new DateTime(calDesde.SelectionStart.Year, calDesde.SelectionStart.Month, 
                calDesde.SelectionStart.Day);

            DateTime hastaFecha = new DateTime(calHasta.SelectionStart.Year, calHasta.SelectionStart.Month,
                calHasta.SelectionStart.Day);

            BL_Credito blCredito = new BL_Credito();
            this.cliente.credito = blCredito.ObtenerCredito(cliente.perIdentificador, desdeFecha, hastaFecha);

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

                    DO_Factura factura = new DO_Factura();
                    factura.codigoFactura = Convert.ToInt32(fila["Codigo"]);
                    factura.fecha = Convert.ToDateTime(fila["Fecha"]);
                    factura.totalFactura = Convert.ToDouble(fila["Monto"]);
                    factura.saldo = Convert.ToDouble(fila["Saldo"]);
                    factura.credito = cliente.credito.identificador;

                    AbonarFactura abonarFactura = new AbonarFactura(factura, this);
                    abonarFactura.Show();
                }
                else if (grdFacturas.Columns[e.ColumnIndex].Name.Equals("Imprimir"))
                {


                    FacturaDeCliente reimpresion = new FacturaDeCliente(blCredito.obtenerFactura(
                        grdFacturas.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        cliente.credito)); 
                }
                
            }
            catch (Exception)
            {

            }
            finally { }
        }

        private void btnAbonarCredito_Click(object sender, EventArgs e)
        {
            AbonarCredito abonarCredito = new AbonarCredito(cliente, this);
            abonarCredito.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReporteCreditoCliente imprimirReporte = new ReporteCreditoCliente(cliente.credito.listaFactura, lblMontoCred.Text);


        }
    }
}
