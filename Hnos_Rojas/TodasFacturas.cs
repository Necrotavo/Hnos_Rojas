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
            tablaFacturas.Columns.Add("IdCliente");
            tablaFacturas.Columns.Add("Saldo");
            foreach (DO_Factura doFactura in listaFactura) {
                if (doFactura.tipoPago.Equals("CREDITO"))
                {
                    if (!doFactura.credito.Equals(0))
                    {
                        DO_Cliente cliente = blCliente.buscarCliente(doFactura.credito);
                        tablaFacturas.Rows.Add(doFactura.codigoFactura, doFactura.fecha, doFactura.usuario,
                       cliente.perNombre + " " + cliente.perPrimerApellido + " " + cliente.perSegundoApellido,
                       doFactura.estado, doFactura.totalFactura, "",doFactura.tipoPago,doFactura.credito,doFactura.saldo);
                    }
                }
                else {
                    tablaFacturas.Rows.Add(doFactura.codigoFactura, doFactura.fecha, doFactura.usuario,
                      doFactura.clienteExterno, doFactura.estado, doFactura.totalFactura, doFactura.notas,doFactura.tipoPago,"","");
                }
            }
            grdFacturas.DataSource = tablaFacturas;
            grdFacturas.AllowUserToAddRows = false;
           
        }

        public void formatoGrid()
        {
           
            grdFacturas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            grdFacturas.Columns["Codigo"].Width = 50;    //codigo
            grdFacturas.Columns["Fecha"].Width = 200;    //Fecha
            grdFacturas.Columns["Usuario"].Width = 100;    //Usuario
            grdFacturas.Columns["ClienteNombre"].Width = 150;    //Cliente
            grdFacturas.Columns["Estado"].Width = 70;    //Estado
            grdFacturas.Columns["Monto"].Width = 50;     //Monto
            grdFacturas.Columns["Notas"].Width = 50;     //Saldo
            grdFacturas.Columns["IdCliente"].Width = 50;     //Saldo
            grdFacturas.Columns["Tipo"].Width = 50;  //Abonar
            grdFacturas.Columns["Saldo"].Width = 50;  //Abonar
            grdFacturas.Columns["Imprimir"].Width = 20; //imprimir
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
                
                //sacando datos del grid
                BL_Factura blFactura = new BL_Factura();
                factura.codigoFactura = Convert.ToInt32(grdFacturas.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                factura.fecha = Convert.ToDateTime(grdFacturas.Rows[e.RowIndex].Cells["Fecha"].Value.ToString());
                factura.usuario = grdFacturas.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                factura.clienteExterno = grdFacturas.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                factura.estado = grdFacturas.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                factura.totalFactura = Convert.ToInt32(grdFacturas.Rows[e.RowIndex].Cells["Monto"].Value.ToString());
                factura.notas = grdFacturas.Rows[e.RowIndex].Cells["Notas"].Value.ToString();
                factura.tipoPago = grdFacturas.Rows[e.RowIndex].Cells["TIPO"].Value.ToString();

                factura.listaProducto = blFactura.obtenerProductosFactura(factura.codigoFactura);

                if (factura.tipoPago.Equals("CREDITO"))
                {
                    //imprirmir factura cliente
                    BL_Credito blCredito = new BL_Credito();
                    DO_Credito credito = blCredito.ObtenerDatosCredito(Convert.ToInt32(grdFacturas.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString()));
                    String nombreCliente = grdFacturas.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                    FacturaCredito factCred = new FacturaCredito(
                    factura.usuario,
                    factura.totalFactura.ToString(),
                    credito.monto+"",
                    factura.listaProducto,
                    factura.notas,
                    nombreCliente,
                    factura.saldo+"");
                }
                else {
                    //imprimir factura contado
                   FacturaContado factOpt = new FacturaContado(
                   factura.usuario,
                   factura.totalFactura.ToString(),
                   "********",
                   "********",
                   factura.listaProducto,
                   factura.notas,
                   factura.clienteExterno
                   );
                }
               
                
            }
          
        }

        private void grdFacturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            grdFacturas.Columns["IdCLiente"].Visible = false;
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
