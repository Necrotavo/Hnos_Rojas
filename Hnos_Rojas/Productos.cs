using BL;
using DO;
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

        public void llenarGridProductos() {
            BL_Producto blProducto = new BL_Producto();
            grdProductos.DataSource = blProducto.ObtenerListaDeProductos();
            grdProductos.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            //style.Font = new Font("Microsoft Sans Serif", 14);
            //style.BackColor = Color.LightGray;

            //grdProductos.Columns[0].HeaderCell.Style = style;
            grdProductos.Columns[0].Width = 250;    //codigo

            //grdProductos.Columns[1].HeaderCell.Style = style;
            grdProductos.Columns[1].Width = 150;    //precioCosto

            //grdProductos.Columns[2].HeaderCell.Style = style;
            grdProductos.Columns[2].Width = 150;    //precioCosto

           // grdProductos.Columns[3].HeaderCell.Style = style;
            grdProductos.Columns[3].Width = 150;    //cantMinBodega

            //grdProductos.Columns[4].HeaderCell.Style = style;
            grdProductos.Columns[4].Width = 410;    //descripcion

            //grdProductos.Columns[5].HeaderCell.Style = style;
            grdProductos.Columns[5].Width = 150;    //catDisponible

            grdProductos.AutoSize = true;
        }

        public void cerrarVentana() {
            this.Close();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            buscarProd();
        }

        public void buscarProd() {
            BL_Producto blProducto = new BL_Producto();
            DO_Producto doProducto = blProducto.BuscarProducto(this.txtCodigo.Text);

        }

        private void btnNuevoProd_Click(object sender, EventArgs e)
        {

            ProductoNuevo productoNuevo = new ProductoNuevo(this);
            productoNuevo.Show();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarProducto();
        }

        public void buscarProducto() {
            BL_Producto blProducto = new BL_Producto();
            DO_Producto doProducto = blProducto.BuscarProducto(this.txtCodigo.Text);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("codigo");
            dataTable.Columns.Add("precioCosto");
            dataTable.Columns.Add("precioVenta");
            dataTable.Columns.Add("cantMinBodega");
            dataTable.Columns.Add("descripcion");
            dataTable.Columns.Add("cantidadDisponible");
            
            dataTable.Rows.Add(doProducto.codigo, doProducto.precioCosto, doProducto.precioVenta, 
                    doProducto.cantMinBodega, doProducto.descripcion, doProducto.cantidadDisponible);

            grdProductos.DataSource = dataTable;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text!="")
            {
                buscarProducto();
                txtCodigo.Focus();
            }
            else
            {
                llenarGridProductos();
            }
            
        }
    }
}
