using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Reporte
    {
        private List<DO_Producto> listaProductos;

        public DO_Reporte() {
        }

        public DO_Reporte(List<DO_Producto> _listaProductos) {
            this.listaProductos = _listaProductos;
        }
    }
}
