﻿using System;
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
    public partial class Agregar_EditarCliente : Form
    {
        private bool modificando;
        private bool cambiosRealizados ;
        private int codigoCredito;
        public Agregar_EditarCliente()
        {
            InitializeComponent();
            llenarGridClientes();
            esconderElementos(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (validarCampos())
            {          
                agregarOmodificar();
            } else
            {
                MessageBox.Show("Datos faltantes");
            }
               
                       
        }

        public int AgregarPersona(DO_Persona nuevaPersona)
        {
            BL_Persona blPersona = new BL_Persona();

            return blPersona.registrarPersona(nuevaPersona);
        }

        public bool AgregarCliente(DO_Cliente nuevoCliente)
        {
            BL_Cliente blCliente = new BL_Cliente();

            return blCliente.registrarClienteCrediticio(nuevoCliente);
        }
        public bool ModificarCliente(DO_Cliente nuevoCliente)
        {
            BL_Cliente blCliente = new BL_Cliente();

            return blCliente.modificarCliente(nuevoCliente);
        }
        public bool ModificarCredito(DO_Cliente nuevoCliente)
        {
            BL_Credito blCredito = new BL_Credito();

            return blCredito.modificarLimite(nuevoCliente.perIdentificador,nuevoCliente.credito.limiteCredito);
        }
        public bool AgregarCredito(int identificadorCliente, int limiteCredito)
        {
            BL_Credito blCredito = new BL_Credito();

            return blCredito.CrearCredito(identificadorCliente,limiteCredito);
        }
        public void vaciarCampos()
        {
            tbNombre.Text = "";
            tbPrimerApellido.Text = "";
            tbSegundoApellido.Text = "";
            tbDireccion.Text = "";
            tbTelefono.Text = "";
            tbLimite.Text = "";
            tbEstado.Text = "";
        }

        private void tabPageModificar_Click(object sender, EventArgs e)
        {       
            vaciarCampos();
            esconderElementos(true);
        }

        private void llenarGridClientes()
        {
            BL_Cliente blCliente = new BL_Cliente();
            dgvClientes.DataSource = blCliente.obtenerListaClientesHabilitados(false,"");
            
            dgvClientes.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Microsoft Sans Serif", 14);
            style.BackColor = Color.LightGray;


            //grdClientes [1] = direccion
            //grdClientes [2] = estado
            //grdClientes [3] = credito
            //grdClientes [4] = identificador
            //grdClientes [5] = telefono
            //grdClientes [6] = nombre
            //grdClientes [7] = primerApellido
            //grdClientes [8] = segundoApellido

            //grdProductos.Columns[0].HeaderCell.Style = style;
            //dgvClientes.Columns[0].Visible = true;    //Estado

            //grdProductos.Columns[1].HeaderCell.Style = style;
            //dgvClientes.Columns[1].Visible = true;    //nombre

            //grdProductos.Columns[2].HeaderCell.Style = style;
            //dgvClientes.Columns[2].Visible = false;    //credito

            // grdProductos.Columns[3].HeaderCell.Style = style;
            //dgvClientes.Columns[3].Visible = false;    //identificador

            ////grdProductos.Columns[4].HeaderCell.Style = style;
            //dgvClientes.Columns[4].Visible = false;    //descripcion


            //dgvClientes.Columns[5].Visible = false;    //catDisponible

            dgvClientes.AutoSize = true;

            

        }
        private void Agregar_EditarCliente_Load(object sender, EventArgs e)
        {
            AlternarColores(dgvClientes);
            //destacarClientesInactivos(dgvClientes);
        }

        public void AlternarColores(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            
            
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "EstadoCliente") {
                if (e.Value.ToString() == "DESHABILITADO") {
                   // e.CellStyle.BackColor = Color.Red;
                    dgvClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL_Credito blCredito = new BL_Credito();

            tbNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["NombreCliente"].Value.ToString();
            tbPrimerApellido.Text = dgvClientes.Rows[e.RowIndex].Cells["ApellidoCliente"].Value.ToString();
            tbSegundoApellido.Text = dgvClientes.Rows[e.RowIndex].Cells["SegundoApellidoCliente"].Value.ToString();
            tbDireccion.Text = dgvClientes.Rows[e.RowIndex].Cells["DireccionCliente"].Value.ToString();
            tbTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells["TelefonoCliente"].Value.ToString();
            tbSegundoApellido.Text = dgvClientes.Rows[e.RowIndex].Cells["SegundoApellidoCliente"].Value.ToString();
            tbEstado.Text = dgvClientes.Rows[e.RowIndex].Cells["EstadoCliente"].Value.ToString();
            tbLimite.Text = blCredito.ObtenerDatosCredito(Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["IdentificadorCliente"].Value)).limiteCredito.ToString();
            codigoCredito = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["IdentificadorCliente"].Value);
            modificarClientes();
        }

        private void modificarClientes()
        {
            modificando = true;
            esconderElementos(false);
            verificarColorEstado();
            tabControlClientes.SelectedTab = tabPageAgregarCliente;
        }

        public void esconderElementos(bool esconder)
        {
            if (esconder)
            {
                tbEstado.Visible = false;
                btCambiarEstado.Visible = false;
                lblEstado.Visible = false;
            }
            else
            {
                tbEstado.Visible = true;
                btCambiarEstado.Visible = true;
                lblEstado.Visible = true;

                verificarColorEstado();
            }
        }

        private void tabPageAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void tabControlClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlClientes.SelectedTab == tabPageModificar)
            {
                modificando = false;
                vaciarCampos();            
                esconderElementos(true);

                if (cambiosRealizados)
                {
                    llenarGridClientes();
                    cambiosRealizados = false;
                }
            }
        }

        private void btCambiarEstado_Click(object sender, EventArgs e)
        {
            verificarColorEstado();
        }

        public void verificarColorEstado()
        {
            if (tbEstado.Text == "DESHABILITADO")
            {
                tbEstado.Text = "HABILITADO";
                tbEstado.BackColor = Color.LightGreen;
            }
            else
            {
                tbEstado.Text = "DESHABILITADO";
                tbEstado.BackColor = Color.Red;

            }
         
        }

        public bool validarCampos()
        {
            if (tbNombre.Text.Trim()=="" || tbTelefono.Text.Trim() == "" || tbPrimerApellido.Text.Trim() == "" || tbDireccion.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }

        public void agregarOmodificar()
        {

            DO_Cliente cliente = new DO_Cliente();

            cliente.perNombre = tbNombre.Text.Trim();
            cliente.perPrimerApellido = tbPrimerApellido.Text.Trim();
            cliente.perSegundoApellido = tbSegundoApellido.Text.Trim();
            cliente.direccion = tbDireccion.Text.Trim();
            cliente.perTelefono = tbTelefono.Text.Trim();


            if (tbEstado.Text.Trim() == "")
            {
                cliente.estado = "HABILITADO";
            }
            else
            {
                cliente.estado = tbEstado.Text.Trim();
            }         
            switch (modificando)
            {
                case false:
                    
                    cliente.perIdentificador = AgregarPersona(cliente);

                    if (AgregarCliente(cliente))
                    {
                        AgregarCredito(cliente.perIdentificador, Convert.ToInt32(tbLimite.Text.Trim()));
                        MessageBox.Show("Cliente agregado correctamente");
                        vaciarCampos();
                        cambiosRealizados = true;
                    }
                    else
                    {                      
                        MessageBox.Show("Datos incorrectos");
                    }
                    break;

                case true:
                    cliente.perIdentificador = codigoCredito;
                    cliente.credito = new DO_Credito();
                    cliente.credito.identificador = codigoCredito;
                    cliente.credito.limiteCredito = Convert.ToInt32(tbLimite.Text.Trim());
                    if (ModificarCliente(cliente)&& ModificarCredito(cliente))
                    {
                        MessageBox.Show("Cliente modificado correctamente");
                        vaciarCampos();
                        esconderElementos(true);
                        cambiosRealizados = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar los datos");
                    }

                    break;

            }
        }
    }
}
