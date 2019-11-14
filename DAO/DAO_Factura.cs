using DO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class DAO_Factura
    {
        private SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);

        public int guardarFactura(DO_Factura factura) {

            SqlCommand insert = new SqlCommand("insert into FACTURA (FAC_CODIGO, FAC_NOTAS, FAC_CLIENTE_EXTERNO, FAC_FECHA,+"
               +" PLANT_CODIGO, USR_NOMBRE, CRE_IDENTIFICADOR, EST_ESTADO, TP_TIPO) values"+
               "(@codigo, @notas, @cliente, @fecha, @plantilla, @usrNombre, @credito, @estado, @tipo)", conexion);
            insert.Parameters.AddWithValue("@codigo", factura.codigoFactura);
            insert.Parameters.AddWithValue("@notas", factura.notas);
            insert.Parameters.AddWithValue("@cliente", factura.clienteExterno);
            insert.Parameters.AddWithValue("@fecha", factura.fecha);
            insert.Parameters.AddWithValue("@plantilla", factura.codigoPlantilla);
            insert.Parameters.AddWithValue("@usrNombre", factura.usuario);
            insert.Parameters.AddWithValue("@credito", factura.credito);
            insert.Parameters.AddWithValue("@estado", factura.estado);
            insert.Parameters.AddWithValue("@tipo", factura.tipoPago);
            
            try {
                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                if (insert.ExecuteNonQuery() > 0)
                {
                    SqlCommand obtenerCodigo = new SqlCommand("Select FAC_CODIGO from FACTURA ORDER BY FAC_CODIGO DESC", conexion);
                    return (int)obtenerCodigo.ExecuteScalar();
                }
                else {
                    return 0;
                }
                
            } catch (SqlException) {
            } finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }

            return 0;
        }

        public bool agregarAlCredito(int idCredito, DO_Factura factura) {
            SqlCommand comando = new SqlCommand("Update FACTURA set CRE_IDENTIFICADOR = @idCredito where FAC_CODIGO = @codfactura", conexion);
            comando.Parameters.AddWithValue("@idCredito", idCredito);
            comando.Parameters.AddWithValue("@codfactura", factura.codigoFactura);

            double monto = obtenerMonto(idCredito);
            double total = monto + factura.totalFactura; 

            SqlCommand comandoCredito = new SqlCommand("Update CREDITO set CRED_MONTO = @monto where CRE_IDENTIFICADOR = @identificador", conexion);
            comandoCredito.Parameters.AddWithValue("@monto",total);
            comandoCredito.Parameters.AddWithValue("@identificador",idCredito);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                if (comando.ExecuteNonQuery() > 0 && comandoCredito.ExecuteNonQuery() > 0)
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

        public int obtenerMonto(int idCredito) {
            SqlCommand comandoMonto = new SqlCommand("Select CRED_MONTO from CREDITO where CRED_IDENTIFICADOR = @idCredito", conexion);
            comandoMonto.Parameters.AddWithValue("@idCredito",idCredito);
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                int monto = Convert.ToInt32(comandoMonto.ExecuteScalar());
            }
            catch (SqlException)
            {
                return 0;
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return 0;
        }

        public bool modificarEstadoFactura(int codigoFactura, String estado)
        {
            SqlCommand comando = new SqlCommand("Update FACTURA set EST_ESTADO = @estado where FAC_CODIGO = @codigoFactura", conexion);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@codigoFactura", codigoFactura);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
                return true;
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
    }
}