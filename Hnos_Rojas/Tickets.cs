﻿using System;
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
        public Tickets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void agregarProducto(DO.DO_Producto producto, int cantidad)
        {
           
            
            
            //  gridProductos.Rows.Add(new object[] { producto.codigo, producto.descripcion, 1, producto.precioVenta,"No hay calculo aun", producto.cantidadDisponible });
            if (gridProductos.RowCount > 1)
            {
                actualizarGridProducto(producto, cantidad);
            }
            else {
                DataTable t = new DataTable();
                t.Columns.Add("Codigo");
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
                    if (row["Codigo"].ToString().Equals(producto.codigo))
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

    }
}
