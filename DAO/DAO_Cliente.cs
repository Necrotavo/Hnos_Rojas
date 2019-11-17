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
                        cliente.id = Convert.ToInt32(lector["PER_IDENTIFICADOR"]);
                        cliente.estado = (String)lector["EST_ESTADO"];
                        cliente.telefono = Convert.ToInt32(lector["PER_TELEFONO"]);
                        cliente.nombre = (String)lector["PER_NOMBRE"];
                        cliente.primerApellido = (String)lector["PER_PRIMER_APELLIDO"];
                        cliente.segundoApellido = (String)lector["PER_SEGUNDO_APELLIDO"];
                        cliente.direccion = (String)lector["CLI_DIRECCION"];
                    }
                    return cliente;
                }
            }
            catch (SqlException) {
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
            catch (SqlException)
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

        public List<DO_Cliente> obtenerListaClientes() {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select * from CLIENTE", conexion);
            DataTable datatable = new DataTable();
            List<DO_Cliente> listaClientes = new List<DO_Cliente>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                adapter.Fill(datatable);

                foreach (DataRow row in datatable.Rows)
                {
                    DO_Cliente nuevoCliente = new DO_Cliente();

                    nuevoCliente.id = Convert.ToInt32(row["PER_IDENTIFICADOR"]);
                    nuevoCliente.estado = (String)row["EST_ESTADO"];
                    nuevoCliente.telefono = Convert.ToInt32(row["PER_TELEFONO"]);
                    nuevoCliente.primerApellido = (String)row["PER_PRIMER_APELLIDO"];
                    nuevoCliente.segundoApellido = (String)row["PER_SEGUNDO_APELLIDO"];
                    nuevoCliente.direccion = (String)row["CLI_DIRECCION"];

                    listaClientes.Add(nuevoCliente);
                }

                return listaClientes;
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

        public bool registrarClienteCrediticio(DO_Cliente cliente) {
            SqlCommand comando = new SqlCommand("Insert into CLIENTE (PER_IDENTIFICATOR, EST_ESTADO, PER_TELEFONO, PER_NOMBRE, PER_PRIMER_APELLIDO, PER_SEGUNDO_APELLIDO, CLI_DIRECCION) Values (@identificador,@estado,@telefono,@nombre,@primerApellido,@segundoApellido,@direccion)", conexion);
            comando.Parameters.AddWithValue("@identificador", cliente.id);
            comando.Parameters.AddWithValue("@estado", "Habilitado"); // el cliente cuando se registra siempre empieza habilitado
            comando.Parameters.AddWithValue("@telefono", cliente.telefono);
            comando.Parameters.AddWithValue("@nombre", cliente.nombre);
            comando.Parameters.AddWithValue("@primerApellido", cliente.primerApellido);
            comando.Parameters.AddWithValue("@segundoApellido", cliente.segundoApellido);
            comando.Parameters.AddWithValue("@direccion", cliente.direccion);

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

        public bool modificarCliente(DO_Cliente cliente) {
            SqlCommand consulta = new SqlCommand("update CLIENTE set " +
                "EST_ESTADO = @estado, " +
                "PER_TELEFONO = @telefono," +  
                "PER_NOMBRE = @nombre," +
                "PER_PRIMER_APELLIDO = @primerApellido, " +
                "PER_SEGUNDO_APELLIDO = @segundoApellido " +
                "CLI_DIRECCION = @direccion " +
                "where PER_IDENTIFICADOR = @idCliente", conexion);

            consulta.Parameters.AddWithValue("@estado", cliente.estado);
            consulta.Parameters.AddWithValue("@telefono", cliente.telefono);
            consulta.Parameters.AddWithValue("@nombre", cliente.nombre);
            consulta.Parameters.AddWithValue("@primerApellido", cliente.primerApellido);
            consulta.Parameters.AddWithValue("@segundoApellido", cliente.segundoApellido);
            consulta.Parameters.AddWithValue("@direccion", cliente.direccion);
            consulta.Parameters.AddWithValue("@idCliente", cliente.id);

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
                else
                {
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
    }
}