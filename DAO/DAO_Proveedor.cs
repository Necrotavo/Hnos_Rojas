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
                    proveedor.listaAsociados = obtenerAsociados(nombreProveedor);
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

        public List<DO_Asociado> obtenerAsociados(String nombreProveedor) {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select * from ASOCIADO where PROV_NOMBRE = @nombreProveedor", conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            DataTable datatable = new DataTable();
            List<DO_Asociado> listaAsociados = new List<DO_Asociado>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                adapter.Fill(datatable);

                foreach (DataRow row in datatable.Rows)
                {
                    DO_Asociado nuevoAsociada = new DO_Asociado();

                    nuevoAsociada.identificador = Convert.ToInt32(row["PER_IDENTIFICADOR"]);
                    nuevoAsociada.telefono = (String)row["PER_TELEFONO"];
                    nuevoAsociada.nombre = (String)row["PER_NOMBRE"];
                    nuevoAsociada.primerApellido = (String)row["PER_PRIMER_APELLIDO"];
                    nuevoAsociada.segundoApellido = (String)(row["PER_SEGUNDO_APELLIDO"]);
                    nuevoAsociada.proveedor = (String)row["PROV_NOMBRE"];

                    listaAsociados.Add(nuevoAsociada);
                }
                return listaAsociados;
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
