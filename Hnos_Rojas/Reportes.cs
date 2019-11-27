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
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaReporte = new DateTime(calReporte.SelectionStart.Year, calReporte.SelectionStart.Month,
                calReporte.SelectionStart.Day, 0, 0, 0);
            lbFechaReporte.Text = fechaReporte.GetDateTimeFormats()[0];
            String inicio = "" + fechaReporte.Year + "-" + fechaReporte.Month + "-" + fechaReporte.Day + " " + "0:0:0";
            String final = "" + fechaReporte.Year + "-" + fechaReporte.Month + "-" + fechaReporte.Day + " " + "23:59:59";
            lbFechaReporte.Text = "" + fechaReporte.Day + "/" + fechaReporte.Month + "/" + fechaReporte.Year;

            //La parte de Ventas
            BL_Factura blFactura = new BL_Factura();
            BL_Pago blPago = new BL_Pago();
            int totalVentasEfectivo = blFactura.obtenerTotalVentasEfectivoDiaEspecifico(inicio, final);
            lbEnEfectivoVentas.Text = "₡" + totalVentasEfectivo;
            int totalVentasCredito = blFactura.obtenerTotalVentasCreditoDiaEspecifico(inicio, final);
            lbACreditoVentas.Text = "₡" + totalVentasCredito;
            int totalVentas = totalVentasEfectivo + totalVentasCredito;
            lbTotalVentas.Text = "₡" + totalVentas;
            int totalPagoProve = blPago.obtenerPagoProvDiaEspecifico(inicio, final);
            int totalAbonosCredito = blFactura.obtenerAbonosCredito(inicio, final);

            //La parte de Entradas
            lbEfectivoEntradas.Text = "₡" + blFactura.obtenerTotalVentasEfectivoDiaEspecifico(inicio, final);
            lbCreditoEntradas.Text = "₡" + totalAbonosCredito;

            //La parte de proveedores
            lbTotalAgentes.Text = "₡" + totalPagoProve;

            //La parte de productos más vendidos
            BL_Producto blProductos = new BL_Producto();
            List<DO_TopProductos> topVentas = blProductos.obtenerTopVentas(inicio, final);
            asignarLabelsTopVentas(topVentas.Count, topVentas);

            //Lo de Caja
            lbTotalCaja.Text = "₡" + (totalVentasEfectivo + totalAbonosCredito - totalPagoProve);
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
                    lbProd1.Text = topVentas[0].nombreProducto;
                    lbCantProd1.Text = "" + topVentas[0].cantidad;
                }
                if (i == 1)
                {
                    lbProd2.Text = topVentas[1].nombreProducto;
                    lbCantProd2.Text = "" + topVentas[1].cantidad;
                }
                if (i == 2)
                {
                    lbProd3.Text = topVentas[2].nombreProducto;
                    lbCantProd3.Text = "" + topVentas[2].cantidad;
                }
                if (i == 3)
                {
                    lbProd4.Text = topVentas[3].nombreProducto;
                    lbCantProd4.Text = "" + topVentas[3].cantidad;
                }
                if (i == 4)
                {
                    lbProd5.Text = topVentas[4].nombreProducto;
                    lbCantProd5.Text = "" + topVentas[4].cantidad;
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
