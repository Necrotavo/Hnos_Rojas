using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DAO;

namespace BL
{
    public class BL_Producto
    {
        /// <summary>
        /// Método que solicita buscar un determinado producto por su código
        /// </summary>
        /// <param name="codigo">El código del producto a buscar </param>
        /// <returns>El producto enconctrado (DO_Producto) o (null)si no se encontró el producto</returns>
        public DO_Producto AgregarProductoAFactura(String codigo)
        {
            DAO_Producto daoProducto = new DAO_Producto();

            return daoProducto.BuscarProducto(codigo);
        }
        /// <summary>
        /// Modifica la cantidad de elementos disponibles del producto
        /// </summary>
        /// <param name="codigoProducto">Código del producto a modificar</param>
        /// <param name="nuevaCantidad">Nueva cantidad disponible</param>
        /// <returns>(True) si se actualizó correctamente.(False)si no se actualizó</returns>
        public bool modificarCantidadInventario(String codigoProducto, int nuevaCantidad)
        {
            DAO_Producto daoProducto = new DAO_Producto();

            return daoProducto.ActualizarInventario(codigoProducto, nuevaCantidad);
        }

    }
}
