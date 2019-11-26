using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_TopProductos
    {
        public String nombreProducto { set; get; }
        public int cantidad { set; get; }

        public DO_TopProductos() {
        }

        public DO_TopProductos(String _nombreProducto, int _cantidad) {
            this.nombreProducto = _nombreProducto;
            this.cantidad = _cantidad;
        }

    }
}
