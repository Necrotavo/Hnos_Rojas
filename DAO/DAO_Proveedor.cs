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

        public bool modificarProveedor(DO_Proveedor proveedor) {
            SqlCommand comando = new SqlCommand("update PROVEEDOR set PROV_FECHA_VISITA = @fechaVisita where PROV_NOMBRE = @nombreProveedor", conexion);
            comando.Parameters.AddWithValue("@fechaVisita", proveedor.fechaVisita);
            comando.Parameters.AddWithValue("@nombreProveedor", proveedor.nombre);

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

        public DO_Proveedor obtenerProveedor(String nombreProveedor) {
            SqlCommand consultaCredito = new SqlCommand("select * from PROVEEDOR where PROV_NOMBRE = @nombreProveedor", conexion);
            consultaCredito.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            DO_Proveedor proveedor = new DO_Proveedor();
            DAO_Asociado daoAsociado = new DAO_Asociado();
            proveedor.listaAsociados = new List<DO_Asociado>();
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                SqlDataReader lector = consultaCredito.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        proveedor.nombre = (String)(lector["PROV_NOMBRE"]);
                        proveedor.fechaVisita = (String)(lector["PROV_FECHA_VISITA"]);
                    }
                    proveedor.listaAsociados = daoAsociado.ObtenerAsociados(nombreProveedor);
                    return proveedor;
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

        public bool EliminarProveedor(DO_Proveedor proveedor)
        {
            DAO_Asociado daoAsociado = new DAO_Asociado();

            foreach(DO_Asociado asociado in proveedor.listaAsociados)
            {
                if (daoAsociado.EliminarAsociado(asociado.perIdentificador)!= true)
                {
                    return false;
                }
                
            }

            SqlCommand consulta = new SqlCommand("delete from Proveedor Where PROV_NOMBRE = @nombre", conexion);
            consulta.Parameters.AddWithValue("@nombre", proveedor.nombre);

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

        public bool pagarProveedor(DO_Pago pago) {
            SqlCommand comando = new SqlCommand("Insert into PAGO (PAG_ID, USR_NOMBRE, PROV_NOMBRE, PAG_MONTO, PAG_FECHA) " +
                "Values (@idPago, @usuario, @proveedor, @monto, @fecha)", conexion);
            comando.Parameters.AddWithValue("@idPago", pago.id);
            comando.Parameters.AddWithValue("@usuario", pago.usuario);
            comando.Parameters.AddWithValue("@proveedor", pago.proveedor);
            comando.Parameters.AddWithValue("@monto", pago.monto);
            comando.Parameters.AddWithValue("@fecha", pago.fecha);

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

        public List<DO_Proveedor> obtenerListaProveedores() {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select * from PROVEEDOR", conexion);
            DataTable datatable = new DataTable();
            List<DO_Proveedor> listaProveedores = new List<DO_Proveedor>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                adapter.Fill(datatable);

                foreach (DataRow row in datatable.Rows)
                {
                    DO_Proveedor nuevoProveedor = new DO_Proveedor();

                    nuevoProveedor.nombre = (String)(row["PROV_MONBRE"]);
                    nuevoProveedor.fechaVisita = (String)row["PROV_FECHA_VISITA"];

                    listaProveedores.Add(nuevoProveedor);
                }

                return listaProveedores;
            }
            catch (SqlException) {
                return null;
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
