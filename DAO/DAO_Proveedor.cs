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
    public class DAO_Proveedor
    {
        SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);
        public bool ingresarProveedor (DO_Proveedor proveedor){
            SqlCommand comando = new SqlCommand("Insert into PROVEEDOR (PROV_NOMBRE, PROV_FECHA_VISITA) Values (@nombreProveedor, @fechaVisita)", conexion);
            comando.Parameters.AddWithValue("@nombreProveedor", proveedor.nombre);
            comando.Parameters.AddWithValue("@fechaVisita", proveedor.fechaVisita);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else {
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
        }


    }
}
