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

        public DO_Proveedor obtenerProveedor(String nombreProveedor)
        {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.obtenerProveedor(nombreProveedor);
        }

        public bool pagarProveedor(DO_Pago pago)
        {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.pagarProveedor(pago);
        }

        public List<DO_Proveedor> obtenerListaProveedores(String filtro) {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.obtenerListaProveedores(filtro);
        }

        public bool eliminarProveedor(String nombre) {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.EliminarProveedor(nombre);
        }
    }
}
