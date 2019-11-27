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
    public partial class FacturaDeCliente : Form
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


        public FacturaDeCliente(DO_Factura fact)
        {
            InitializeComponent();
        }
    }
}
