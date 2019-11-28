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
            SqlCommand consulta = new SqlCommand("select * from CLIENTE where PER_NOMBRE = @nombre ", conexion);
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
                        cliente.perIdentificador = Convert.ToInt32(lector["PER_IDENTIFICADOR"]);
                        cliente.estado = (String)lector["EST_ESTADO"];
                        cliente.perTelefono = (String)(lector["PER_TELEFONO"]);
                        cliente.perNombre = (String)lector["PER_NOMBRE"];
                        cliente.perPrimerApellido = (String)lector["PER_PRIMER_APELLIDO"];
                        cliente.perSegundoApellido = (String)lector["PER_SEGUNDO_APELLIDO"];
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
        public List<DO_Cliente> buscarClientes(String datos)
        {
            SqlCommand consulta = new SqlCommand("select * from CLIENTE where PER_NOMBRE LIKE @nombre OR PER_PRIMER_APELLIDO LIKE @nombre", conexion);
            consulta.Parameters.AddWithValue("@nombre","%"+ datos+"%");
            List<DO_Cliente> listaClientes = new List<DO_Cliente>();
           
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
                        

                        //cliente.perIdentificador = Convert.ToInt32(lector["PER_IDENTIFICADOR"]);
                        //cliente.estado = (String)lector["EST_ESTADO"];
                        //cliente.perTelefono = (String)(lector["PER_TELEFONO"]);
                        //cliente.perNombre = (String)lector["PER_NOMBRE"];
                        //cliente.perPrimerApellido = (String)lector["PER_PRIMER_APELLIDO"];
                        //cliente.perSegundoApellido = (String)lector["PER_SEGUNDO_APELLIDO"];
                        //cliente.direccion = (String)lector["CLI_DIRECCION"];

                        listaClientes.Add(new DO_Cliente(Convert.ToInt32(lector["PER_IDENTIFICADOR"]), (String)lector["PER_NOMBRE"],
                            (String)lector["PER_PRIMER_APELLIDO"], (String)lector["PER_SEGUNDO_APELLIDO"], (String)lector["CLI_DIRECCION"], (String)(lector["PER_TELEFONO"]), (String)lector["EST_ESTADO"]));
                    }
                    return listaClientes;
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

        public DO_Cliente buscarCliente(int idCliente)
        {
            SqlCommand consulta = new SqlCommand("select * from CLIENTE where PER_IDENTIFICADOR = @idCliente", conexion);
            consulta.Parameters.AddWithValue("@idCliente", idCliente);
            DO_Cliente cliente = new DO_Cliente();
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
                        cliente.perIdentificador = Convert.ToInt32(lector["PER_IDENTIFICADOR"]);
                        cliente.estado = (String)lector["EST_ESTADO"];
                        cliente.perTelefono = (String)(lector["PER_TELEFONO"]);
                        cliente.perNombre = (String)lector["PER_NOMBRE"];
                        cliente.perPrimerApellido = (String)lector["PER_PRIMER_APELLIDO"];
                        cliente.perSegundoApellido = (String)lector["PER_SEGUNDO_APELLIDO"];
                        cliente.direccion = (String)lector["CLI_DIRECCION"];
                    }
                    return cliente;
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

        public List<DO_Cliente> obtenerListaClientesHabilitados(bool clientesHabilitados, String nombre) {
            SqlDataAdapter adapter = new SqlDataAdapter();
            String consultaClientes = "select * from CLIENTE where PER_NOMBRE LIKE @filtro or PER_PRIMER_APELLIDO LIKE @filtro and EST_ESTADO = 'HABILITADO'";
            DataTable datatable = new DataTable();
            DAO_Credito daoCredito = new DAO_Credito();
            List<DO_Cliente> listaClientes = new List<DO_Cliente>();

 
            adapter.SelectCommand = new SqlCommand(consultaClientes, conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@filtro", "%" + nombre + "%");
            
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

                    nuevoCliente.perIdentificador = Convert.ToInt32(row["PER_IDENTIFICADOR"]);
                    nuevoCliente.perNombre = (String)row["PER_NOMBRE"];
                    nuevoCliente.estado = (String)row["EST_ESTADO"];
                    nuevoCliente.perTelefono = (String)(row["PER_TELEFONO"]);
                    nuevoCliente.perPrimerApellido = (String)row["PER_PRIMER_APELLIDO"];
                    nuevoCliente.perSegundoApellido = (String)row["PER_SEGUNDO_APELLIDO"];
                    nuevoCliente.direccion = (String)row["CLI_DIRECCION"];
                    nuevoCliente.credito = daoCredito.ObtenerDatosCredito(nuevoCliente.perIdentificador);
                    if (!clientesHabilitados)
                    {
                        listaClientes.Add(nuevoCliente);
                    }
                    else {
                        if (nuevoCliente.estado == "HABILITADO") {
                            listaClientes.Add(nuevoCliente);
                        }
                    }
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
            SqlCommand comando = new SqlCommand("Insert into CLIENTE (PER_IDENTIFICADOR, EST_ESTADO, PER_TELEFONO, PER_NOMBRE, PER_PRIMER_APELLIDO, PER_SEGUNDO_APELLIDO, CLI_DIRECCION) Values (@identificador,@estado,@telefono,@nombre,@primerApellido,@segundoApellido,@direccion)", conexion);
            comando.Parameters.AddWithValue("@identificador", cliente.perIdentificador);
            comando.Parameters.AddWithValue("@estado", cliente.estado); // el cliente cuando se registra siempre empieza habilitado
            comando.Parameters.AddWithValue("@telefono", cliente.perTelefono);
            comando.Parameters.AddWithValue("@nombre", cliente.perNombre);
            comando.Parameters.AddWithValue("@primerApellido", cliente.perPrimerApellido);
            comando.Parameters.AddWithValue("@segundoApellido", cliente.perSegundoApellido);
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

        public List<DO_Cliente> filtrarClientes(String filtro) {
            List<DO_Cliente> listaClientes = new List<DO_Cliente>();
            SqlCommand consulta = new SqlCommand("select * from Cliente where (PER_NOMBRE LIKE @filtro or PER_PRIMER_APELLIDO LIKE @filtro) AND (EST_ESTADO = 'HABILITADO') ", conexion);
            consulta.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
            
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
                        DO_Cliente cliente = new DO_Cliente();
                        cliente.perIdentificador = Convert.ToInt32(lector["PER_IDENTIFICADOR"]);
                        cliente.estado = (String)lector["EST_ESTADO"];
                        cliente.perTelefono = (String)(lector["PER_TELEFONO"]);
                        cliente.perNombre = (String)lector["PER_NOMBRE"];
                        cliente.perPrimerApellido = (String)lector["PER_PRIMER_APELLIDO"];
                        cliente.perSegundoApellido = (String)lector["PER_SEGUNDO_APELLIDO"];
                        cliente.direccion = (String)lector["CLI_DIRECCION"];
                        listaClientes.Add(cliente);
                    }
                    return listaClientes;
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
        public List<DO_Cliente> buscarTodosLosClientes(String filtro)
        {
            List<DO_Cliente> listaClientes = new List<DO_Cliente>();
            SqlCommand consulta = new SqlCommand("select * from Cliente where PER_NOMBRE LIKE @filtro or PER_PRIMER_APELLIDO LIKE @filtro", conexion);
            consulta.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

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
                        DO_Cliente cliente = new DO_Cliente();
                        cliente.perIdentificador = Convert.ToInt32(lector["PER_IDENTIFICADOR"]);
                        cliente.estado = (String)lector["EST_ESTADO"];
                        cliente.perTelefono = (String)(lector["PER_TELEFONO"]);
                        cliente.perNombre = (String)lector["PER_NOMBRE"];
                        cliente.perPrimerApellido = (String)lector["PER_PRIMER_APELLIDO"];
                        cliente.perSegundoApellido = (String)lector["PER_SEGUNDO_APELLIDO"];
                        cliente.direccion = (String)lector["CLI_DIRECCION"];
                        listaClientes.Add(cliente);
                    }
                    return listaClientes;
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

        public bool modificarCliente(DO_Cliente cliente) {
            SqlCommand consulta = new SqlCommand("update CLIENTE set " +
                "EST_ESTADO = @estado," +
                "PER_TELEFONO = @telefono," +  
                "PER_NOMBRE = @nombre," +
                "PER_PRIMER_APELLIDO = @primerApellido," +
                "PER_SEGUNDO_APELLIDO = @segundoApellido," +
                "CLI_DIRECCION = @direccion " +
                "where PER_IDENTIFICADOR = @idCliente", conexion);

            consulta.Parameters.AddWithValue("@estado", cliente.estado);
            consulta.Parameters.AddWithValue("@telefono", cliente.perTelefono);
            consulta.Parameters.AddWithValue("@nombre", cliente.perNombre);
            consulta.Parameters.AddWithValue("@primerApellido", cliente.perPrimerApellido);
            consulta.Parameters.AddWithValue("@segundoApellido", cliente.perSegundoApellido);
            consulta.Parameters.AddWithValue("@direccion", cliente.direccion);
            consulta.Parameters.AddWithValue("@idCliente", cliente.perIdentificador);

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
