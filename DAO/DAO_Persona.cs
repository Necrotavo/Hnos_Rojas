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
    public class DAO_Persona
    {
        private SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);

        public int registrarPersona(DO_Persona persona)
        {
            SqlCommand comando = new SqlCommand("Insert into PERSONA (PER_TELEFONO, PER_NOMBRE, PER_PRIMER_APELLIDO, PER_SEGUNDO_APELLIDO) Values (@perTelefono,@perNombre,@perPrimerApellido,@perSegundoApellido)", conexion);
            comando.Parameters.AddWithValue("@perTelefono", persona.perTelefono);
            comando.Parameters.AddWithValue("@perNombre", persona.perNombre);
            comando.Parameters.AddWithValue("@perPrimerApellido", persona.perPrimerApellido);
            comando.Parameters.AddWithValue("@perSegundoApellido", persona.perSegundoApellido);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                if (comando.ExecuteNonQuery() > 0)
                {
                    SqlCommand obtenerIdentificador = new SqlCommand("Select PER_IDENTIFICADOR from PERSONA ORDER BY PER_IDENTIFICADOR DESC", conexion);
                    return Convert.ToInt32(obtenerIdentificador.ExecuteScalar());
                }
                else {
                    return 0;
                }

            }
            catch (SqlException e)
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
