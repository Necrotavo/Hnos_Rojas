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

            SqlCommand insert = new SqlCommand("insert into FACTURA (FAC_CODIGO, FAC_NOTAS, FAC_CLIENTE_EXTERNO, FAC_FECHA,+"
               +" PLANT_CODIGO, USR_NOMBRE, CRE_IDENTIFICADOR, EST_ESTADO, TP_TIPO) values"+
               "(@codigo, @notas, @cliente, @fecha, @plantilla, @usrNombre, @credito, @estado, @tipo)", conexion);
            insert.Parameters.AddWithValue("@codigo", factura.codigoFactura);
            insert.Parameters.AddWithValue("@notas", factura.notas);
            insert.Parameters.AddWithValue("@cliente", factura.clienteExterno);
            insert.Parameters.AddWithValue("@fecha", factura.fecha);
            insert.Parameters.AddWithValue("@plantilla", factura.codigoPlantilla);
            insert.Parameters.AddWithValue("@usrNombre", factura.usuario);
            insert.Parameters.AddWithValue("@credito", factura.credito);
            insert.Parameters.AddWithValue("@estado", factura.estado);
            insert.Parameters.AddWithValue("@tipo", factura.tipoPago);
            
            try {
                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                if (insert.ExecuteNonQuery() > 0)
                {
                    SqlCommand obtenerCodigo = new SqlCommand("Select FAC_CODIGO from FACTURA ORDER BY FAC_CODIGO [DESC]", conexion);
                    return true;
                }
                else {
                    return false;
                }
                
            } catch (SqlException) {
            } finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }

            return false;
        }

        public bool agregarAlCredito(int idCredito, int codfactura) {
            SqlCommand comando = new SqlCommand("Update FACTURA set CRE_IDENTIFICADOR = @idCredito where FAC_CODIGO = @codfactura", conexion);
            comando.Parameters.AddWithValue("@idCredito", idCredito);
            comando.Parameters.AddWithValue("@codfactura", codfactura);

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
    }
}