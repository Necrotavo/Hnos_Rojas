using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Producto
    {
        public String codigo;
        public int precioCosto;
        public int precioVenta;
        public int cantMinBodega;
        public String descripcion;
        public int cantidad;

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
