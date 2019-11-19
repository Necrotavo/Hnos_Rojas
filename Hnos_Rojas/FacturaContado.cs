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
        Font fuenteTitulo = new Font("Arial", 15);
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
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x,y,ancho - x - x,largo - y - y));
            e.Graphics.DrawString(nombreLocal, fuenteTitulo, Brushes.Black, x + fuenteTitulo.Height, y + nombreLocal.Length);

        }
    }
}
