using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO;
using BL;

namespace Hnos_Rojas
{
    public partial class Tickets : Form
    {
        public DO_Factura factura = new DO_Factura();

        //private int filaSeleccionada = -1;
        public Tickets(string usuario)
        {
            InitializeComponent();
            factura.usuario = usuario;
           // gridProductos.AllowUserToAddRows = false; sólo me deja añadir una fila
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = (DataTable)gridProductos.DataSource;
               
                if ((data.Rows.Count > 0))
                {
                    
                    confeccionarFactura();
                    PagoContado _pagoCont = new PagoContado(factura);
                    _pagoCont.Show();
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("No hay factura a pagar!!!!");
            }
            
        }

        public DO_Factura confeccionarFactura() {
            factura.listaProducto = new List<DO_ProductoEnFactura>();
            DataTable tablaProductos = (DataTable)gridProductos.DataSource;

            foreach (DataRow row in tablaProductos.Rows) {
                DO_ProductoEnFactura prodFactura = new DO_ProductoEnFactura();
                prodFactura.producto = new DO_Producto();
                prodFactura.producto.codigo = (String)row["Código"];
                prodFactura.producto.descripcion = (String)row["Descripción"];
                prodFactura.producto.precioVenta = Convert.ToInt32(row["Precio"]);
                prodFactura.producto.cantidadDisponible = Convert.ToInt32(row["Disponibles"]);

                prodFactura.cantidadComprada = Convert.ToInt32(row["Cantidad"]);

                factura.listaProducto.Add(prodFactura);
            }
            factura.fecha = DateTime.Now;

            return factura;
        }

        public void agregarProducto(DO.DO_Producto producto, int cantidad)
        {

            if (gridProductos.RowCount > 1)
            {
                actualizarGridProducto(producto, cantidad);
            }
            else {
                DataTable t = new DataTable();
                t.Columns.Add("Código");
                t.Columns.Add("Descripción");
                t.Columns.Add("Cantidad");
                t.Columns.Add("Precio");
                t.Columns.Add("Total");
                t.Columns.Add("Disponibles");
                t.Rows.Add(producto.codigo, producto.descripcion, cantidad, producto.precioVenta, producto.precioVenta * cantidad, producto.cantidadDisponible);
                gridProductos.DataSource = t;
            }
            sumarTotal();
        }

        
        private void actualizarGridProducto(DO.DO_Producto producto, int cantidad) {
            DataTable dataTable = (DataTable)gridProductos.DataSource;
            
            Boolean check = false;
          
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["Código"].ToString().Equals(producto.codigo))
                    {
                        row["Cantidad"] = Convert.ToInt32(row[2]) + cantidad;
                        row["Total"] = Convert.ToInt32(row[3]) * Convert.ToInt32(row[2]);
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    dataTable.Rows.Add(producto.codigo, producto.descripcion, cantidad, producto.precioVenta, producto.precioVenta * cantidad, producto.cantidadDisponible);
                }
            
            gridProductos.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////selecciona el producto a eliminar
            //DataTable dataTable = (DataTable)gridProductos.DataSource;
            //try
            //{
            //    DataRow fila = dataTable.Rows[filaSeleccionada];
            //    dataTable.Rows.Remove(fila);
            //    gridProductos.DataSource = dataTable;
            //    sumarTotal();
            //    filaSeleccionada = -1;
            //}
            //catch (Exception)
            //{

            //}
            //finally { }
             

        }

        //es para capturar el index de la fila seleccionada
        private void gridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (!(e.RowIndex > -1))
            //{
            //    return;
            //}

            //filaSeleccionada = e.RowIndex;
        }
        private void sumarTotal()
        {
            double total = 0;
            DataTable dataTable = (DataTable)gridProductos.DataSource;
            foreach (DataRow row in dataTable.Rows)
            {
                total += Convert.ToInt32(row["Total"]);
            }

            lblTotal.Text = "₡" + total.ToString();
        }

        private void gridProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 7) { 
             
                e.Value = Properties.Resources.minus;               

        }

        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = (DataTable)gridProductos.DataSource;
            try
            {
                if (gridProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                {
                    DataRow fila = dataTable.Rows[e.RowIndex];
                    dataTable.Rows.Remove(fila);
                    gridProductos.DataSource = dataTable;
                    sumarTotal();
                   // filaSeleccionada = -1;
                }
            }
            catch (Exception)
            {

            }
            finally { }
        }
    }
}
