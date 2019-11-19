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
using System.Drawing;
using BL;
using DO;

namespace Hnos_Rojas
{
    public partial class FacturaContado : Form
    {
        Font fuenteGeneral = new Font("Arial", 12);
        PaperSize papelTamano;
        string nombreLocal;
        string direccion;
        string ced;
        string telefono;
        string fecha = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        string notas = "NOTAS DE VENTA";
        string cajero;
        List<string> productos;
        string total;
        string pagaCon;
        string vuelto;
        int ancho = 300;
        int largo = 500;




        //punto de inicio
        int x = 30;
        int y = 30;

        public FacturaContado()
        {
            InitializeComponent();
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", ancho, largo);
            printPreviewControl1.Document = printDocument1;
            inicializarStrings();

        }
        private void inicializarStrings()
        {
            BL_Factura blFactura = new BL_Factura();
            DO_PlantillaFactura plantilla = blFactura.obtenerPlantillaFactura();
            nombreLocal = plantilla.nombreEmpresa;
            direccion = plantilla.direccion;
            ced = plantilla.cedula;
            telefono = plantilla.numeroTelefono;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //encabezado
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x,y,ancho - x - x,largo - y - y));
            e.Graphics.DrawString(nombreLocal, fuenteGeneral, Brushes.Black, x + 3, y);
            e.Graphics.DrawString(direccion, fuenteGeneral, Brushes.Black, x + 12, y + fuenteGeneral.Height);
            e.Graphics.DrawString("Ced: " + ced, fuenteGeneral, Brushes.Black, x + 60, y + (fuenteGeneral.Height * 2));
            e.Graphics.DrawString("Telefono: " + telefono, fuenteGeneral, Brushes.Black, x + 40, y + (fuenteGeneral.Height * 3));

            //body
            e.Graphics.DrawString(fecha, fuenteGeneral, Brushes.Black, x + 40, y + (fuenteGeneral.Height * 6));
            e.Graphics.DrawString(notas, fuenteGeneral, Brushes.Black, x + 43, y + (fuenteGeneral.Height * 7));
            e.Graphics.DrawLine(Pens.Black, x + 10, y + (fuenteGeneral.Height * 9) , ancho - x - 10, y + (fuenteGeneral.Height * 9));

            //pie
            e.Graphics.DrawLine(Pens.Black, x + 10, largo - 90 , ancho - x - 10, largo - 90);
            e.Graphics.DrawString("Gracias por su compra!!!", fuenteGeneral, Brushes.Black, x + 25, largo - 60);



        }
    }
}
