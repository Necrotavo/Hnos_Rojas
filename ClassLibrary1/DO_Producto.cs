using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Producto
    {
        public String codigo { set; get; }
        public int precioCosto { set; get; }
        public int precioVenta { set; get; }
        public int cantMinBodega { set; get; }
        public String descripcion { set; get; }
        public int cantidad { set; get; }

        public DO_Producto() {
        }

        public DO_Producto(String _codigo, int _precioCosto, int _precioVenta, int _cantMinBodega, String _descripcion, int _cantidad) {
            this.codigo = _codigo;
            this.precioCosto = _precioCosto;
            this.precioVenta = _precioVenta;
            this.cantMinBodega = _cantMinBodega;
            this.descripcion = _descripcion;
            this.cantidad = _cantidad;
        }
    }
}
