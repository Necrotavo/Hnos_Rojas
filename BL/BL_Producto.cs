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
        /// Busca un determinado producto por su código
        /// </summary>
        /// <param name="codigo">El código del producto a buscar </param>
        /// <returns>El producto enconctrado (DO_Producto) o (null)si no se encontró el producto</returns>
        public DO_Producto BuscarProducto(String codigo)
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
        public bool ModificarCantidadInventario(String codigoProducto, int nuevaCantidad)
        {
            DAO_Producto daoProducto = new DAO_Producto();

            return daoProducto.ActualizarInventario(codigoProducto, nuevaCantidad);
        }
        /// <summary>
        /// Calcula el porcentaje de ganancia esperado y agrega el producto al inventario.
        /// </summary>
        /// <param name="nuevoProducto">El producto a agregar al inventario</param>
        /// <param name="porcentajeGanancia">El porcentaje que se desea de ganancia</param>
        /// <returns>(True) si se agregó correctamente.(False) si no se agregó el producto</returns>
        public bool AgregarProductoAInventario(DO_Producto nuevoProducto, int porcentajeGanancia)
        {
            DAO_Producto daoProducto = new DAO_Producto();

            nuevoProducto.precioVenta = nuevoProducto.precioCosto + (nuevoProducto.precioCosto * (porcentajeGanancia / 100));

            return daoProducto.AgregarProductoInventario(nuevoProducto);
        }
        /// <summary>
        /// Calcula el porcentaje de ganacia que se debió haber aplicado para obtener el precio de venta
        /// </summary>
        /// <param name="precioCosto">El precio de costo del producto</param>
        /// <param name="precioVenta">El precio de venta del producto</param>
        /// <returns>El porcentaje de ganancia (int)</returns>
        public int CalcularPorcentajeGanancia(double precioCosto, double precioVenta)
        {
            int porcentaje = 0;

            porcentaje = Convert.ToInt32(Math.Round((precioVenta - precioCosto) * 100 / precioCosto));

            return porcentaje;
        }
        /// <summary>
        /// Actualiza los datos de un determinado producto.
        /// </summary>
        /// <param name="productoAModificar">El producto a modificar</param>
        /// <param name="codigoAntiguo">Si se modificó el código se necesita el antiguo para poder realizar el cambio.</param>
        /// <returns>(True) si se modificó correctamente.(False)si no se modificó</returns>
        public bool ModificarProducto(DO_Producto productoAModificar, String codigoAntiguo)
        {
            DAO_Producto daoProducto = new DAO_Producto();

            return daoProducto.ModificarProducto(productoAModificar, codigoAntiguo);
        }
        /// <summary>
        /// Elimina un determinado producto del inventario.
        /// </summary>
        /// <param name="codigo">Código del producto a eliminar</param>
        /// <returns>(True)si se eliminó correctamente.(False) si no se eliminó</returns>
        public bool EliminarProducto (String codigo)
        {
            DAO_Producto daoProducto = new DAO_Producto();

            return daoProducto.EliminarProducto(codigo);
        }

    }
}
