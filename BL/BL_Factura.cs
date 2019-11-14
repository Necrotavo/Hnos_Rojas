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
            DAO_Factura daoFactura = new DAO_Factura();
            int codigoFactura = daoFactura.guardarFactura(factura);
            if (codigoFactura > 0) {
                DAO_Producto daoProducto = new DAO_Producto();
                return daoProducto.AgregarProductoAFactura(factura.codigoFactura, factura.listaProducto);
            }
            return false;
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
