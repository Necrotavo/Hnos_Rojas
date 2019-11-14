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
                        listaUsuarios.Add(new DO_Usuario((String)lector["USR_NOMBRE"], (String)lector["TP_TIPO"], (String)lector["USR_CONTRASENA"]));
                           
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
    }
}
