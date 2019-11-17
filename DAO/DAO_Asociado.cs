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
    public class DAO_Asociado
    {
        SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);
        
        /// <summary>
        /// Agrega un nuevo asociado a la base de datos.
        /// </summary>
        /// <param name="asociado">El asociado a ingresar</param>
        /// <returns>(True) si se agregó correctamente el asociado.(False)si no se agregó</returns>
        public bool AgregarAsociado(DO_Asociado asociado)
        {
            SqlCommand consulta = new SqlCommand("insert into Asociado (PER_IDENTIFICADOR],"+
           "PER_TELEFONO,PER_NOMBRE,PER_PRIMER_APELLIDO,PER_SEGUNDO_APELLIDO,PROV_NOMBRE)" +
           "values (@identificador,@telefono,@nombre, @primerApellido,@segundoApellido,@nombreProveedor)",conexion);
            consulta.Parameters.AddWithValue("@identificador", asociado.identificador);
            consulta.Parameters.AddWithValue("@telefono", asociado.telefono);
            consulta.Parameters.AddWithValue("@nombre", asociado.nombre);
            consulta.Parameters.AddWithValue("@primerApellido", asociado.primerApellido);
            consulta.Parameters.AddWithValue("@segundoApellido", asociado.segundoApellido);
            consulta.Parameters.AddWithValue("@nombreProveedor", asociado.nombre_Proveedor);

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
            return false;
        }
        /// <summary>
        /// Elimina un determinado asociado de acuerdo a su identificador 
        /// </summary>
        /// <param name="identificador">El identificador del asociado</param>
        /// <returns>(True) si se eliminó correctamente.(False) si no se eliminó.</returns>
        public bool EliminarAsociado(String identificador)
        {
            SqlCommand consulta = new SqlCommand("delete from Asociado Where Per_Identificador = @identificador", conexion);
            consulta.Parameters.AddWithValue("@identificador", identificador);

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
            return false;
        }
        /// <summary>
        /// Obtiene una lista de los asociados de un deterinado proveedor
        /// </summary>
        /// <param name="nombreProveedor">El proveedor al cuál se le quiere conocer sus asociados</param>
        /// <returns></returns>
        public List<DO_Asociado> EnlistarAsociadosDeProveedor(String nombreProveedor)
        {

            SqlCommand consulta = new SqlCommand("select * from Asociado where PROV_NOMBRE = @nombreProveedor", conexion);
            consulta.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);

            List<DO_Asociado> listaDeAsociados = new List<DO_Asociado>();

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
                        listaDeAsociados.Add(new DO_Asociado((String)lector["PER_IDENTIFICADOR"], (String)lector["PER_TELEFONO"], (String)lector["PER_PRIMER_APELLIDO"], (String)lector["PER_SEGUNDO_APELLIDO"], (String)lector["PER_NOMBRE"], (String)lector["PROV_NOMBRE"]));
                    }
                }
                return listaDeAsociados;

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

        public DO_Asociado BuscarAsociado(String identificador)
        {

            SqlCommand consulta = new SqlCommand("select * from Asociado where PER_IDENTIFICADOR = @identificador", conexion);
            consulta.Parameters.AddWithValue("@identificador", identificador);

            DO_Asociado asociado = new DO_Asociado();

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
                        asociado.identificador = (String)lector["PER_IDENTIFICADOR"];
                        asociado.telefono = (String)lector["PER_TELEFONO"];
                        asociado.primerApellido = (String)lector["PER_PRIMER_APELLIDO"];
                        asociado.segundoApellido  = (String)lector["PER_SEGUNDO_APELLIDO"];
                        asociado.nombre = (String)lector["PER_NOMBRE"];
                        asociado.nombre_Proveedor = (String)lector["PROV_NOMBRE"];
                    }
                }
                return asociado;

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