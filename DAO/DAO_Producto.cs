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
                        producto.cantMinBodega = (int)lector["PRO_CANTIDAD_MINIMA_STOCK"];
                        producto.cantidadDisponible = (int)lector["PRO_CANTIDAD_DISPONIBLE"];
                        producto.precioCosto = (double)lector["PRO_PRECIO_COSTO"];
                        producto.precioVenta = (double)lector["PRO_PRECIO_VENTA"];
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

        /// <summary>
        /// Actualiza la cantidad disponible de productos en el inventario
        /// </summary>
        /// <param name="codigo">El código del producto</param>
        /// <param name="cantidadDisponible">La nueva cantidad disponible del producto</param>
        /// <returns>(True) si se actualizó la cantidad. (False) si no se actualizó</returns>
        public bool ActualizarInventario(String codigo, int cantidadDisponible)
        {
            SqlCommand consulta = new SqlCommand("update Producto set PRO_CANTIDAD_DISPONIBLE = @cantidadDisponible", conexion);
            consulta.Parameters.AddWithValue("@cantidadDisponible", cantidadDisponible);

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
        /// Agrega un nuevo producto al inventario
        /// </summary>
        /// <param name="nuevoProducto">El nuevo producto con sus respectivos datos a agregar</param>
        /// <returns>(True) si el producto se agregó correctamente. (False) si no se agregó</returns>
        public bool AgregarProducto(DO_Producto nuevoProducto)
        {
            SqlCommand consulta = new SqlCommand("insert into Producto (PRO_CODIGO,PRO_DESCRIPCION,PRO_CANTIDAD_MINIMA_STOCK" +
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

            }
            catch (SqlException)
            {

            }
            finally
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
            }
            return false;
        } 



    }
}