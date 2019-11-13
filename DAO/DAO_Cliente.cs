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
    public class DAO_Cliente
    {
        private SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);

        public DO_Cliente buscarCliente(int nombre) {
            SqlCommand consulta = new SqlCommand("select * from Cliente where nombre = @nombre", conexion);
            consulta.Parameters.AddWithValue("@nombre", nombre);
            DO_Cliente cliente = new DO_Cliente();
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                SqlDataReader lector = consulta.ExecuteReader();
                if (lector.HasRows) {
                    while (lector.Read()) {
                        cliente.id = (String)lector["PER_IDENTIFICADOR"];
                        cliente.estado = (String)lector["EST_ESTADO"];
                        cliente.telefono = (int)lector["PER_TELEFONO"];
                        cliente.nombre = (String)lector["PER_NOMBRE"];
                        cliente.primerApellido = (String)lector["PER_PRIMER_APELLIDO"];
                        cliente.segundoApellido = (String)lector["PER_SEGUNDO_APELLIDO"];
                        cliente.direccion = (String)lector["CLI_DIRECCION"];
                    }
                    return cliente;
                }
            }
            catch (SqlException){
                return null;
            }
            finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }

        public bool modificarEstadoCliente(int idCliente, String estado) {
            SqlCommand comando = new SqlCommand("Update CLIENTE set EST_ESTADO = @estado where PER_IDENTIFICADOR = @idCliente", conexion);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@idCliente", idCliente);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
                return true;
            }
            catch(SqlException)
            {
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
