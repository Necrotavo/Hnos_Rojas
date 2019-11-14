using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DAO;

namespace BL
{
   public class BL_Factura
    {
        public bool guardarFactura(DO_Factura factura) {

            calcularTotal(factura);
            DAO_Factura dao = new DAO_Factura();
            int co
            if ( > 0) {

            }
        }

        public void calcularTotal(DO_Factura factura)
        {
            double totalFactura = 0;

            foreach(DO_ProductoEnFactura productoEnFactura in factura.listaProducto)
            {
                totalFactura += productoEnFactura.producto.precioVenta;
            }

            factura.totalFactura = totalFactura;

        }
    }
}
