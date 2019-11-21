using System;
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

        public DO_Credito ObtenerDatosCredito(int idCliente)
        {
            SqlCommand consultaCredito = new SqlCommand("select * from CREDITO where CRE_IDENTIFICADOR = @idCliente", conexion);
            consultaCredito.Parameters.AddWithValue("@idCliente", idCliente);
            DO_Credito credito = new DO_Credito();
            
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
                        credito.identificador = Convert.ToInt32(lector["CRE_IDENTIFICADOR"]);
                        credito.limiteCredito = Convert.ToInt32(lector["CRED_LIMITE_CREDITO"]);
                        credito.monto = Convert.ToInt32(lector["CRED_MONTO"]);
                    }
                    
                    return credito;
                }
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
            return null;
        }
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
                        credito.identificador = Convert.ToInt32(lector["CRE_IDENTIFICADOR"]);
                        credito.limiteCredito = Convert.ToInt32(lector["CRED_LIMITE_CREDITO"]);
                        credito.monto = Convert.ToInt32(lector["CRED_MONTO"]);
                    }

                    DAO_Factura daoFactura = new DAO_Factura();
                    credito.listaFactura = daoFactura.obtenerFacturasCredito(idCliente);
                    return credito;
                }
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
            return null;
        }

        public bool crearCredito(int idCliente, int limiteCredito) {
            SqlCommand comando = new SqlCommand("insert into CREDITO (CRE_IDENTIFICADOR, CRED_MONTO, CRED_LIMITE_CREDITO) Values (@idCliente, @creditoMonto, @limiteCredito)", conexion);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@creditoMonto", 0);
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

        public double abonar(int abono, int idCredito) {
            double montoCredito = obtenerMonto(idCredito);
            double saldo = montoCredito - abono;

            SqlCommand comando = new SqlCommand("update CREDITO set CRED_MONTO = @saldo where CRE_IDENTIFICADOR = @idCredito", conexion);
            comando.Parameters.AddWithValue("@saldo", saldo);
            comando.Parameters.AddWithValue("@idCredito", idCredito);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                if (comando.ExecuteNonQuery() > 0)
                {
                    return saldo;
                }
                else
                {
                    return 0;
                }
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
        }

        public double obtenerMonto(int idCredito)
        {
            SqlCommand comandoMonto = new SqlCommand("Select CRED_MONTO from CREDITO where CRE_IDENTIFICADOR = @idCredito", conexion);
            comandoMonto.Parameters.AddWithValue("@idCredito", idCredito);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comandoMonto.ExecuteReader();
                double monto = 0;
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        monto = Convert.ToDouble(lector["CRED_MONTO"]);
                    }
                }

                return monto;
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
        }
    }
}