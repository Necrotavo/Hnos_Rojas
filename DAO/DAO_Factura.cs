using DO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class DAO_Factura
    {
        private SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);

        public bool guardarFactura(DO_Factura factura) {

            SqlCommand insert = new SqlCommand("insert into FACTURA (FAC_CODIGO, FAC_NOTAS, FAC_CLIENTE, FAC_FECHA,+"
               +" PLANT_CODIGO, USR_NOMBRE, CRE_IDENTIFICADOR, EST_ESTADO, TP_TIPO) values"+
               "(@codigo, @notas, @cliente, @fecha, @usrNombre, @credito, @estado, @tipo)", conexion);
            //falta agregar los paramemtros
            try {
                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }
                insert.ExecuteNonQuery();
                return true;
            } catch (SqlException) {
            } finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }

            return false;
        }

    }
}
