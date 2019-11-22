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
    public partial class ProductoNuevo : Form
    {
        public ProductoNuevo()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            BL_Producto blProducto = new BL_Producto();
            try
            {
                DO_Producto doProducto = new DO_Producto(
               txtCod.Text,
               Convert.ToDouble(txtPCost.Text),
               Convert.ToDouble(txtPVent.Text),
               Convert.ToInt32(txtCantMin.Text),
               txtDescr.Text,
               Convert.ToInt32(txtCant.Text)
               );
                blProducto.AgregarProductoAInventario(doProducto);
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
           
        }
    }
}
