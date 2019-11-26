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
        Ventas parent;
        //private int filaSeleccionada = -1;
        public Tickets(string usuario, Ventas padre)
        {
            InitializeComponent();
            factura.usuario = usuario;
            parent = padre;
            // gridProductos.AllowUserToAddRows = false; sólo me deja añadir una fila
            //gridProductos.Rows.Remove(gridProductos.Rows[0]);
            gridProductos.AllowUserToAddRows = false;// quita la fila en blanco
           
        }
        public void pagar()
        {
            try
            {
                DataTable data = (DataTable)gridProductos.DataSource;

                if ((data.Rows.Count > 0))
                {
                    if (rdoContado.Checked)
                    {
                        confeccionarFactura();
                        PagoContado _pagoCont = new PagoContado(factura, parent);
                        _pagoCont.Show();
                    }
                    else
                    {
                        confeccionarFactura();
                        PagoCredito _pagoCredito = new PagoCredito(factura, parent);
                        _pagoCredito.Show();
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("No hay factura a pagar!!!!");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            pagar();
        }

        public DO_Factura confeccionarFactura()
        {
           
            factura.listaProducto = new List<DO_ProductoEnFactura>();
            DataTable tablaProductos = (DataTable)gridProductos.DataSource;

            foreach (DataRow row in tablaProductos.Rows)
            {
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
            factura.totalFactura = Convert.ToInt32(lblTotal.Text.Substring(1));
            return factura;
        }

        public void agregarProducto(DO.DO_Producto producto, int cantidad)
        {
            gridProductos.AllowUserToAddRows = true;//permite que se añadan más filas
            
            if (gridProductos.RowCount > 1)
            {
                actualizarGridProducto(producto, cantidad);
            }
            else
            {
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
            gridProductos.AllowUserToAddRows = false;// quita la fila en blanco
            //gridProductos.Rows.RemoveAt(gridProductos.RowCount-1);
            sumarTotal();
        }


        private void actualizarGridProducto(DO.DO_Producto producto, int cantidad)
        {
            gridProductos.AllowUserToAddRows = true;//permite que se añadan más filas
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
            gridProductos.AllowUserToAddRows = false;//permite que se añadan más filas
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

            if (e.ColumnIndex == 7)
            {

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

        private void Tickets_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    {
                        pagar();
                        break;
                    }
            }
        }
    }
}
