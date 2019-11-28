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
   
    public partial class Agregar_ModificarProveedor : Form
    {
        Proveedor padre;
        private DO_Proveedor proveedor;
        private bool editable;
   
        public Agregar_ModificarProveedor(Proveedor _padre)
        {
            InitializeComponent();
            padre = _padre;
            lblTitulo.Text = "Nuevo Proveedor";
            llenarCboDias();
            editable = false;

        }

        public Agregar_ModificarProveedor(String nombreProveedor, Proveedor _padre)
        {
            InitializeComponent();
            padre = _padre;
            lblTitulo.Text = "Editar Proveedor";
            txtNombreProveedor.Enabled = false;
            llenarCboDias();
            rellenarFormulario(nombreProveedor);
            editable = true;
        }

        private void rellenarFormulario(String nombreProveedor) {
            BL_Proveedor blProveedor = new BL_Proveedor();
            proveedor = blProveedor.obtenerProveedor(nombreProveedor);
            txtNombreProveedor.Text = proveedor.nombre;
            DO_ProveedorParaHorario provHorario = blProveedor.obtenerProveedorHorario(nombreProveedor);
            //falta llenar el combo box de días, datePicker y radioButton
            foreach (String horario in provHorario.listaDiaYhora) {
                lbDiasDeVisita.Items.Add(horario);
            } 
            rellenarControlesDiaVisita();
        }

        private void rellenarControlesDiaVisita() {
            
        }

        public String obtenerIndiceDia(String dia)
        {
            if (dia == "L")
            {
                return "L";
            }
            else if (dia == "K")
            {
                return "K";
            }
            else if (dia == "M")
            {
                return "M";
            }
            else if (dia == "J")
            {
                return "J";
            }
            else if (dia == "V")
            {
                return "V";
            }
            else if (dia == "S")
            {
                return "S";
            }
            else if (dia == "D")
            {
                return "D";
            }
            else
            {
                return "";
            }
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            BL_Proveedor blProveedor = new BL_Proveedor();
            if (proveedor != null)
            {
                // modificar
                if (validarFormulario())
                {
                    proveedor.fechaVisita = todosLosDias();
                    //falta validar que todo esté seleccionado
                    if (blProveedor.modificarProveedor(proveedor))
                    {
                        MessageBox.Show("Proveedor modificado");
                    }
                    else {
                        MessageBox.Show("error al modificar datos del proveedor");
                    }
                    txtNombreProveedor.Enabled = true;

                }
            }
            else {
                // agregar
               
                if (validarFormulario()) {
                    DO_Proveedor proveedor = new DO_Proveedor();
                    proveedor.nombre = txtNombreProveedor.Text.Trim();
                    proveedor.fechaVisita = todosLosDias();
                    if (blProveedor.ingresarProveedor(proveedor))
                    {
                        MessageBox.Show("Proveedor ingresado");
                        limpiarFormulario();
                    }
                    else {
                        MessageBox.Show("error al ingresar el proveedor");
                    }
                }

            }
        }

        private bool validarFormulario() {
            if (txtNombreProveedor.Text.Trim().Equals("")) {
                return false;
            }
            return true;
        }

        private void limpiarFormulario() {
            txtNombreProveedor.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            padre.invocarListaProveedores();
        }

        private void Agregar_ModificarProveedor_Load(object sender, EventArgs e)
        {
            
        }


        private void llenarCboDias() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("DIA");
            dataTable.Columns.Add("SIGLA");
            String[] dias = {"LUNES","MARTES","MIÉRCOLES","JUEVES","VIERNES","SÁBADO","DOMINGO"};
            String[] siglas = { "L", "K", "M", "J", "V", "S", "D" };
            for (int i = 0; i < dias.Length ; i++) {
                dataTable.Rows.Add(dias[i],siglas[i]);
            }
            cboDias.DataSource = dataTable;
            cboDias.DisplayMember = "DIA";
            cboDias.ValueMember = "SIGLA";

        }

        private void btnDiaVisita_Click(object sender, EventArgs e)
        {
            
            String dia = "";
            dia = cboDias.SelectedValue.ToString() + "-" + cboHoras.Text;
            if (!lbDiasDeVisita.Items.Contains(dia))
            {
                lbDiasDeVisita.Items.Add(dia);
            }
            //lbDiasDeVisita.DataSource = listaVisita;

        }

        private String todosLosDias() {
            String dias = "";
            for (int i = 0; i < lbDiasDeVisita.Items.Count; i ++) {
                dias += lbDiasDeVisita.Items[i].ToString()+",";
            }
            dias = dias.TrimEnd(',');
            MessageBox.Show(dias);
            return dias;
        }

        private void lbDiasDeVisita_Click(object sender, EventArgs e)
        {
            //rellenar el combo Box y el datePicker
        }

        private void btnEliminarDia_Click(object sender, EventArgs e)
        {
            lbDiasDeVisita.Items.RemoveAt(lbDiasDeVisita.SelectedIndex);
        }
    }
}
