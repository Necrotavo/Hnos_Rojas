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

        public DO_Cliente buscarCliente(String nombre) {
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
                    }
                }
                return cliente;
            }
            catch (SqlException)
            {
            }
            finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }
    }
}
