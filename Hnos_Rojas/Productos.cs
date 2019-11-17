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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            llenarGridProductos();
        }

        private void llenarGridProductos() {
            BL_Producto blProducto = new BL_Producto();
            grdProductos.DataSource = blProducto.ObtenerListaDeProductos();
        }

        public void cerrarVentana() {
            this.Close();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoProd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
