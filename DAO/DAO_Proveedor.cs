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
                        proveedor.fechaVisita = Convert.ToDateTime(lector["PROV_FECHA_VISITA"]);
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
                if (daoAsociado.EliminarAsociado(asociado.identificador)!= true)
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
    }
}
