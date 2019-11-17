using DAO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_Proveedor
    {
        public bool ingresarProveedor(DO_Proveedor proveedor) {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.ingresarProveedor(proveedor);
        }

        public bool modificarProveedor(DO_Proveedor proveedor)
        {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.modificarProveedor(proveedor);
        }

        public DO_Proveedor modificarProveedor(String nombreProveedor)
        {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.obtenerProveedor(nombreProveedor);
        }
    }
}
