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

        string fechaInicio;
        string fechaFinal;
        
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
            string _fechaInicio,
            string _fechaFinal,
            string _entradasEfectivo,
            string _abonosCredito,

            string _pagoAgentes,
            string _totalCaja)
        {
            InitializeComponent();

            ventasCredito = _ventasCredito;
            ventasEnEfectivo = _ventasEnEfectivo;
            totalVentas = _totalVentas;
            entradasEfectivo = _entradasEfectivo;
            abonosCredito = _abonosCredito;
            pagoAgentes = _pagoAgentes;
            totalCaja = _totalCaja;
            fechaFinal = _fechaFinal;
            fechaInicio = _fechaInicio;
            papelTamano = new PaperSize("Custom", ancho, largo);
            printDocument1.DefaultPageSettings.PaperSize = papelTamano;
            printPreviewControl1.Document = printDocument1;
            imprimir();
        }

        public void imprimir()
        {
            printDocument1.Print();

        }
        private long sumarDosStringsNumericas(string numero1, string numero2)
        {
            return Convert.ToInt64(numero1.Substring(1)) + Convert.ToInt64(numero2.Substring(1));
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("REPORTES", fuenteGrande, Brushes.Black, x + 100, y);
            e.Graphics.DrawString("Del: "+fechaInicio+" "+fechaFinal, fuentePeque, Brushes.Black, x, y + 35);
            e.Graphics.DrawString("VENTAS:", fuenteGrande, Brushes.Black, x, y + (fuenteGeneral.Height * 3));
            e.Graphics.DrawString("En efectivo: " + ventasEnEfectivo, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 4));
            e.Graphics.DrawString("Credito: " + ventasCredito, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 5));
            e.Graphics.DrawString("Total: ₡" + sumarDosStringsNumericas(ventasEnEfectivo,ventasCredito) , fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 6));


            e.Graphics.DrawString("ENTRADAS DE EFECTIVO:", fuenteGrande, Brushes.Black, x, y + (fuenteGeneral.Height * 8));
            e.Graphics.DrawString("En efectivo: " + entradasEfectivo, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 9));
            e.Graphics.DrawString("Abonos Crédito: " + abonosCredito, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 10));
            e.Graphics.DrawString("Total: ₡" + sumarDosStringsNumericas(entradasEfectivo, abonosCredito), fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 11));
           
            
            e.Graphics.DrawString("PAGO AGENTES:", fuenteGrande, Brushes.Black, x, y + (fuenteGeneral.Height * 13));
            e.Graphics.DrawString("Total: " + pagoAgentes, fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * 14));

            e.Graphics.DrawString("CORTE: " + totalCaja, fuenteGrande, Brushes.Black, x + 75, y + (fuenteGeneral.Height * 16));

        }
    }
}
