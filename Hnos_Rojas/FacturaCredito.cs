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
    public partial class FacturaCredito : Form
    {
        Font fuenteGeneral = new Font("Arial", 12);
        Font fuenteGrande = new Font("Arial", 16);
        Font fuentePeque = new Font("Arial", 8);
        PaperSize papelTamano;
        string nombreLocal;
        string direccion;
        string ced;
        string telefono;
        string fecha = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        string notas = "NOTAS DE VENTA";
        string cajero;
        List<DO_ProductoEnFactura> productos;
        string total;
        string credito;
        string cliente;
        string creditoPendiente;
        int cantidadTotalProductos = 0;
        int ancho = 300;
        int largo = 600;




        //punto de inicio
        int x = 0;
        int y = 0;
        public FacturaCredito(string _cajero,
            string _total,
            string _credito,
            List<DO_ProductoEnFactura> _productos,
            string _notas,
            string _cliente,
            string _creditoPendiente)
        {
            InitializeComponent();
            cajero = _cajero;
            total = _total;
            credito = _credito;
            creditoPendiente = _creditoPendiente;
            productos = _productos;
            foreach (DO_ProductoEnFactura item in productos)
            {
                cantidadTotalProductos += item.cantidadComprada;
                DO_Producto doProd = item.producto;
                if (doProd.descripcion.Length > 20)
                {
                    item.producto.descripcion = item.producto.descripcion.Substring(0, 20) + "...";
                }

            }
            notas = _notas;
            cliente = _cliente;
            largo = largo + (productos.Count * fuenteGeneral.Height);
            papelTamano = new PaperSize("Custom", ancho, largo);
            printDocument1.DefaultPageSettings.PaperSize = papelTamano;
            printPreviewControl1.Document = printDocument1;
            inicializarStrings();
            imprimir();
        }
        public void imprimir()
        {
            printDocument1.Print();

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(nombreLocal, fuenteGeneral, Brushes.Black, x + 40, y);
            e.Graphics.DrawString(direccion, fuenteGeneral, Brushes.Black, x + 50, y + fuenteGeneral.Height);
            e.Graphics.DrawString("Ced: " + ced, fuenteGeneral, Brushes.Black, x + 75, y + (fuenteGeneral.Height * 2));
            e.Graphics.DrawString("Telefono: " + telefono, fuenteGeneral, Brushes.Black, x + 10, y + (fuenteGeneral.Height * 4));
            e.Graphics.DrawString("Cajero: " + cajero, fuenteGeneral, Brushes.Black, x + 10, y + (fuenteGeneral.Height * 5));
            e.Graphics.DrawString("Cliente: " + cliente, fuenteGeneral, Brushes.Black, x + 10, y + (fuenteGeneral.Height * 6));


            //body
            e.Graphics.DrawString(fecha, fuenteGeneral, Brushes.Black, x + 10, y + (fuenteGeneral.Height * 7));
            e.Graphics.DrawString(notas, fuenteGeneral, Brushes.Black, x + 10, y + (fuenteGeneral.Height * 8));
            e.Graphics.DrawString("CANT.   DESCRIPCION                              IMPORTE",
                fuentePeque, Brushes.Black, x + 10, y + (fuenteGeneral.Height * 10));

            e.Graphics.DrawLine(Pens.Black, x + 10, y + (fuenteGeneral.Height * 11), ancho - x - 10, y + (fuenteGeneral.Height * 11));


            //productos
            for (int i = 0; i < productos.Count; i++)
            {
                e.Graphics.DrawString(productos[i].producto.descripcion, fuenteGeneral, Brushes.Black, x + 30, y + (fuenteGeneral.Height * (12 + i)));
                e.Graphics.DrawString(productos[i].cantidadComprada.ToString(), fuenteGeneral, Brushes.Black, x + 5, y + (fuenteGeneral.Height * (12 + i)));
                e.Graphics.DrawString((productos[i].producto.precioVenta * productos[i].cantidadComprada).ToString(), fuenteGeneral, Brushes.Black, ancho - 60, y + (fuenteGeneral.Height * (12 + i)));
            }
            e.Graphics.DrawString("Cant. Articulos: " + cantidadTotalProductos.ToString(), fuenteGeneral, Brushes.Black, x + 5, y + (fuenteGeneral.Height * (12 + productos.Count)));

            e.Graphics.DrawString("TOTAL: " + total, fuenteGrande, Brushes.Black, x+70, fuenteGeneral.Height * (14 + productos.Count));
            e.Graphics.DrawString("CREDITO ANTERIOR: " + credito, fuenteGrande, Brushes.Black, x, fuenteGeneral.Height * (16 + productos.Count));
            e.Graphics.DrawString("CREDITO PENDIENTE: " +  creditoPendiente, fuenteGrande, Brushes.Black, x+30, fuenteGeneral.Height * (18 + productos.Count));
            
            
 
            


            //pie
            e.Graphics.DrawLine(Pens.Black, x, largo - 1000, ancho/3*2, largo - 100);
            e.Graphics.DrawString("Firma", fuenteGeneral, Brushes.Black, x, largo - 95);
            e.Graphics.DrawString("Gracias por su compra!!!", fuenteGeneral, Brushes.Black, x + 50, largo - 30);
            e.Graphics.DrawString("I.V.A", fuenteGeneral, Brushes.Black, x + 115, largo - 15);

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
    }
}
