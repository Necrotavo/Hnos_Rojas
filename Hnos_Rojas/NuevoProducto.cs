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
            this.ActiveControl = tbCodigo;
            InitializeComponent();
            llenarGridBucarProductos();
            ActiveControl = tbCodigo;

        }

        public double CalcularPrecioVenta(int porcentaje)
        {
            return blProducto.ObtenerPrecioVenta(Convert.ToDouble(tbPrecioCosto.Text.Trim()), porcentaje);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                AgregarProducto();
            }
            else
            {
                MensajeError mensajeError = new MensajeError("FALTAN DATOS POR COMPLETAR");
                mensajeError.Show();
                //MessageBox.Show("Faltan datos de completar");
            }

        }

        public void AgregarProducto()
        {
            DO_Producto doProducto = new DO_Producto();

            doProducto.codigo = tbCodigo.Text.Trim();
            doProducto.descripcion = tbDescripcion.Text.Trim();
            doProducto.precioCosto = Convert.ToDouble(tbPrecioCosto.Text.Trim());
            doProducto.cantMinBodega = 1;
            doProducto.precioVenta = Convert.ToDouble(tbPrecioVenta.Text.Trim());


            doProducto.cantidadDisponible = Convert.ToInt32(tbCantidadDisponible.Text.Trim());


            if (modificando)
            {


                if (blProducto.ModificarProducto(doProducto))
                {
                    MensajeExito mensajeExito = new MensajeExito("MODIFICADO CORRECTAMENTE");
                    mensajeExito.Show();
                    //MessageBox.Show("Modificado correctamente");
                    llenarGridBucarProductos();
                    vaciarCampos();
                    tbCodigo.Enabled = true;
                }
                else
                {
                    MensajeError mensajeError = new MensajeError("NO SE PUDO MODIFICAR");
                    mensajeError.Show();
                    //MessageBox.Show("No se pudo modificar");
                }

            }
            else
            {
                if (blProducto.AgregarProductoAInventario(doProducto))
                {
                    MensajeExito mensajeExito = new MensajeExito("AGREGADO CORRECTAMENTE");
                    mensajeExito.Show();
                    //MessageBox.Show("Agregado correctamente");
                    llenarGridBucarProductos();
                    vaciarCampos();
                    this.ActiveControl = tbCodigo;
                }
                else
                {
                    MensajeError mensajeError = new MensajeError("NO SE PUDO AGREGAR");
                    mensajeError.Show();
                    //MessageBox.Show("No se pudo agregar");
                }
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (!tbPrecioCosto.Text.Trim().Equals(""))
            {
                tbPrecioVenta.Text = CalcularPrecioVenta(Convert.ToInt32(nUDGanancia.Value)).ToString();

            } else
            {
                tbPrecioVenta.Text = "0";
            }
        }

        private void tpModificar_Click(object sender, EventArgs e)
        {
            modificando = false;
            vaciarCampos();
        }

        public void AlternarColores(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void llenarGridBucarProductos()
        {
            BL_Producto blProducto = new BL_Producto();
            dgvProductos.DataSource = blProducto.ObtenerListaDeProductos();
            dgvProductos.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            //style.Font = new Font("Microsoft Sans Serif", 14);
            //style.BackColor = Color.LightGray;

            //grdProductos.Columns[0].HeaderCell.Style = style;
            dgvProductos.Columns["Modificar"].Width = 90;    //codigo

            //grdProductos.Columns[1].HeaderCell.Style = style;
            dgvProductos.Columns[1].Width = 150;    //precioCosto

            //grdProductos.Columns[2].HeaderCell.Style = style;
            dgvProductos.Columns[2].Width = 150;    //precioCosto

            // grdProductos.Columns[3].HeaderCell.Style = style;
            dgvProductos.Columns[3].Width = 150;    //cantMinBodega

            //grdProductos.Columns[4].HeaderCell.Style = style;
            dgvProductos.Columns["CantidadDisponible"].Width = 100;    //descripcion

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
            if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                tbCodigo.Text = dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbPrecioCosto.Text = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbPrecioVenta.Text = dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbCantidadDisponible.Text = dgvProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
                nUDGanancia.Value = blProducto.CalcularPorcentajeGanancia(Convert.ToDouble(tbPrecioCosto.Text.Trim()), Convert.ToDouble(tbPrecioVenta.Text.Trim()));
                modificarDatosProducto();
            }
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
            tbBuscarCodigo.Focus();
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
                this.ActiveControl = tbBuscarCodigo;
            }
            else
            {
                this.ActiveControl = tbCodigo;
            }
        }

        private void tbPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirEntradaNumeros(e);
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //} else
            //{
            //    e.Handled = true;
            //}
        }

        private void tbPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirEntradaNumeros(e);
        }

        private void tbCantidadDisponible_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirEntradaNumeros(e);
        }

        public void permitirEntradaNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            RecibirCodigo(e);
        }

        private bool verificarCampos()
        {
            if (tbCodigo.Text.Trim().Equals("") || tbDescripcion.Text.Trim().Equals("") || tbPrecioCosto.Text.Trim().Equals("")
                || tbPrecioVenta.Text.Trim().Equals("") || tbCantidadDisponible.Text.Trim().Equals(""))
            {
                return false;
            }

            return true;
        }

        private void tbBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.ActiveControl = dgvProductos;
                buscarProducto();
                tbBuscarCodigo.Focus();
                //tbBuscarCodigo.Clear();
            }
        }

        public void RecibirCodigo(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.ActiveControl = tbDescripcion;
            }
        }
    }
}
