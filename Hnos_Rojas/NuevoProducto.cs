using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DO;

namespace Hnos_Rojas
{
    public partial class NuevoProducto : Form
    {
        BL_Producto blProducto = new BL_Producto();
        public NuevoProducto()
        {
            InitializeComponent();
            
        }

        public double CalcularPrecioVenta(int porcentaje)
        {
            return blProducto.ObtenerPrecioVenta(Convert.ToDouble( tbPrecioCosto.Text.Trim()), porcentaje);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            DO_Producto doProducto = new DO_Producto();

            doProducto.codigo = tbCodigo.Text.Trim();
            doProducto.descripcion = tbDescripcion.Text.Trim();
            doProducto.precioCosto = Convert.ToDouble(tbPrecioCosto.Text.Trim());
            doProducto.cantMinBodega = 1;
            doProducto.precioVenta = Convert.ToDouble(tbPrecioVenta.Text.Trim());

            if (cbProductoEnInventario.Checked)
            {
                doProducto.cantidadDisponible = Convert.ToInt32(tbCantidadDisponible.Text.Trim());
            }

            if (blProducto.AgregarProductoAInventario(doProducto))
            {
                MessageBox.Show("Agregado correctamente");
            } else
            {
                MessageBox.Show("No se pudo agregar");
            }
            
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            
            tbPrecioVenta.Text = CalcularPrecioVenta(Convert.ToInt32(nUDGanancia.Value)).ToString();
        }
    }
}
