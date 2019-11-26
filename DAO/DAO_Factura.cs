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

            SqlCommand insert = new SqlCommand("insert into FACTURA (FAC_NOTAS, FAC_CLIENTE_EXTERNO, FAC_FECHA,"
               +" PLANT_CODIGO, USR_NOMBRE, EST_ESTADO, TP_TIPO, FAC_MONTO, FAC_SALDO) values"+
               "(@notas, @cliente, @fecha, @plantilla, @usrNombre, @estado, @tipo, @monto, @saldo)", conexion);
            insert.Parameters.AddWithValue("@notas", factura.notas);
            insert.Parameters.AddWithValue("@cliente", factura.clienteExterno);
            insert.Parameters.AddWithValue("@fecha", factura.fecha);
            insert.Parameters.AddWithValue("@plantilla", factura.codigoPlantilla);
            insert.Parameters.AddWithValue("@usrNombre", factura.usuario);
            insert.Parameters.AddWithValue("@estado", factura.estado);
            insert.Parameters.AddWithValue("@tipo", factura.tipoPago);
            insert.Parameters.AddWithValue("@monto", factura.totalFactura);
            insert.Parameters.AddWithValue("@saldo", factura.saldo);

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
                
            } catch (SqlException e) {
                return 0;
            } finally {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        public bool agregarAlCredito(int idCredito, DO_Factura factura) {
            SqlCommand comando = new SqlCommand("Update FACTURA set CRE_IDENTIFICADOR = @idCredito where FAC_CODIGO = @codfactura", conexion);
            comando.Parameters.AddWithValue("@idCredito", idCredito);
            comando.Parameters.AddWithValue("@codfactura", factura.codigoFactura);

            DAO_Credito daoCredito = new DAO_Credito();

            double monto = daoCredito.obtenerMonto(idCredito);
            double total = monto + factura.saldo; 

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

        public bool actualizarPlantillaFactura(DO_PlantillaFactura plantillaFactura)
        {
            SqlCommand update = new SqlCommand("UPDATE PLANTILLA_FACTURA " +
                "SET PLANT_NOMBRE_EMPRESA = @nombreEmpresa," +
                " PLANT_CEDULA = @cedula," +
                " PLANT_DIRECCION = @direccion," +
                " PLANT_TELEFONO = @telefono " +
                "WHERE PLANT_CODIGO = @codigo", conexion);

            update.Parameters.AddWithValue("@cedula", plantillaFactura.cedula);
            update.Parameters.AddWithValue("@direccion", plantillaFactura.direccion);
            update.Parameters.AddWithValue("@telefono", plantillaFactura.numeroTelefono);
            update.Parameters.AddWithValue("@codigo", plantillaFactura.codigo);
            update.Parameters.AddWithValue("@nombreEmpresa", plantillaFactura.nombreEmpresa);

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                update.ExecuteNonQuery();
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
                    conexion.Close();
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
                    conexion.Close();
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

        public bool actualizarSaldoFactura(DO_Factura factura, double abono) {
            try
            {
                factura.saldo = factura.saldo - abono;
                SqlCommand actualizarSaldo = new SqlCommand("update FACTURA set FAC_SALDO = @saldo WHERE FAC_CODIGO = @codigo", conexion);
                if (factura.saldo <= 0)
                {
                    actualizarSaldo.Parameters.AddWithValue("@saldo", 0);
                    modificarEstadoFactura(factura.codigoFactura, "PAGADA");
                }
                else
                {
                    actualizarSaldo.Parameters.AddWithValue("@saldo", factura.saldo);
                }
                actualizarSaldo.Parameters.AddWithValue("@codigo", factura.codigoFactura);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                if (actualizarSaldo.ExecuteNonQuery() > 0) {
                    DAO_Credito daoCredito = new DAO_Credito();
                    daoCredito.actualizarMontoCredito(factura.credito);
                    return true;
                }
                else
                {
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

        public List<DO_Factura> obtenerFacturasCredito(int idCliente)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select * from FACTURA where CRE_IDENTIFICADOR = @idCliente and EST_ESTADO = 'PENDIENTE' ORDER BY FAC_FECHA", conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@idCliente", idCliente);
            DataTable datatable = new DataTable();
            List<DO_Factura> listaFacturas = new List<DO_Factura>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                adapter.Fill(datatable);

                foreach (DataRow row in datatable.Rows)
                {
                    DO_Factura nuevaFactura = new DO_Factura();

                    nuevaFactura.codigoFactura = Convert.ToInt32(row["FAC_CODIGO"]);
                    nuevaFactura.notas = (String)row["FAC_NOTAS"];
                    nuevaFactura.clienteExterno = (String)row["FAC_CLIENTE_EXTERNO"];
                    nuevaFactura.fecha = (DateTime)row["FAC_FECHA"];
                    nuevaFactura.codigoPlantilla = Convert.ToInt32(row["PLANT_CODIGO"]);
                    nuevaFactura.usuario = (String)row["USR_NOMBRE"];
                    nuevaFactura.credito = Convert.ToInt32(row["CRE_IDENTIFICADOR"]);
                    nuevaFactura.estado = (String)row["EST_ESTADO"];
                    nuevaFactura.tipoPago = (String)row["TP_TIPO"];
                    nuevaFactura.totalFactura = Convert.ToDouble(row["FAC_MONTO"]);
                    nuevaFactura.saldo = Convert.ToDouble(row["FAC_SALDO"]);

                    DAO_Producto daoProducto = new DAO_Producto();
                    nuevaFactura.listaProducto = daoProducto.obtenerProductosFactura(Convert.ToInt32(row["FAC_CODIGO"]));

                    listaFacturas.Add(nuevaFactura);
                }
                return listaFacturas;
            }
            catch (SqlException) { }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }

        public List<DO_Factura> obtenerFacturasCredito(int idCliente, DateTime desde, DateTime hasta)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select * from FACTURA "+
                "where CRE_IDENTIFICADOR = @idCliente "+
                "and FAC_FECHA >= @desde and FAC_FECHA < @hasta " +
                "ORDER BY FAC_FECHA ", conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@idCliente", idCliente);
            adapter.SelectCommand.Parameters.AddWithValue("@desde", desde);
            adapter.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
            DataTable datatable = new DataTable();
            List<DO_Factura> listaFacturas = new List<DO_Factura>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                adapter.Fill(datatable);

                foreach (DataRow row in datatable.Rows)
                {
                    DO_Factura nuevaFactura = new DO_Factura();

                    nuevaFactura.codigoFactura = Convert.ToInt32(row["FAC_CODIGO"]);
                    nuevaFactura.notas = (String)row["FAC_NOTAS"];
                    nuevaFactura.clienteExterno = (String)row["FAC_CLIENTE_EXTERNO"];
                    nuevaFactura.fecha = (DateTime)row["FAC_FECHA"];
                    nuevaFactura.codigoPlantilla = Convert.ToInt32(row["PLANT_CODIGO"]);
                    nuevaFactura.usuario = (String)row["USR_NOMBRE"];
                    nuevaFactura.credito = Convert.ToInt32(row["CRE_IDENTIFICADOR"]);
                    nuevaFactura.estado = (String)row["EST_ESTADO"];
                    nuevaFactura.tipoPago = (String)row["TP_TIPO"];
                    nuevaFactura.totalFactura = Convert.ToDouble(row["FAC_MONTO"]);
                    nuevaFactura.saldo = Convert.ToDouble(row["FAC_SALDO"]);

                    DAO_Producto daoProducto = new DAO_Producto();
                    nuevaFactura.listaProducto = daoProducto.obtenerProductosFactura(Convert.ToInt32(row["FAC_CODIGO"]));

                    listaFacturas.Add(nuevaFactura);
                }
                return listaFacturas;
            }
            catch (SqlException) { }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return null;
        }

        public int obtenerTotalVentasEfectivoDiaEspecifico(String dia) {
            int total = 0;

            SqlCommand comando = new SqlCommand("Select SUM (FAC_MONTO) from FACTURA Where FAC_FECHA LIKE @dia AND EST_ESTADO = @estado AND TP_TIPO = @tipo", conexion);
            comando.Parameters.AddWithValue("@dia", "%" + dia + "%");
            comando.Parameters.AddWithValue("@estado", "PAGADA");
            comando.Parameters.AddWithValue("@tipo", "CONTADO");

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