using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hnos_Rojas
{
    public partial class Tickets : Form
    {
        private int filaSeleccionada = -1;
        public Tickets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void agregarProducto(DO.DO_Producto producto)
        {
           
            
            
            //  gridProductos.Rows.Add(new object[] { producto.codigo, producto.descripcion, 1, producto.precioVenta,"No hay calculo aun", producto.cantidadDisponible });
            if (gridProductos.RowCount > 1)
            {
                actualizarGridProducto(producto);
            }
            else {
                DataTable t = new DataTable();
                t.Columns.Add("codigo");
                t.Columns.Add("descripcion");
                t.Columns.Add("cantidad");
                t.Columns.Add("precioVenta");
                t.Columns.Add("otros");
                t.Columns.Add("CantidadDisponible");
                t.Rows.Add(producto.codigo, producto.descripcion, 1, producto.precioVenta, "No hay calculo aun", producto.cantidadDisponible);
                gridProductos.DataSource = t;
            }
        }

        
        public void actualizarGridProducto(DO.DO_Producto producto) {
            DataTable dataTable = (DataTable)gridProductos.DataSource;
            
            Boolean check = false;
          
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["codigo"].ToString().Equals(producto.codigo))
                    {
                        row["cantidad"] = Convert.ToInt32(row[2]) + 1;
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    dataTable.Rows.Add(producto.codigo, producto.descripcion, 1, producto.precioVenta, "No hay calculo aun", producto.cantidadDisponible);
                }
            
            gridProductos.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //selecciona el producto a eliminar
            DataTable dataTable = (DataTable)gridProductos.DataSource;
            try
            {
                DataRow fila = dataTable.Rows[filaSeleccionada];
                dataTable.Rows.Remove(fila);
                gridProductos.DataSource = dataTable;
            }
            catch (Exception)
            {

            }
            finally { }
             

        }

        //es para capturar el index de la fila seleccionada
        private void gridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }

            filaSeleccionada = e.RowIndex;
        }
    }
}
