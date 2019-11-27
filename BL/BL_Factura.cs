using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DAO;

namespace BL
{
   public class BL_Factura
    {
        public bool guardarFactura(DO_Factura factura) {

            //calcularTotal(factura);
            DAO_Factura daoFactura = new DAO_Factura();
            factura.codigoFactura = daoFactura.guardarFactura(factura);
            if (factura.codigoFactura > 0)
            {
                foreach (DO_ProductoEnFactura productoEnFactura in factura.listaProducto)
                {
                    DAO_Producto daoProducto = new DAO_Producto();
                    if (!daoProducto.AgregarProductoAFactura(factura.codigoFactura, factura.fecha, productoEnFactura))
                    {
                        return false;
                    }
                }
                return true;
            }
            else {
                return false;
            }
        }

        public bool guardarFacturaCredito(DO_Factura factura, int idCredito)
        {

            //calcularTotal(factura);
            DAO_Factura daoFactura = new DAO_Factura();
            factura.codigoFactura = daoFactura.guardarFactura(factura);
            if (factura.codigoFactura > 0)
            {
                foreach (DO_ProductoEnFactura productoEnFactura in factura.listaProducto)
                {
                    DAO_Producto daoProducto = new DAO_Producto();
                    if (!daoProducto.AgregarProductoAFactura(factura.codigoFactura, factura.fecha, productoEnFactura))
                    {
                        return false;
                    }
                }
                daoFactura.agregarAlCredito(idCredito,factura);
                return true;
            }
            else {
                return false;
            }
        }

        public void calcularTotal(DO_Factura factura)
        {
            double totalFactura = 0;

            foreach(DO_ProductoEnFactura productoEnFactura in factura.listaProducto)
            {
                totalFactura += productoEnFactura.producto.precioVenta;
            }
            factura.totalFactura = totalFactura;
            factura.saldo = totalFactura;
        }

        public bool asignarCreditoFactura(DO_Factura factura, int idCredito) {
            DAO_Factura daoFactura = new DAO_Factura();
            daoFactura.agregarAlCredito(idCredito, factura);
            return true;
        }

        public bool modificarEstadoFactura(int codigoFactura, String estado) {
            DAO_Factura daoFactura = new DAO_Factura();
            return daoFactura.modificarEstadoFactura(codigoFactura, estado);
        }

        /// <summary>
        /// Agrega productos a la factura de forma lógica
        /// </summary>
        /// <param name="factura">La factura a la que se le quiere agregar el producto</param>
        /// <param name="producto">El producto a agregar</param>
        /// <param name="cantidad">La cantidad del producto</param>
        /// <returns>La factura con sus producto agregados (DO_Factura)</returns>
        public DO_Factura AgregarProductoAFactura(DO_Factura factura, DO_Producto producto, int cantidad)
        {
            DO_ProductoEnFactura nuevoProducto = new DO_ProductoEnFactura(producto, cantidad);
            factura.listaProducto.Add(nuevoProducto);

            return factura;
        }

        /// <summary>
        /// Calcula el vuelto a entregar
        /// </summary>
        /// <param name="totalAPagar">El total a pagar de la compra</param>
        /// <param name="pago">El pago del cliente</param>
        /// <returns>El vuelto del cliente (double). (0) si no hay vuelto</returns>
        public double CalcularVuelto(double totalAPagar, double pago)
        {
            return pago - totalAPagar;
        }

        /// <summary>
        /// Elimina productos de la factura
        /// </summary>
        /// <param name="factura">La factura a eliminar el producto</param>
        /// <param name="codigo">El código del producto a eliminar</param>
        /// <returns>(True)si se eliminó el producto. (False) si no se eliminó</returns>
        public bool EliminarProductoDeFactura(DO_Factura factura, String codigo)
        {
            foreach(DO_ProductoEnFactura productoEnFactura in factura.listaProducto)
            {
                if (codigo == productoEnFactura.producto.codigo)
                {
                    factura.listaProducto.Remove(productoEnFactura);
                    return true;
                }
            }
            return false;
        }

        public DO_PlantillaFactura obtenerPlantillaFactura()
        {
            DAO_Factura daoFactura = new DAO_Factura();
            return daoFactura.obtenerUltimaPlantilla();
        }

        public int ingresarPlantillaFactura(DO_PlantillaFactura plantillaFactura)
        {
            DAO_Factura daoFactura = new DAO_Factura();
            return daoFactura.ingresarPlantillaFactura(plantillaFactura);
        }

        public bool actualizarPlantillaFactura (DO_PlantillaFactura plantillaFactura)
        {
            DAO_Factura daoFactura = new DAO_Factura();
            return daoFactura.actualizarPlantillaFactura(plantillaFactura);
        }

        public bool abonarFactura(DO_Factura factura, double abono) {
            DAO_Factura daoFactura = new DAO_Factura();
            DAO_Credito daoCredito = new DAO_Credito();

            if (daoFactura.actualizarSaldoFactura(factura, abono) &&
                daoCredito.registrarAbono(factura.credito, abono)) {
                return true;
            } else {
                return false;
            }
        }

        public int obtenerTotalVentasEfectivoDiaEspecifico(String diaInicio, String diaFinal) {
            try
            {
                DAO_Factura daoFactura = new DAO_Factura();
                return daoFactura.obtenerTotalVentasEfectivoDiaEspecifico(diaInicio, diaFinal);
            }
            catch
            {
                return 0;
            }
        }

        public int obtenerTotalVentasCreditoDiaEspecifico(String diaInicio, String diaFinal) {
            try
            {
                DAO_Factura daoFactura = new DAO_Factura();
                return daoFactura.obtenerTotalVentasCreditoDiaEspecifico(diaInicio, diaFinal);
            }catch
            {
                return 0;
            }
        }

        public int obtenerAbonosCredito(String diaInicio, String diaFinal)
        {
            try
            {
                DAO_Factura daoFactura = new DAO_Factura();
                return daoFactura.obtenerAbonosCredito(diaInicio, diaFinal);
            }
            catch
            {
                return 0;
            }
        }
    }
}
