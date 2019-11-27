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

        public int obtenerPagoProvDiaEspecifico(String diaInicio, String diaFinal) {
            int total = 0;

            SqlCommand comando = new SqlCommand("Select SUM (PAG_MONTO) From PAGO Where PAG_FECHA BETWEEN @diaInicio AND @diaFinal", conexion);
            comando.Parameters.AddWithValue("@diaInicio", diaInicio);
            comando.Parameters.AddWithValue("@diaFinal", diaFinal);

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
