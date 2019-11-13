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
        //SqlCommand comando = new SqlCommand("insert into CREDITO (CRED_LIMITE_CREDITO) Values (@limiteCredito)", conexion);

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
