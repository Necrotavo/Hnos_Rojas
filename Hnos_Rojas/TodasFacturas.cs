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
    public partial class TodasFacturas : Form
    {
        private DO_Factura factura;
        public TodasFacturas()
        {
            InitializeComponent();
            DateTime date = new DateTime(DateTime.Now.Year , DateTime.Now.Month,
                DateTime.Now.Day);
            llenarGrdFacturas(new DateTime(1999,10,4), date);
            factura = new   DO_Factura();
        }

        private void llenarGrdFacturas(DateTime inicio, DateTime fin)
        {
            BL_Factura blFactura = new BL_Factura();
            BL_Cliente blCliente = new BL_Cliente();
            DataTable tablaFacturas = new DataTable();
            List<DO_Factura> listaFactura = blFactura.obtenerTodasLasFacturas(inicio, fin);
            tablaFacturas.Columns.Add("Codigo");
            tablaFacturas.Columns.Add("Fecha");
            tablaFacturas.Columns.Add("Usuario");
            tablaFacturas.Columns.Add("ClienteNombre");
            tablaFacturas.Columns.Add("Estado");
            tablaFacturas.Columns.Add("Monto");
            tablaFacturas.Columns.Add("Notas");
            tablaFacturas.Columns.Add("Tipo");
            foreach (DO_Factura doFactura in listaFactura) {
                if (doFactura.tipoPago.Equals("CREDITO"))
                {
                    if (!doFactura.credito.Equals(0))
                    {
                        DO_Cliente cliente = blCliente.buscarCliente(doFactura.credito);
                        tablaFacturas.Rows.Add(doFactura.codigoFactura, doFactura.fecha, doFactura.usuario,
                       cliente.perNombre + " " + cliente.perPrimerApellido + " " + cliente.perSegundoApellido,
                       doFactura.estado, doFactura.totalFactura, "",doFactura.tipoPago);
                    }
                }
                else {
                    tablaFacturas.Rows.Add(doFactura.codigoFactura, doFactura.fecha, doFactura.usuario,
                      doFactura.clienteExterno, doFactura.estado, doFactura.totalFactura, doFactura.notas,doFactura.tipoPago);
                }
            }
            grdFacturas.DataSource = tablaFacturas;
            grdFacturas.AllowUserToAddRows = false;
           
        }

        public void formatoGrid()
        {
            //grdFacturas.Columns["Tipo"].Visible = false;
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
            this.Dispose();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desdeFecha = new DateTime(calDesde.SelectionStart.Year, calDesde.SelectionStart.Month,
                calDesde.SelectionStart.Day);

            DateTime hastaFecha = new DateTime(calHasta.SelectionStart.Year, calHasta.SelectionStart.Month,
                calHasta.SelectionStart.Day);
            llenarGrdFacturas(desdeFecha,hastaFecha);
        }

        private void grdFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)      
        {
           
        }

        private void grdFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdFacturas.Columns[e.ColumnIndex].Name.Equals("Imprimir")) {
                MessageBox.Show("sssss");
                BL_Factura blFactura = new BL_Factura();
                factura.codigoFactura = Convert.ToInt32(grdFacturas.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                factura.usuario = grdFacturas.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                factura.tipoPago = grdFacturas.Rows[e.RowIndex].Cells["TIPO"].Value.ToString();
                factura.listaProducto = blFactura.obtenerProductosFactura(factura.codigoFactura);

                if (factura.tipoPago.Equals("CREDITO"))
                {
                    String nombreCliente = grdFacturas.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                    FacturaCredito factCred = new FacturaCredito(
                    factura.usuario,
                    factura.totalFactura.ToString(),
                    "",
                    factura.listaProducto,
                    factura.notas,
                    nombreCliente,
                    "");
                }
                else {

                }
               
                
            }
          
        }

        private void grdFacturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
                if (grdFacturas.Rows[e.RowIndex].Cells["TIPO"].Value.ToString().Equals("CREDITO"))
                {
                    grdFacturas.Rows[e.RowIndex].Cells["TIPO"].Style.BackColor = Color.LightBlue;
                }
                else {
                    grdFacturas.Rows[e.RowIndex].Cells["TIPO"].Style.BackColor = Color.LightSalmon;
                }
            
        }
    }
}
