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
        public List<DO_Producto> BuscarListaProducto(String codigo)
        {
            DAO_Producto daoProducto = new DAO_Producto();

            return daoProducto.BuscarListaProductos(codigo);
        }
        ///// <summary>
        ///// Modifica la cantidad de elementos disponibles del producto
        ///// </summary>
        ///// <param name="codigoProducto">Código del producto a modificar</param>
        ///// <param name="nuevaCantidad">Nueva cantidad disponible</param>
        ///// <returns>(True) si se actualizó correctamente.(False)si no se actualizó</returns>
        //public bool ModificarCantidadInventario(String codigoProducto, int nuevaCantidad, int cantidadComprada)
        //{
        //    DAO_Producto daoProducto = new DAO_Producto();

        //    return daoProducto.ActualizarInventario(codigoProducto, nuevaCantidad);
        //}
        /// <summary>
        /// Obtiene el precio de venta de un producto según el porcentaje de ganancia esperado
        /// </summary>
        /// <param name="precioCosto">El precio de costo del producto</param>
        /// <param name="porcentajeEsperado">El porcentaje de ganancia esperado</param>
        /// <returns>El precio de venta del producto (double)</returns>
        public double ObtenerPrecioVenta(double precioCosto, int porcentajeEsperado)
        {
            decimal precioVenta = 0;
            if (precioCosto != 0 || porcentajeEsperado != 0)
            {
                precioVenta = (decimal)precioCosto + (decimal)precioCosto * ((decimal)porcentajeEsperado / 100);

            }
            return Convert.ToDouble(precioVenta);
        }
        /// <summary>
        /// Agrega el producto al inventario.
        /// </summary>
        /// <param name="nuevoProducto">El producto a agregar al inventario</param>
        /// <returns>(True) si se agregó correctamente.(False) si no se agregó el producto</returns>
        public bool AgregarProductoAInventario(DO_Producto nuevoProducto)
        {
            DAO_Producto daoProducto = new DAO_Producto();

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

            if (precioCosto != 0 || precioVenta !=0)
            {
                porcentaje = Convert.ToInt32(Math.Round(((decimal)precioVenta - (decimal)precioCosto) * 100 / (decimal)precioCosto));
            }
            return porcentaje;
        }
        /// <summary>
        /// Actualiza los datos de un determinado producto.
        /// </summary>
        /// <param name="productoAModificar">El producto a modificar</param>
        /// <param name="codigoAntiguo">Si se modificó el código se necesita el antiguo para poder realizar el cambio.</param>
        /// <returns>(True) si se modificó correctamente.(False)si no se modificó</returns>
        public bool ModificarProducto(DO_Producto productoAModificar)
        {
            DAO_Producto daoProducto = new DAO_Producto();

            return daoProducto.ModificarProducto(productoAModificar);
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
        /// <summary>
        /// Obtiene la lista con todos los productos registrados.
        /// </summary>
        /// <returns>Lista con los productos (List<DO_Producto>)</returns>
        public List<DO_Producto> ObtenerListaDeProductos()
        {
            DAO_Producto daoProducto = new DAO_Producto();

            return daoProducto.CargarProductos();
        }

        public List<DO_Producto> ObtenerListaProductosComunes()
        {
            DAO_Producto daoProducto = new DAO_Producto();

            return daoProducto.cargarProductosComunes();
        }

        public List<DO_TopProductos> obtenerTopVentas(String diaInicio, String diaFinal) {
            DAO_Producto daoProducto = new DAO_Producto();
            return daoProducto.obtenerTopVentas(diaInicio, diaFinal);
        }

    }
}
