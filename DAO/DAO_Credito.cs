﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DO;

namespace DAO
{
    public class DAO_Credito
    {
        private SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);

        public DO_Credito ObtenerCredito(int idCliente) {
            SqlCommand consultaCredito = new SqlCommand("select * from CREDITO where CRE_IDENTIFICADOR = @idCliente", conexion);
            consultaCredito.Parameters.AddWithValue("@idCliente", idCliente);
            DO_Credito credito = new DO_Credito();
            credito.listaFactura = new List<DO_Factura>();
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                SqlDataReader lector = consultaCredito.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        credito.identificador = (int)lector["CRE_IDENTIFICADOR"];
                        credito.limiteCredito = (int)lector["CRED_LIMITE_CREDITO"];
                        credito.monto = (int)lector["CRED_MONTO"];
                    }
                    credito.listaFactura = obtenerFacturas(idCliente);
                    return credito;
                }
            }
            catch (SqlException) { }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }

        public List<DO_Factura> obtenerFacturas(int idCliente) {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select * from FACTURA where CRE_IDENTIFICADOR = @idCliente", conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@idCliente", idCliente);
            DataTable datatable = new DataTable();
            List<DO_Factura> listaFacturas = new List<DO_Factura>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                adapter.Fill(datatable);

                foreach (DataRow row in datatable.Rows)
                {
                    DO_Factura nuevaFactura = new DO_Factura();

                    nuevaFactura.codigoFactura = (int)row["FAC_CODIGO"];
                    nuevaFactura.notas = (String)row["FAC_NOTAS"];
                    nuevaFactura.clienteExterno = (String)row["FAC_CLIENTE_EXTERNO"];
                    nuevaFactura.fecha = (DateTime)row["FAC_FECHA"];
                    nuevaFactura.codigoPlantilla = (int)row["PLANT_CODIGO"];
                    nuevaFactura.usuario = (String)row["USR_NOMBRE"];
                    nuevaFactura.credito = (int)row["CRE_IDENTIFICADOR"];
                    nuevaFactura.estado = (String)row["EST_ESTADO"];
                    nuevaFactura.tipoPago = (String)row["TP_TIPO"];

                    nuevaFactura.listaProducto = obtenerProductosFactura((int)row["FAC_CODIGO"]);

                    listaFacturas.Add(nuevaFactura);
                }
                return listaFacturas;
            }
            catch (SqlException) { }
            finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }

        public List<DO_Producto> obtenerProductosFactura(int codigoFactura) {
            SqlDataAdapter adapterCodigos = new SqlDataAdapter();
            adapterCodigos.SelectCommand = new SqlCommand("select PRO_CODIGO from FAC_TIENE_PRO where FAC_CODIGO = @codigoFactura", conexion);
            adapterCodigos.SelectCommand.Parameters.AddWithValue("@codigoFactura", codigoFactura);
            DataTable datatableCodigos = new DataTable();
            List<DO_Producto> listaProductos = new List<DO_Producto>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                adapterCodigos.Fill(datatableCodigos);

                foreach (DataRow row in datatableCodigos.Rows)
                {
                    String codProducto = (String)row["PRO_CODIGO"];

                    SqlDataAdapter adapterProductos = new SqlDataAdapter();
                    adapterProductos.SelectCommand = new SqlCommand("select * from PRODUCTO where PRO_CODIGO = @codProducto", conexion);
                    adapterProductos.SelectCommand.Parameters.AddWithValue("@codProducto", codProducto);
                    DataTable datatableProductos = new DataTable();

                    adapterProductos.Fill(datatableProductos);

                    foreach (DataRow prodRow in datatableProductos.Rows) {
                        DO_Producto nuevoProducto = new DO_Producto();

                        nuevoProducto.codigo = (String)row["PRO_CODIGO"];
                        nuevoProducto.descripcion = (String)row["PRO_DESCRIPCION"];
                        nuevoProducto.cantMinBodega = (int)row["PRO_CANTIDAD_MINIMA_STOCK"];
                        nuevoProducto.cantidadDisponible = (int)row["PRO_CANTIDAD_DISPONIBLE"];
                        nuevoProducto.precioCosto = (Double)row["PRO_PRECIO_COSTO"];
                        nuevoProducto.precioVenta = (Double)row["PRO_PRECIO_VENTA"];

                        listaProductos.Add(nuevoProducto);
                    }
                }
                return listaProductos;
            }
            catch (SqlException) {
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

        public bool crearCredito(int idCliente, int limiteCredito) {
            SqlCommand comando = new SqlCommand("insert into CREDITO (CRE_IDENTIFICADOR, CRED_LIMITE_CREDITO) Values (@idCliente, @limiteCredito)", conexion);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@limiteCredito", limiteCredito);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (SqlException) {
                return false;
            }
            finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }
    }
}
