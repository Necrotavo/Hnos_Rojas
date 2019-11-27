using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using BL;
using DO;

namespace Hnos_Rojas
{
    public partial class ImprimirReportes : Form
    {
        Font fuenteGeneral = new Font("Arial", 12);
        Font fuenteGrande = new Font("Arial", 16);
        Font fuentePeque = new Font("Arial", 8);
        PaperSize papelTamano;
        string ventasEnEfectivo;
        string ventasCredito;
        string totalVentas;

        string entradasEfectivo;
        string abonosCredito;

        string ingresosContado;
        string pagoClientes;

        string pagoAgentes;
        string totalCaja;
        //dimensiones
        int ancho = 300;
        int largo = 600;
        //punto de inicio
        int x = 0;
        int y = 0;
        public ImprimirReportes(
            string _ventasEnEfectivo,
            string _ventasCredito,
            string _totalVentas,

            string _entradasEfectivo,
            string _abonosCredito,

            string _ingresosContado,
            string _pagoClientes,

            string _pagoAgentes,
            string _totalCaja)
        {
            InitializeComponent();

            ventasCredito = _ventasCredito;
            ventasEnEfectivo = _ventasEnEfectivo;
            totalVentas = _totalVentas;
            entradasEfectivo = _entradasEfectivo;
            abonosCredito = _abonosCredito;
            ingresosContado = _ingresosContado;
            pagoClientes = _pagoClientes;
            pagoAgentes = _pagoAgentes;
            totalCaja = _totalCaja;

            imprimir();
        }

        public void imprimir()
        {
            printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("REPORTE", fuenteGrande, Brushes.Black, x + 100, y);
            e.Graphics.DrawString("VENTAS:", fuenteGrande, Brushes.Black, x, y + (fuenteGeneral.Height * 1));
            e.Graphics.DrawString("En efectivo: " + ventasEnEfectivo, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 2));
            e.Graphics.DrawString("Credito: " + ventasCredito, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 3));
            e.Graphics.DrawString("Total: " + ventasCredito, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 4));

            e.Graphics.DrawString("ENTRADAS DE EFECTIVO:", fuenteGrande, Brushes.Black, x + 100, y + (fuenteGeneral.Height * 7));
            e.Graphics.DrawString("En efectivo: " + entradasEfectivo, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 8));
            e.Graphics.DrawString("Abonos Crédito: " + abonosCredito, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 9));

            e.Graphics.DrawString("INGRESOS CONTADO:", fuenteGrande, Brushes.Black, x + 100, y + (fuenteGeneral.Height * 12));
            e.Graphics.DrawString("En efectivo: " + abonosCredito, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 13));
            e.Graphics.DrawString("Pago Clientes: " + abonosCredito, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 14));

            e.Graphics.DrawString("PAGO AGENTES:", fuenteGrande, Brushes.Black, x + 100, y + (fuenteGeneral.Height * 17));
            e.Graphics.DrawString("Total: " + abonosCredito, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 18));

            e.Graphics.DrawString("TOTAL EN CAJA: " + totalCaja, fuenteGrande, Brushes.Black, x + 75, y + (fuenteGeneral.Height * 20));

        }
    }
}
