﻿namespace Hnos_Rojas
{
    partial class Agregar_EditarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_EditarCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPageAgregarCliente = new System.Windows.Forms.TabPage();
            this.btCambiarEstado = new System.Windows.Forms.Button();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbLimite = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbSegundoApellido = new System.Windows.Forms.TextBox();
            this.tbPrimerApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPageModificar = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificadorCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.tbNombreOApellido = new System.Windows.Forms.TextBox();
            this.tabControlClientes.SuspendLayout();
            this.tabPageAgregarCliente.SuspendLayout();
            this.tabPageModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPageAgregarCliente);
            this.tabControlClientes.Controls.Add(this.tabPageModificar);
            this.tabControlClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlClientes.Font = new System.Drawing.Font("Segoe UI Historic", 25F);
            this.tabControlClientes.Location = new System.Drawing.Point(0, 0);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(826, 536);
            this.tabControlClientes.TabIndex = 0;
            this.tabControlClientes.SelectedIndexChanged += new System.EventHandler(this.tabControlClientes_SelectedIndexChanged);
            // 
            // tabPageAgregarCliente
            // 
            this.tabPageAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.tabPageAgregarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageAgregarCliente.Controls.Add(this.btCambiarEstado);
            this.tabPageAgregarCliente.Controls.Add(this.tbEstado);
            this.tabPageAgregarCliente.Controls.Add(this.lblEstado);
            this.tabPageAgregarCliente.Controls.Add(this.tbLimite);
            this.tabPageAgregarCliente.Controls.Add(this.tbTelefono);
            this.tabPageAgregarCliente.Controls.Add(this.tbDireccion);
            this.tabPageAgregarCliente.Controls.Add(this.tbSegundoApellido);
            this.tabPageAgregarCliente.Controls.Add(this.tbPrimerApellido);
            this.tabPageAgregarCliente.Controls.Add(this.tbNombre);
            this.tabPageAgregarCliente.Controls.Add(this.btnGuardar);
            this.tabPageAgregarCliente.Controls.Add(this.lblLimite);
            this.tabPageAgregarCliente.Controls.Add(this.lblTelefono);
            this.tabPageAgregarCliente.Controls.Add(this.lblDireccion);
            this.tabPageAgregarCliente.Controls.Add(this.lblSegundoApellido);
            this.tabPageAgregarCliente.Controls.Add(this.lblPrimerApellido);
            this.tabPageAgregarCliente.Controls.Add(this.lblNombre);
            this.tabPageAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAgregarCliente.Location = new System.Drawing.Point(4, 54);
            this.tabPageAgregarCliente.Name = "tabPageAgregarCliente";
            this.tabPageAgregarCliente.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageAgregarCliente.Size = new System.Drawing.Size(818, 478);
            this.tabPageAgregarCliente.TabIndex = 0;
            this.tabPageAgregarCliente.Text = "Agregar";
            this.tabPageAgregarCliente.Click += new System.EventHandler(this.tabPageAgregarCliente_Click);
            // 
            // btCambiarEstado
            // 
            this.btCambiarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCambiarEstado.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btCambiarEstado.ForeColor = System.Drawing.Color.White;
            this.btCambiarEstado.Location = new System.Drawing.Point(586, 280);
            this.btCambiarEstado.Name = "btCambiarEstado";
            this.btCambiarEstado.Size = new System.Drawing.Size(102, 29);
            this.btCambiarEstado.TabIndex = 16;
            this.btCambiarEstado.Text = "Cambiar Estado";
            this.btCambiarEstado.UseVisualStyleBackColor = false;
            this.btCambiarEstado.Click += new System.EventHandler(this.btCambiarEstado_Click);
            // 
            // tbEstado
            // 
            this.tbEstado.Enabled = false;
            this.tbEstado.Location = new System.Drawing.Point(328, 279);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(252, 29);
            this.tbEstado.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Location = new System.Drawing.Point(254, 284);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 24);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // tbLimite
            // 
            this.tbLimite.Location = new System.Drawing.Point(328, 244);
            this.tbLimite.Name = "tbLimite";
            this.tbLimite.Size = new System.Drawing.Size(252, 29);
            this.tbLimite.TabIndex = 5;
            this.tbLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLimite_KeyPress);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(328, 209);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(252, 29);
            this.tbTelefono.TabIndex = 4;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(328, 174);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(252, 29);
            this.tbDireccion.TabIndex = 3;
            // 
            // tbSegundoApellido
            // 
            this.tbSegundoApellido.Location = new System.Drawing.Point(328, 139);
            this.tbSegundoApellido.Name = "tbSegundoApellido";
            this.tbSegundoApellido.Size = new System.Drawing.Size(252, 29);
            this.tbSegundoApellido.TabIndex = 2;
            // 
            // tbPrimerApellido
            // 
            this.tbPrimerApellido.Location = new System.Drawing.Point(328, 102);
            this.tbPrimerApellido.Name = "tbPrimerApellido";
            this.tbPrimerApellido.Size = new System.Drawing.Size(252, 29);
            this.tbPrimerApellido.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(328, 65);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(252, 29);
            this.tbNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(167, 331);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(521, 42);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLimite.Location = new System.Drawing.Point(174, 249);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(148, 24);
            this.lblLimite.TabIndex = 6;
            this.lblLimite.Text = "Límite de crédito";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(237, 214);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDireccion.Location = new System.Drawing.Point(232, 179);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 24);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSegundoApellido.Location = new System.Drawing.Point(163, 143);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(159, 24);
            this.lblSegundoApellido.TabIndex = 3;
            this.lblSegundoApellido.Text = "Segundo apellido";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrimerApellido.Location = new System.Drawing.Point(186, 105);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(136, 24);
            this.lblPrimerApellido.TabIndex = 2;
            this.lblPrimerApellido.Text = "Primer apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(243, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // tabPageModificar
            // 
            this.tabPageModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.tabPageModificar.Controls.Add(this.pictureBox1);
            this.tabPageModificar.Controls.Add(this.panel1);
            this.tabPageModificar.Controls.Add(this.btBuscarCliente);
            this.tabPageModificar.Controls.Add(this.tbNombreOApellido);
            this.tabPageModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageModificar.Location = new System.Drawing.Point(4, 54);
            this.tabPageModificar.Name = "tabPageModificar";
            this.tabPageModificar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageModificar.Size = new System.Drawing.Size(818, 478);
            this.tabPageModificar.TabIndex = 1;
            this.tabPageModificar.Text = "Modificar";
            this.tabPageModificar.Click += new System.EventHandler(this.tabPageModificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hnos_Rojas.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(8, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 319);
            this.panel1.TabIndex = 4;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.NombreCliente,
            this.ApellidoCliente,
            this.SegundoApellidoCliente,
            this.TelefonoCliente,
            this.DireccionCliente,
            this.EstadoCliente,
            this.CreditoCliente,
            this.IdentificadorCliente});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(812, 319);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.AutoSizeRowsModeChanged += new System.Windows.Forms.DataGridViewAutoSizeModeEventHandler(this.dgvClientes_AutoSizeRowsModeChanged);
            this.dgvClientes.AutoSizeColumnModeChanged += new System.Windows.Forms.DataGridViewAutoSizeColumnModeEventHandler(this.dgvClientes_AutoSizeColumnModeChanged);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.Editar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Hnos_Rojas.Properties.Resources.output_onlinepngtools;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 64;
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "perNombre";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.NombreCliente.HeaderText = "Nombre";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.DataPropertyName = "perPrimerApellido";
            this.ApellidoCliente.HeaderText = "Primer Apellido";
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            // 
            // SegundoApellidoCliente
            // 
            this.SegundoApellidoCliente.DataPropertyName = "perSegundoApellido";
            this.SegundoApellidoCliente.HeaderText = "Segundo Apellido";
            this.SegundoApellidoCliente.Name = "SegundoApellidoCliente";
            this.SegundoApellidoCliente.ReadOnly = true;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.DataPropertyName = "perTelefono";
            this.TelefonoCliente.HeaderText = "Teléfono";
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.ReadOnly = true;
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.DataPropertyName = "direccion";
            this.DireccionCliente.HeaderText = "Dirección";
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.ReadOnly = true;
            // 
            // EstadoCliente
            // 
            this.EstadoCliente.DataPropertyName = "estado";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.EstadoCliente.HeaderText = "Estado";
            this.EstadoCliente.Name = "EstadoCliente";
            this.EstadoCliente.ReadOnly = true;
            // 
            // CreditoCliente
            // 
            this.CreditoCliente.DataPropertyName = "credito";
            this.CreditoCliente.HeaderText = "Credito";
            this.CreditoCliente.Name = "CreditoCliente";
            this.CreditoCliente.ReadOnly = true;
            this.CreditoCliente.Visible = false;
            // 
            // IdentificadorCliente
            // 
            this.IdentificadorCliente.DataPropertyName = "perIdentificador";
            this.IdentificadorCliente.HeaderText = "Identificador";
            this.IdentificadorCliente.Name = "IdentificadorCliente";
            this.IdentificadorCliente.ReadOnly = true;
            this.IdentificadorCliente.Visible = false;
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarCliente.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btBuscarCliente.Location = new System.Drawing.Point(200, 378);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(114, 52);
            this.btBuscarCliente.TabIndex = 3;
            this.btBuscarCliente.Text = "Buscar";
            this.btBuscarCliente.UseVisualStyleBackColor = false;
            this.btBuscarCliente.Click += new System.EventHandler(this.btBuscarCliente_Click);
            // 
            // tbNombreOApellido
            // 
            this.tbNombreOApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbNombreOApellido.Location = new System.Drawing.Point(123, 337);
            this.tbNombreOApellido.Name = "tbNombreOApellido";
            this.tbNombreOApellido.Size = new System.Drawing.Size(191, 35);
            this.tbNombreOApellido.TabIndex = 1;
            // 
            // Agregar_EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(826, 536);
            this.Controls.Add(this.tabControlClientes);
            this.Name = "Agregar_EditarCliente";
            this.Text = "Administrar Clientes";
            this.Load += new System.EventHandler(this.Agregar_EditarCliente_Load);
            this.tabControlClientes.ResumeLayout(false);
            this.tabPageAgregarCliente.ResumeLayout(false);
            this.tabPageAgregarCliente.PerformLayout();
            this.tabPageModificar.ResumeLayout(false);
            this.tabPageModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPageAgregarCliente;
        private System.Windows.Forms.TabPage tabPageModificar;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.TextBox tbLimite;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbSegundoApellido;
        private System.Windows.Forms.TextBox tbPrimerApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btCambiarEstado;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.TextBox tbNombreOApellido;
        private System.Windows.Forms.Button btBuscarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificadorCliente;
    }
}