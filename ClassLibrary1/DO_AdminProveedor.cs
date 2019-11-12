using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_AdminProveedor
    {
        public List<DO_Proveedor> listaProveedores { set; get; }

        public DO_AdminProveedor() {
        }

        public DO_AdminProveedor(List<DO_Proveedor> _listaProveedores) {
            this.listaProveedores = _listaProveedores;
        }
    }
}
