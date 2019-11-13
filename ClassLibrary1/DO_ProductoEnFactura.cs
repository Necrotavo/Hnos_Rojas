using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_ProductoEnFactura
    {
        public DO_Producto producto { set; get; }
        public int cantidadComprada { set; get; }

        public DO_ProductoEnFactura(DO_Producto producto, int cantidadComprada)
        {
            this.producto = producto;
            this.cantidadComprada = cantidadComprada;
        }

        public DO_ProductoEnFactura()
        {
        }
    }
}
