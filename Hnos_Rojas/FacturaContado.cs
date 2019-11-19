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
            string path = System.IO.Directory.GetParent( System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName ) + "\\OpcionesFacturaContado.txt";
            string[] textos = System.IO.File.ReadAllText(path).Split('_');
            nombreLocal = textos[0];
            direccion = textos[1];
            ced = textos[2];
            telefono = textos[3];
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x,y,ancho - x - x,largo - y - y));
            e.Graphics.DrawString(nombreLocal, fuenteTitulo, Brushes.Black, x + 60, y);
            e.Graphics.DrawString(direccion, fuenteGeneral, Brushes.Black, x + 10, y + fuenteTitulo.Height);


        }
    }
}
