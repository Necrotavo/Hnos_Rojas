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
        bool modificando;
        public NuevoProducto()
        {
            InitializeComponent();
            llenarGridBucarProductos();
            
        }

        public double CalcularPrecioVenta(int porcentaje)
        {
            return blProducto.ObtenerPrecioVenta(Convert.ToDouble(tbPrecioCosto.Text.Trim()), porcentaje);
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

            if (modificando)
            {
                

                if (blProducto.ModificarProducto(doProducto))
                {
                    MessageBox.Show("Modificado correctamente");
                    llenarGridBucarProductos();
                    vaciarCampos();
                    tbCodigo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se pudo modificar");
                }

            }
            else
            {
                if (blProducto.AgregarProductoAInventario(doProducto))
                {
                    
                    MessageBox.Show("Agregado correctamente");
                    llenarGridBucarProductos();
                    vaciarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar");
                }
            }

            
            
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            
            tbPrecioVenta.Text = CalcularPrecioVenta(Convert.ToInt32(nUDGanancia.Value)).ToString();
        }

        private void tpModificar_Click(object sender, EventArgs e)
        {
            modificando = false;
            vaciarCampos();
        }

        public void AlternarColores (DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void llenarGridBucarProductos()
        {
            BL_Producto blProducto = new BL_Producto();
            dgvProductos.DataSource = blProducto.ObtenerListaDeProductos();
            dgvProductos.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            //style.Font = new Font("Microsoft Sans Serif", 14);
            //style.BackColor = Color.LightGray;

            //grdProductos.Columns[0].HeaderCell.Style = style;
            dgvProductos.Columns[0].Width = 250;    //codigo

            //grdProductos.Columns[1].HeaderCell.Style = style;
            dgvProductos.Columns[1].Width = 150;    //precioCosto

            //grdProductos.Columns[2].HeaderCell.Style = style;
            dgvProductos.Columns[2].Width = 150;    //precioCosto

            // grdProductos.Columns[3].HeaderCell.Style = style;
            dgvProductos.Columns[3].Width = 150;    //cantMinBodega

            //grdProductos.Columns[4].HeaderCell.Style = style;
            dgvProductos.Columns[4].Width = 410;    //descripcion

            //grdProductos.Columns[5].HeaderCell.Style = style;
            dgvProductos.Columns[5].Width = 150;    //catDisponible

            dgvProductos.AutoSize = true;
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            AlternarColores(dgvProductos);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbCodigo.Text = dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbPrecioCosto.Text = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPrecioVenta.Text = dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString();      
            tbCantidadDisponible.Text = dgvProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
            nUDGanancia.Value = blProducto.CalcularPorcentajeGanancia(Convert.ToDouble(tbPrecioCosto.Text.Trim()), Convert.ToDouble(tbPrecioVenta.Text.Trim()));
            modificarDatosProducto();
        }

        public void modificarDatosProducto()
        {
            modificando = true;
            tbCodigo.Enabled = false;
            tabControlProducto.SelectedTab = tpFormulario;
        }

        public void vaciarCampos()
        {
            tbCodigo.Text = "";
            tbDescripcion.Text = "";
            tbPrecioCosto.Text = "";
            tbPrecioVenta.Text = "";
            tbCantidadDisponible.Text = "";
            nUDGanancia.Value = 15;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            buscarProducto();
        }
        public void buscarProducto()
        {
            BL_Producto blProducto = new BL_Producto();
            List<DO_Producto> listaProductos = blProducto.BuscarListaProducto(this.tbBuscarCodigo.Text.Trim());

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("codigo");
            dataTable.Columns.Add("precioCosto");
            dataTable.Columns.Add("precioVenta");
            dataTable.Columns.Add("cantMinBodega");
            dataTable.Columns.Add("descripcion");
            dataTable.Columns.Add("cantidadDisponible");

            foreach (DO_Producto productoEncontado in listaProductos)
            {
                dataTable.Rows.Add(productoEncontado.codigo, productoEncontado.precioCosto, productoEncontado.precioVenta,
                    productoEncontado.cantMinBodega, productoEncontado.descripcion, productoEncontado.cantidadDisponible);
            }
            dgvProductos.DataSource = dataTable;
        }

        private void tabControlProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlProducto.SelectedTab == tpModificar)
            {
                vaciarCampos();
                tbCodigo.Enabled = true;
                modificando = false;
            }
        }
    }
}
