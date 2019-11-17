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
    }
}
