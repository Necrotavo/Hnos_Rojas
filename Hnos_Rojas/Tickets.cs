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

        public void agregarProducto(DO.DO_Producto producto)
        {
            gridProductos.Rows.Add(new object[] { producto.codigo, producto.descripcion, 1, producto.precioVenta,"No hay calculo aun", producto.cantidadDisponible });
        }


    }
}
