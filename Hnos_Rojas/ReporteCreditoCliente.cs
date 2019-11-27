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


        public ReporteCreditoCliente(List<DO_Factura> facturas)
        {
            InitializeComponent();
            papelTamano = new PaperSize("Custom", ancho, largo);
            printDocument1.DefaultPageSettings.PaperSize = papelTamano;
            printPreviewControl1.Document = printDocument1;
            imprimir();
        }
        private void imprimir()
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
