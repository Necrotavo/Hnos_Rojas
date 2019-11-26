using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DAO
{
    public class DAO_Pago
    {
        SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);

        public int obtenerPagoProvDiaEspecifico(String dia) {
            int total = 0;

            SqlCommand comando = new SqlCommand("Select SUM (PAG_MONTO) From PAGO Where PAG_FECHA Like @dia", conexion);
            comando.Parameters.AddWithValue("@dia", "%" + dia + "%");

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                total = Convert.ToInt32(comando.ExecuteScalar());

                return total;

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
            return total;
        }
    }
}
