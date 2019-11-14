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
        public double precioCosto { set; get; }
        public double precioVenta { set; get; }
        public int cantMinBodega { set; get; }
        public String descripcion { set; get; }
        public int cantidadDisponible { set; get; }

        public DO_Producto() {
        }

        public DO_Producto(String _codigo, double _precioCosto, int _precioVenta, int _cantMinBodega, String _descripcion, int _cantidadMinima) {
            this.codigo = _codigo;
            this.precioCosto = _precioCosto;
            this.precioVenta = _precioVenta;
            this.cantMinBodega = _cantMinBodega;
            this.descripcion = _descripcion;
            this.cantidadDisponible = _cantidadMinima;
        }
    }
}
