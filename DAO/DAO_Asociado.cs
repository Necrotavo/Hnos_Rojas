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
            SqlCommand consulta = new SqlCommand("insert into Asociado (PER_IDENTIFICADOR,"+
           "PER_TELEFONO,PER_NOMBRE,PER_PRIMER_APELLIDO,PER_SEGUNDO_APELLIDO,PROV_NOMBRE)" +
           "values (@identificador,@telefono,@nombre, @primerApellido,@segundoApellido,@nombreProveedor)",conexion);
            consulta.Parameters.AddWithValue("@identificador", asociado.perIdentificador);
            consulta.Parameters.AddWithValue("@telefono", asociado.perTelefono);
            consulta.Parameters.AddWithValue("@nombre", asociado.perNombre);
            consulta.Parameters.AddWithValue("@primerApellido", asociado.perPrimerApellido);
            consulta.Parameters.AddWithValue("@segundoApellido", asociado.perSegundoApellido);
            consulta.Parameters.AddWithValue("@nombreProveedor", asociado.proveedor);

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
        public bool EliminarAsociado(int identificador)
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
                    DAO_Persona daoPersona = new DAO_Persona();
                    return (true && daoPersona.eliminarPersona(identificador));
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
        /// <summary>
        /// Obtiene una lista de los asociados de un deterinado proveedor
        /// </summary>
        /// <param name="nombreProveedor">El proveedor al cuál se le quiere conocer sus asociados</param>
        /// <returns></returns>
        public List<DO_Asociado> ObtenerAsociados(String nombreProveedor)
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
                        listaDeAsociados.Add(new DO_Asociado(Convert.ToInt32(lector["PER_IDENTIFICADOR"]), (String)lector["PER_TELEFONO"], (String)lector["PER_PRIMER_APELLIDO"], (String)lector["PER_SEGUNDO_APELLIDO"], (String)lector["PER_NOMBRE"], (String)lector["PROV_NOMBRE"]));
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
                        asociado.perIdentificador = Convert.ToInt32(lector["PER_IDENTIFICADOR"]);
                        asociado.perTelefono = (String)lector["PER_TELEFONO"];
                        asociado.perPrimerApellido = (String)lector["PER_PRIMER_APELLIDO"];
                        asociado.perSegundoApellido  = (String)lector["PER_SEGUNDO_APELLIDO"];
                        asociado.perNombre = (String)lector["PER_NOMBRE"];
                        asociado.proveedor = (String)lector["PROV_NOMBRE"];
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

        public bool editarAsociado(DO_Asociado asociado) {
            SqlCommand comandoEditar = new SqlCommand("update ASOCIADO set PER_NOMBRE = @nombre, PER_PRIMER_APELLIDO = @1erApellido, PER_SEGUNDO_APELLIDO = @2doApellido, PER_TELEFONO = @telefono where PER_IDENTIFICADOR = @identificador", conexion);
            comandoEditar.Parameters.AddWithValue("@identificador", asociado.perIdentificador);
            comandoEditar.Parameters.AddWithValue("@nombre",asociado.perNombre);
            comandoEditar.Parameters.AddWithValue("@1erApellido",asociado.perPrimerApellido);
            comandoEditar.Parameters.AddWithValue("@2doApellido",asociado.perSegundoApellido);
            comandoEditar.Parameters.AddWithValue("@telefono",asociado.perTelefono);
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                if (comandoEditar.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException e)
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