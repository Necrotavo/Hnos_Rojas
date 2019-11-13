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
            return dao.guardarFactura(factura);
        }

        public void calcularTotal(DO_Factura factura)
        {
            double totalFactura = 0;

            foreach(DO_Producto producto in factura.listaProducto)
            {
                totalFactura += producto.precioVenta;
            }

            factura.totalFactura = totalFactura;

        }
    }
}
