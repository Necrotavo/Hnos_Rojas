using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_AdminProveedor
    {
        private List<DO_Proveedor> listaProveedores;

        public DO_AdminProveedor() {
        }

        public DO_AdminProveedor(List<DO_Proveedor> _listaProveedores) {
            this.listaProveedores = _listaProveedores;
        }
    }
}
