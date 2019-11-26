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

            //La parte de Ventas
            BL_Factura blFactura = new BL_Factura();
            int totalVentasEfectivo = blFactura.obtenerTotalVentasEfectivoDiaEspecifico("" + fechaReporte.Day);
            lbEnEfectivoVentas.Text = "₡" + totalVentasEfectivo;
            int totalVentasCredito = blFactura.obtenerTotalVentasCreditoDiaEspecifico("" + fechaReporte.Day);
            lbACreditoVentas.Text = "₡" + totalVentasCredito;
            int totalVentas = totalVentasEfectivo + totalVentasCredito;
            lbTotalVentas.Text = "₡" + totalVentas;

            //La parte de Entradas
            lbEfectivoEntradas.Text = "₡" + blFactura.obtenerTotalVentasEfectivoDiaEspecifico("" + fechaReporte.Day);
            //Falta parte de los abonos de creditos

            //La parte de Ingresos de Contado
            lbEfectivoIngresos.Text = "₡" + blFactura.obtenerTotalVentasEfectivoDiaEspecifico("" + fechaReporte.Day);
            //no me acuerdo que era pago de clientes

            //La parte de proveedores
            

            //La parte de productos más vendidos

        }
    }
}
