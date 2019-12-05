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
    public partial class Reportes : Form
    {
        bool filtrado = false;
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaReporteDesde = new DateTime(calReporteDesde.SelectionStart.Year, calReporteDesde.SelectionStart.Month,
                calReporteDesde.SelectionStart.Day);

            DateTime fechaReporteHasta = new DateTime(calReporteHasta.SelectionStart.Year, calReporteHasta.SelectionStart.Month,
                calReporteHasta.SelectionStart.Day);

            this.lblTitulo.Text = "Reporte del "+ fechaReporteDesde.Day + "/"+ fechaReporteDesde.Month+"/"+ fechaReporteDesde.Year+
                " Hasta el "+ fechaReporteHasta.Day + "/" + fechaReporteHasta.Month + "/" + fechaReporteHasta.Year;

            this.lblCorte.Text = "Corte del " + fechaReporteDesde.Day + "/" + fechaReporteDesde.Month + "/" + fechaReporteDesde.Year;
            this.lblHasta.Text = "Hasta el " + fechaReporteHasta.Day + "/" + fechaReporteHasta.Month + "/" + fechaReporteHasta.Year;

            String inicio = "" + fechaReporteDesde.Year + "-" + fechaReporteDesde.Month + "-" + fechaReporteDesde.Day + " 0:00:00";
            String final = "" + fechaReporteHasta.Year + "-" + fechaReporteHasta.Month + "-" + fechaReporteHasta.Day + " 23:59:59";

            lbFechaReporte.Text = "" + fechaReporteDesde.Day + "/" + fechaReporteDesde.Month + "/" + fechaReporteDesde.Year;

            //La parte de Ventas
            BL_Factura blFactura = new BL_Factura();
            BL_Pago blPago = new BL_Pago();

            int totalVentasEfectivo = blFactura.obtenerTotalVentasEfectivoDiaEspecifico(inicio, final);
            lbEnEfectivoVentas.Text = "₡" + totalVentasEfectivo;

            int totalVentasCredito = blFactura.obtenerTotalVentasCreditoDiaEspecifico(inicio, final);
            lbACreditoVentas.Text = "₡" + totalVentasCredito;

            int totalVentas = totalVentasEfectivo + totalVentasCredito;
            lbTotalVentas.Text = "₡" + totalVentas;

            //La parte de Entradas
            lbEfectivoEntradas.Text = "₡" + blFactura.obtenerTotalVentasEfectivoDiaEspecifico(inicio, final);

            int totalAbonosCredito = blFactura.obtenerAbonosCredito(inicio, final);
            lbCreditoEntradas.Text = "₡" + totalAbonosCredito;

            //La parte de proveedores
            int totalPagoProve = blPago.obtenerPagoProvDiaEspecifico(inicio, final);
            lbTotalAgentes.Text = "₡" + totalPagoProve;

            //La parte de productos más vendidos
            BL_Producto blProductos = new BL_Producto();
            List<DO_TopProductos> topVentas = blProductos.obtenerTopVentas(inicio, final);
            asignarLabelsTopVentas(topVentas.Count, topVentas);

            //Lo de Caja
            lbTotalCaja.Text = "₡ " + (totalVentasEfectivo + totalAbonosCredito - totalPagoProve);
            filtrado = true;
        }

        public void asignarLabelsTopVentas(int tamañoTop, List<DO_TopProductos> topVentas)
        {
            if(tamañoTop == 0)
            {
                lbProd1.Text = "";
                lbCantProd1.Text = "";

                lbProd2.Text = "";
                lbCantProd2.Text = "";

                lbProd3.Text = "";
                lbCantProd3.Text = "";

                lbProd4.Text = "";
                lbCantProd4.Text = "";

                lbProd5.Text = "";
                lbCantProd5.Text = "";
            }
            for (int i = 0; i < tamañoTop; i++)
            {
                if (i == 0)
                {
                    lblTop1.Text = "#1";
                    lbProd1.Text = topVentas[0].nombreProducto;
                    lbCantProd1.Text = "" + topVentas[0].cantidad;
                }
                if (i == 1)
                {
                    lblTop2.Text = "#2";
                    lbProd2.Text = topVentas[1].nombreProducto;
                    lbCantProd2.Text = "" + topVentas[1].cantidad;
                }
                if (i == 2)
                {
                    lblTop3.Text = "#3";
                    lbProd3.Text = topVentas[2].nombreProducto;
                    lbCantProd3.Text = "" + topVentas[2].cantidad;
                }
                if (i == 3)
                {
                    lblTop4.Text = "#4";
                    lbProd4.Text = topVentas[3].nombreProducto;
                    lbCantProd4.Text = "" + topVentas[3].cantidad;
                }
                if (i == 4)
                {
                    lblTop5.Text = "#5";
                    lbProd5.Text = topVentas[4].nombreProducto;
                    lbCantProd5.Text = "" + topVentas[4].cantidad;
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (filtrado)
            {
                ImprimirReportes impresion = new ImprimirReportes(
                lbEnEfectivoVentas.Text,
                lbACreditoVentas.Text,
                lbTotalVentas.Text,
                lbFechaReporte.Text,
                lblHasta.Text,
                lbEfectivoEntradas.Text,
                lbCreditoEntradas.Text,
                lbTotalAgentes.Text,
                lbTotalCaja.Text);
            }
            
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            DateTime fechaReporteDesde = new DateTime(calReporteDesde.SelectionStart.Year, calReporteDesde.SelectionStart.Month,
                calReporteDesde.SelectionStart.Day);

            DateTime fechaReporteHasta = new DateTime(calReporteHasta.SelectionStart.Year, calReporteHasta.SelectionStart.Month,
                calReporteHasta.SelectionStart.Day);
            TodasFacturas facturas = new TodasFacturas(fechaReporteDesde,fechaReporteHasta);
            facturas.StartPosition = FormStartPosition.CenterScreen;
            facturas.Show();
        }
    }
}
