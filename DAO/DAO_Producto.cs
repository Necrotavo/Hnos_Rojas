﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DO;

namespace DAO
{
    public class DAO_Producto
    {
        SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);

        /// <summary>
        /// Busca un determinado producto de la base de datos y lo retorna
        /// </summary>
        /// <param name="codigo">El código del producto a buscar</param>
        /// <returns>El producto encontrado(DO_Producto), o (null) si no se encuentra registrado</returns>
        public DO_Producto BuscarProducto(String codigo) {

            SqlCommand consulta = new SqlCommand("select * from Producto where PRO_CODIGO = @codigo", conexion);
            consulta.Parameters.AddWithValue("@codigo", codigo);

            DO_Producto producto = new DO_Producto();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                SqlDataReader lector = consulta.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        producto.codigo = (String)lector["PRO_CODIGO"];
                        producto.descripcion = (String)lector["PRO_DESCRIPCION"];
                        producto.cantMinBodega = Convert.ToInt32(lector["PRO_CANTIDAD_MINIMA_STOCK"]);
                        producto.cantidadDisponible = Convert.ToInt32(lector["PRO_CANTIDAD_DISPONIBLE"]);
                        producto.precioCosto = Convert.ToDouble(lector["PRO_PRECIO_COSTO"]);
                        producto.precioVenta = Convert.ToDouble(lector["PRO_PRECIO_VENTA"]);
                    }
                }
                return producto;

            }
            catch (SqlException)
            {

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }

        public List<DO_Producto> BuscarListaProductos(String codigo)
        {
            SqlCommand consulta = new SqlCommand("select * from Producto Where PRO_CODIGO LIKE @codigo OR PRO_DESCRIPCION LIKE @codigo", conexion);
            consulta.Parameters.AddWithValue("@codigo", "%" + codigo + "%");

            List<DO_Producto> listaProductos = new List<DO_Producto>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                SqlDataReader lector = consulta.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        listaProductos.Add(new DO_Producto((String)lector["PRO_CODIGO"], Convert.ToDouble(lector["PRO_PRECIO_COSTO"]), Convert.ToDouble(lector["PRO_PRECIO_VENTA"]), Convert.ToInt32(lector["PRO_CANTIDAD_MINIMA_STOCK"]), (String)lector["PRO_DESCRIPCION"], Convert.ToInt32(lector["PRO_CANTIDAD_DISPONIBLE"])));
                    }
                }
                return listaProductos;

            }
            catch (SqlException)
            {

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }

        /// <summary>
        /// Actualiza la cantidad disponible de productos en el inventario
        /// </summary>
        /// <param name="codigo">El código del producto</param>
        /// <param name="cantidadDisponible">La nueva cantidad disponible del producto</param>
        /// <returns>(True) si se actualizó la cantidad. (False) si no se actualizó</returns>
        public bool ActualizarInventario(String codigo, int cantidadDisponible, int cantidadComprada)
        {
            SqlCommand consulta = new SqlCommand("update Producto set PRO_CANTIDAD_DISPONIBLE = @cantidadDisponible Where PRO_CODIGO = @codigo", conexion);
            consulta.Parameters.AddWithValue("@codigo", codigo);
            consulta.Parameters.AddWithValue("@cantidadDisponible", cantidadDisponible - cantidadComprada);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                if(consulta.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                
            }
            catch (SqlException)
            {

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return false;
        }

        /// <summary>
        /// Agrega los productos de determinada factura 
        /// </summary>
        /// <param name="codigoFactura">Codigo de la factura a la cual pertenecen los productos</param>
        /// <param name="listaProductos">La lista de los producto comprados de la factura</param>
        /// <returns>(True) si se agregaron correctamente.(False) si no se agregaron</returns>
        public bool AgregarProductoAFactura(int codigoFactura, DateTime fecha, DO_ProductoEnFactura productoVendido)
        {
            SqlCommand consulta = new SqlCommand("insert into FAC_TIENE_PRO (PRO_CODIGO,FAC_CODIGO,FAC_FECHA, CANTIDAD_COMPRADA) values (@codigoProducto,@codigoFactura,@fecha, @cantComprada)", conexion);
            consulta.Parameters.AddWithValue("@codigoFactura", codigoFactura);
            consulta.Parameters.AddWithValue("@fecha", fecha);
            consulta.Parameters.AddWithValue("@codigoProducto", productoVendido.producto.codigo);
            consulta.Parameters.AddWithValue("@cantComprada", productoVendido.cantidadComprada);
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                if (consulta.ExecuteNonQuery() > 0)
                {
                    ActualizarInventario(productoVendido.producto.codigo, productoVendido.producto.cantidadDisponible, productoVendido.cantidadComprada);
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Agrega un nuevo producto al inventario
        /// </summary>
        /// <param name="nuevoProducto">El nuevo producto con sus respectivos datos a agregar</param>
        /// <returns>(True) si el producto se agregó correctamente. (False) si no se agregó</returns>
        public bool AgregarProductoInventario(DO_Producto nuevoProducto)
        {
            SqlCommand consulta = new SqlCommand("insert into Producto (PRO_CODIGO,PRO_DESCRIPCION,PRO_CANTIDAD_MINIMA_STOCK," +
                "PRO_CANTIDAD_DISPONIBLE,PRO_PRECIO_COSTO,PRO_PRECIO_VENTA) values (@codigo,@descripcion,@cantidadMinima," +
                "@cantidadDisponible,@precioCosto,@precioVenta)", conexion);
            consulta.Parameters.AddWithValue("@codigo", nuevoProducto.codigo);
            consulta.Parameters.AddWithValue("@descripcion", nuevoProducto.descripcion);
            consulta.Parameters.AddWithValue("@cantidadMinima", nuevoProducto.cantMinBodega);
            consulta.Parameters.AddWithValue("@cantidadDisponible", nuevoProducto.cantidadDisponible);
            consulta.Parameters.AddWithValue("@precioCosto", nuevoProducto.precioCosto);
            consulta.Parameters.AddWithValue("@precioVenta", nuevoProducto.precioVenta);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                if (consulta.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Modifica los datos de un producto previamente registrado
        /// </summary>
        /// <param name="productoAModificar">El producto al cual se le modificaron datos</param>
        /// <returns>(True) si se modificó correctamente.(False)si no se modificó</returns>

        public bool ModificarProducto(DO_Producto productoAModificar)
        {
            SqlCommand consulta = new SqlCommand("update Producto set PRO_DESCRIPCION = @descripcion, PRO_CANTIDAD_MINIMA_STOCK = @cantidadMinima," +
                "PRO_CANTIDAD_DISPONIBLE = @cantidadDisponible, PRO_PRECIO_COSTO = @precioCosto, PRO_PRECIO_VENTA = @precioVenta where PRO_CODIGO = @codigo", conexion);
            consulta.Parameters.AddWithValue("@descripcion", productoAModificar.descripcion);
            consulta.Parameters.AddWithValue("@cantidadMinima", productoAModificar.cantMinBodega);
            consulta.Parameters.AddWithValue("@cantidadDisponible", productoAModificar.cantidadDisponible);
            consulta.Parameters.AddWithValue("@precioCosto", productoAModificar.precioCosto);
            consulta.Parameters.AddWithValue("@precioVenta", productoAModificar.precioVenta);
            consulta.Parameters.AddWithValue("@codigo", productoAModificar.codigo);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                if (consulta.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (SqlException)
            {

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return false;
        }
        /// <summary>
        /// Elimina un determinado producto del inventario.
        /// </summary>
        /// <param name="codigo">Código del producto a eliminar</param>
        /// <returns>(True)si se eliminó correctamente.(False) si no se eliminó</returns>

        public bool EliminarProducto(String codigo)
        {
            SqlCommand consulta = new SqlCommand("delete from Producto Where PRO_CODIGO = @codigo", conexion);
            consulta.Parameters.AddWithValue("@codigo", codigo);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                if (consulta.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (SqlException)
            {

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return false;
        }
        /// <summary>
        /// Obtiene la lista con todos los productos registrados
        /// </summary>
        /// <returns>Lista con los productos (List<DO_Producto)></returns>

        public List<DO_Producto> CargarProductos()
        {
            SqlCommand consulta = new SqlCommand("select * from Producto", conexion);


            List<DO_Producto> listaProductos = new List<DO_Producto>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                SqlDataReader lector = consulta.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        listaProductos.Add(new DO_Producto((String)lector["PRO_CODIGO"], Convert.ToDouble(lector["PRO_PRECIO_COSTO"]), Convert.ToDouble(lector["PRO_PRECIO_VENTA"]), Convert.ToInt32(lector["PRO_CANTIDAD_MINIMA_STOCK"]), (String)lector["PRO_DESCRIPCION"], Convert.ToInt32(lector["PRO_CANTIDAD_DISPONIBLE"])));
                    }
                }
                return listaProductos;

            }
            catch (SqlException)
            {

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }

        public List<DO_ProductoEnFactura> obtenerProductosFactura(int codigoFactura)
        {
            SqlDataAdapter adapterCodigos = new SqlDataAdapter();
            adapterCodigos.SelectCommand = new SqlCommand("select PRO_CODIGO, CANTIDAD_COMPRADA from FAC_TIENE_PRO where FAC_CODIGO = @codigoFactura", conexion);
            adapterCodigos.SelectCommand.Parameters.AddWithValue("@codigoFactura", codigoFactura);
            DataTable datatableCodigos = new DataTable();
            List<DO_ProductoEnFactura> listaProductos = new List<DO_ProductoEnFactura>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                adapterCodigos.Fill(datatableCodigos);

                foreach (DataRow row in datatableCodigos.Rows)
                {
                    DO_ProductoEnFactura nuevoProducto = new DO_ProductoEnFactura();
                    nuevoProducto.cantidadComprada = Convert.ToInt32(row["CANTIDAD_COMPRADA"]);
                    String codProducto = (String)row["PRO_CODIGO"];

                    SqlDataAdapter adapterProductos = new SqlDataAdapter();
                    adapterProductos.SelectCommand = new SqlCommand("select * from PRODUCTO where PRO_CODIGO = @codProducto", conexion);
                    adapterProductos.SelectCommand.Parameters.AddWithValue("@codProducto", codProducto);
                    DataTable datatableProductos = new DataTable();

                    adapterProductos.Fill(datatableProductos);

                    foreach (DataRow prodRow in datatableProductos.Rows)
                    {
                        nuevoProducto.producto = new DO_Producto();

                        nuevoProducto.producto.codigo = (String)prodRow["PRO_CODIGO"];
                        nuevoProducto.producto.descripcion = (String)prodRow["PRO_DESCRIPCION"];
                        nuevoProducto.producto.cantMinBodega = Convert.ToInt32(prodRow["PRO_CANTIDAD_MINIMA_STOCK"]);
                        nuevoProducto.producto.cantidadDisponible = Convert.ToInt32(prodRow["PRO_CANTIDAD_DISPONIBLE"]);
                        nuevoProducto.producto.precioCosto = Convert.ToDouble(prodRow["PRO_PRECIO_COSTO"]);
                        nuevoProducto.producto.precioVenta = Convert.ToDouble(prodRow["PRO_PRECIO_VENTA"]);

                        listaProductos.Add(nuevoProducto);
                    }
                }
                return listaProductos;
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        public List<DO_TopProductos> obtenerTopVentas(String diaInicio, String diaFinal) {
            List<DO_TopProductos> productos = new List<DO_TopProductos>();

            SqlCommand comando = new SqlCommand("SELECT P.PRO_DESCRIPCION, SUM(T.CANTIDAD_COMPRADA) AS CANTIDAD_COMPRADA FROM PRODUCTO AS P, FAC_TIENE_PRO AS T where P.PRO_CODIGO = T.PRO_CODIGO AND(T.FAC_FECHA BETWEEN @diaInicio AND @diaFinal) GROUP BY T.PRO_CODIGO, P.PRO_DESCRIPCION ORDER BY CANTIDAD_COMPRADA DESC", conexion);
            comando.Parameters.AddWithValue("@diaInicio", diaInicio);
            comando.Parameters.AddWithValue("@diaFinal", diaFinal);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        productos.Add(new DO_TopProductos((String)lector["PRO_DESCRIPCION"], Convert.ToInt32(lector["CANTIDAD_COMPRADA"])));    
                    }
                }
                return productos;

            }
            catch (SqlException)
            {

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return productos;  
        }
    }
}
