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

        public int guardarFactura(DO_Factura factura) {

            factura.codigoPlantilla = obtenerCodigoUltimaPlantilla(); //Agarra la ultima plantilla ingresada

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
                    SqlCommand obtenerCodigo = new SqlCommand("Select FAC_CODIGO from FACTURA ORDER BY FAC_CODIGO DESC", conexion);
                    return Convert.ToInt32(obtenerCodigo.ExecuteScalar());
                }
                else {
                    return 0;
                }
                
            } catch (SqlException) {
                return 0;
            } finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
        }

        public bool agregarAlCredito(int idCredito, DO_Factura factura) {
            SqlCommand comando = new SqlCommand("Update FACTURA set CRE_IDENTIFICADOR = @idCredito where FAC_CODIGO = @codfactura", conexion);
            comando.Parameters.AddWithValue("@idCredito", idCredito);
            comando.Parameters.AddWithValue("@codfactura", factura.codigoFactura);

            double monto = obtenerMonto(idCredito);
            double total = monto + factura.totalFactura; 

            SqlCommand comandoCredito = new SqlCommand("Update CREDITO set CRED_MONTO = @monto where CRE_IDENTIFICADOR = @identificador", conexion);
            comandoCredito.Parameters.AddWithValue("@monto",total);
            comandoCredito.Parameters.AddWithValue("@identificador",idCredito);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                if (comando.ExecuteNonQuery() > 0 && comandoCredito.ExecuteNonQuery() > 0)
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

        public int obtenerMonto(int idCredito) {
            SqlCommand comandoMonto = new SqlCommand("Select CRED_MONTO from CREDITO where CRED_IDENTIFICADOR = @idCredito", conexion);
            comandoMonto.Parameters.AddWithValue("@idCredito",idCredito);
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                int monto = Convert.ToInt32(comandoMonto.ExecuteScalar());
                return monto;
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

        public bool modificarEstadoFactura(int codigoFactura, String estado)
        {
            SqlCommand comando = new SqlCommand("Update FACTURA set EST_ESTADO = @estado where FAC_CODIGO = @codigoFactura", conexion);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@codigoFactura", codigoFactura);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
                return true;
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

        public int ingresarPlantillaFactura(DO_PlantillaFactura plantillaFactura) {
            SqlCommand insert = new SqlCommand("insert into PLANTILLA_FACTURA " +
                "(PLANT_CODIGO, PLANT_NOMBRE_EMPRESA, PLANT_CEDULA, PLANT_TURNO, "+
                "PLANT_FOLIO, PLANT_TELEFONO, PLANT_DIRECCION" +
                "values (@codigo, @nombreEmpresa, @cedula, @turno, @folio, @telefono, @direccion)", conexion);

            insert.Parameters.AddWithValue("@codigo", plantillaFactura.codigo);
            insert.Parameters.AddWithValue("@nombreEmpresa", plantillaFactura.nombreEmpresa);
            insert.Parameters.AddWithValue("@cedula", plantillaFactura.cedula);
            insert.Parameters.AddWithValue("@turno", plantillaFactura.turno);
            insert.Parameters.AddWithValue("@folio", plantillaFactura.folio);
            insert.Parameters.AddWithValue("@telefono", plantillaFactura.numeroTelefono);
            insert.Parameters.AddWithValue("@direccion", plantillaFactura.direccion);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                if (insert.ExecuteNonQuery() > 0)
                {
                    return obtenerCodigoUltimaPlantilla();
                }
                else
                {
                    return 0;
                }

            }
            catch (SqlException)
            {
                return 0;
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
        }

        public int obtenerCodigoUltimaPlantilla() {
            SqlCommand obtenerCodigo = new SqlCommand("Select PLANT_CODIGO from PLANTILLA_FACTURA ORDER BY PLANT_CODIGO DESC", conexion);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                int codigo = Convert.ToInt32(obtenerCodigo.ExecuteScalar());
                if (codigo > 0)
                {
                    return codigo;
                }
                else
                {
                    return 0;
                }

            }
            catch (SqlException)
            {
                return 0;
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
        }

        public DO_PlantillaFactura obtenerUltimaPlantilla() {
            int codigo = obtenerCodigoUltimaPlantilla();
            SqlCommand consulta = new SqlCommand("select * from PLANTILLA_FACTURA where PLANT_CODIGO = @codigo", conexion);
            consulta.Parameters.AddWithValue("@codigo", codigo);
            DO_PlantillaFactura plantillaFactura = new DO_PlantillaFactura();
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
                        plantillaFactura.codigo = Convert.ToInt32(lector["PLANT_CODIGO"]);
                        plantillaFactura.nombreEmpresa = (String)lector["PLANT_NOMBRE_EMPRESA"];
                        plantillaFactura.cedula = (String)(lector["PLANT_CEDULA"]);
                        plantillaFactura.turno = Convert.ToInt32(lector["PLANT_TURNO"]);
                        plantillaFactura.folio = Convert.ToInt32(lector["PLANT_FOLIO"]);
                        plantillaFactura.numeroTelefono = (String)lector["PLANT_TELEFONO"];
                        plantillaFactura.direccion = (String)lector["PLANT_DIRECCION"];
                    }
                    return plantillaFactura;
                }
            }
            catch (SqlException)
            {
                return null;
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