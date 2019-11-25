using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DO;

namespace DAO
{
    public class DAO_Usuario
    {
        SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);

        public bool crearUsuario(string nombre, string clave)
        {
            SqlCommand crearUsuario = new SqlCommand("INSERT INTO USUARIO (USR_NOMBRE, USR_CONTRASENA) " +
                "VALUES (@nombre, @clave)", conexion);
            crearUsuario.Parameters.AddWithValue("@nombre", nombre);
            crearUsuario.Parameters.AddWithValue("@clave", clave);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                crearUsuario.ExecuteNonQuery();
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


        public bool actualizarUsuario(string usuario, string clave)
        {
            SqlCommand actualizar = new SqlCommand("UPDATE USUARIO SET USR_CONTRASENA = @clave WHERE USR_NOMBRE = @nombre",conexion);

            actualizar.Parameters.AddWithValue("@nombre", usuario);
            actualizar.Parameters.AddWithValue("@clave", clave);
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                actualizar.ExecuteNonQuery();
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

        /// <summary>
        /// Carga los usuarios registrados en el sistema
        /// </summary>
        /// <returns>Lista con los usuarios registrados (List<DO_Usuario>)</returns>
        public List<DO_Usuario> CargarUsuarios()
        {
            SqlCommand consulta = new SqlCommand("select * from Usuario", conexion);


            List<DO_Usuario> listaUsuarios = new List<DO_Usuario>();

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
                        listaUsuarios.Add(new DO_Usuario((String)lector["USR_NOMBRE"], (String)lector["USR_CONTRASENA"]));
                           
                    }
                }
                return listaUsuarios;

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

        public DO_Usuario iniciarSesion(String usuario, String contrasena) {
            SqlCommand consulta = new SqlCommand("select * from USUARIO where USR_NOMBRE = @nombre and USR_CONTRASENA = @contrasena", conexion);
            consulta.Parameters.AddWithValue("@nombre",usuario);
            consulta.Parameters.AddWithValue("@contrasena", contrasena);
            try {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                SqlDataReader lector = consulta.ExecuteReader();
                DO_Usuario nuevoUsuario = new DO_Usuario();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                       nuevoUsuario = new DO_Usuario((String)lector["USR_NOMBRE"], (String)lector["USR_CONTRASENA"]);

                    }
                    return nuevoUsuario;
                }

            } catch (SqlException) {
            } finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }
    }
}
