using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO;
using BL;
using System.Drawing.Printing;

namespace Hnos_Rojas
{
    public partial class ReporteCreditoCliente : Form
    {
        Font fuenteGeneral = new Font("Arial", 12);
        Font fuenteGrande = new Font("Arial", 16);
        Font fuentePeque = new Font("Arial", 8);
        PaperSize papelTamano;
        //dimensiones
        int ancho = 300;
        int largo = 600;
        //punto de inicio
        int x = 0;
        int y = 0;
        List<DO_Factura> facts;
        string _total;

        public ReporteCreditoCliente(List<DO_Factura> facturas, string total)
        {
            InitializeComponent();
            facts = facturas;
            largo = largo + (fuenteGeneral.Height * facturas.Count);
            papelTamano = new PaperSize("Custom", ancho, largo);
            printDocument1.DefaultPageSettings.PaperSize = papelTamano;
            printPreviewControl1.Document = printDocument1;
            _total = total;
            imprimir();
        }
        private void imprimir()
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ESTADO DE CUENTA", fuenteGrande, Brushes.Black, x + 100, y);
            e.Graphics.DrawString(facts[0].clienteExterno, fuenteGrande, Brushes.Black, x + 100, y);
            
            e.Graphics.DrawString("CODIGO              FECHA                COSTO FACTURA                VALOR PENDIENTE",
                fuentePeque, Brushes.Black, x, y + (fuenteGeneral.Height * 2));
            e.Graphics.DrawLine(Pens.Black, x, y + (fuenteGeneral.Height * 3), ancho, y + (fuenteGeneral.Height * 3));
            int cont = 4;
            foreach (DO_Factura item in facts)
            {
                cont++;
                e.Graphics.DrawString(item.codigoFactura.ToString(), fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * cont));
                e.Graphics.DrawString(item.fecha.ToString().Substring(0,11), fuenteGeneral, Brushes.Black, x + 25, y + (fuenteGeneral.Height * cont));
                e.Graphics.DrawString(item.totalFactura.ToString(), fuenteGeneral, Brushes.Black, x + 145, y + (fuenteGeneral.Height * cont));
                e.Graphics.DrawString(item.saldo.ToString(), fuenteGeneral, Brushes.Black, x + 240, y + (fuenteGeneral.Height * cont));
            }
            e.Graphics.DrawString("TOTAL PENDIENTE", fuenteGeneral, Brushes.Black, x, y + (fuenteGeneral.Height * (facts.Count + 6)));
            e.Graphics.DrawString(_total, fuenteGeneral, Brushes.Black, x + 240, y + (fuenteGeneral.Height * (facts.Count + 6)));
        }
    }
}
