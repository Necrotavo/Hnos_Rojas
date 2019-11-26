namespace Hnos_Rojas
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
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPageAgregarCliente = new System.Windows.Forms.TabPage();
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
            this.lblAgregarCliente = new System.Windows.Forms.Label();
            this.tabPageModificar = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlClientes.SuspendLayout();
            this.tabPageAgregarCliente.SuspendLayout();
            this.tabPageModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPageAgregarCliente);
            this.tabControlClientes.Controls.Add(this.tabPageModificar);
            this.tabControlClientes.Location = new System.Drawing.Point(3, 1);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(794, 450);
            this.tabControlClientes.TabIndex = 0;
            // 
            // tabPageAgregarCliente
            // 
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
            this.tabPageAgregarCliente.Controls.Add(this.lblAgregarCliente);
            this.tabPageAgregarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgregarCliente.Name = "tabPageAgregarCliente";
            this.tabPageAgregarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgregarCliente.Size = new System.Drawing.Size(786, 424);
            this.tabPageAgregarCliente.TabIndex = 0;
            this.tabPageAgregarCliente.Text = "Agregar";
            this.tabPageAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // tbLimite
            // 
            this.tbLimite.Location = new System.Drawing.Point(333, 277);
            this.tbLimite.Name = "tbLimite";
            this.tbLimite.Size = new System.Drawing.Size(100, 20);
            this.tbLimite.TabIndex = 13;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(333, 227);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 12;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(333, 188);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(196, 20);
            this.tbDireccion.TabIndex = 11;
            // 
            // tbSegundoApellido
            // 
            this.tbSegundoApellido.Location = new System.Drawing.Point(333, 146);
            this.tbSegundoApellido.Name = "tbSegundoApellido";
            this.tbSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.tbSegundoApellido.TabIndex = 10;
            // 
            // tbPrimerApellido
            // 
            this.tbPrimerApellido.Location = new System.Drawing.Point(333, 105);
            this.tbPrimerApellido.Name = "tbPrimerApellido";
            this.tbPrimerApellido.Size = new System.Drawing.Size(100, 20);
            this.tbPrimerApellido.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(333, 64);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(347, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(178, 277);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(86, 13);
            this.lblLimite.TabIndex = 6;
            this.lblLimite.Text = "Límite de crédito";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(175, 227);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(175, 188);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(175, 146);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(89, 13);
            this.lblSegundoApellido.TabIndex = 3;
            this.lblSegundoApellido.Text = "Segundo apellido";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(175, 105);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(75, 13);
            this.lblPrimerApellido.TabIndex = 2;
            this.lblPrimerApellido.Text = "Primer apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(175, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAgregarCliente
            // 
            this.lblAgregarCliente.AutoSize = true;
            this.lblAgregarCliente.Location = new System.Drawing.Point(330, 3);
            this.lblAgregarCliente.Name = "lblAgregarCliente";
            this.lblAgregarCliente.Size = new System.Drawing.Size(111, 13);
            this.lblAgregarCliente.TabIndex = 0;
            this.lblAgregarCliente.Text = "Agregar nuevo cliente";
            // 
            // tabPageModificar
            // 
            this.tabPageModificar.Controls.Add(this.dgvClientes);
            this.tabPageModificar.Location = new System.Drawing.Point(4, 22);
            this.tabPageModificar.Name = "tabPageModificar";
            this.tabPageModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModificar.Size = new System.Drawing.Size(786, 424);
            this.tabPageModificar.TabIndex = 1;
            this.tabPageModificar.Text = "Modificar";
            this.tabPageModificar.UseVisualStyleBackColor = true;
            this.tabPageModificar.Click += new System.EventHandler(this.tabPageModificar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.ApellidoCliente,
            this.SegundoApellido,
            this.Direccion,
            this.Estado});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(780, 418);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting);
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "perNombre";
            this.NombreCliente.HeaderText = "Nombre";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.DataPropertyName = "perPrimerApellido";
            this.ApellidoCliente.HeaderText = "Primer Apellido";
            this.ApellidoCliente.Name = "ApellidoCliente";
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "perSegundoApellido";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Agregar_EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlClientes);
            this.Name = "Agregar_EditarCliente";
            this.Text = "Agregar_EditarCliente";
            this.Load += new System.EventHandler(this.Agregar_EditarCliente_Load);
            this.tabControlClientes.ResumeLayout(false);
            this.tabPageAgregarCliente.ResumeLayout(false);
            this.tabPageAgregarCliente.PerformLayout();
            this.tabPageModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPageAgregarCliente;
        private System.Windows.Forms.TabPage tabPageModificar;
        private System.Windows.Forms.Label lblAgregarCliente;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}