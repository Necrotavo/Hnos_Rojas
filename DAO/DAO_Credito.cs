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
    public class DAO_Credito
    {
        private SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.connectionString);
        

            //SqlCommand comando = new SqlCommand("insert into CREDITO (CRED_LIMITE_CREDITO) Values (@limiteCredito)", conexion);

            
    }
    }
}
