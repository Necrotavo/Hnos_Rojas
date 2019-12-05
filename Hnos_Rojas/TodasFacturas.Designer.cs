namespace Hnos_Rojas
{
    partial class TodasFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdFacturas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFacturas
            // 
            this.grdFacturas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imprimir,
            this.TIPO,
            this.Codigo,
            this.Fecha,
            this.Usuario,
            this.Cliente,
            this.Estado,
            this.Monto,
            this.Saldo,
            this.Notas,
            this.IdCliente});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdFacturas.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdFacturas.Location = new System.Drawing.Point(12, 76);
            this.grdFacturas.Name = "grdFacturas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdFacturas.Size = new System.Drawing.Size(1016, 388);
            this.grdFacturas.TabIndex = 8;
            this.grdFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFacturas_CellClick);
            this.grdFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFacturas_CellContentClick);
            this.grdFacturas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdFacturas_CellFormatting);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(799, 480);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(229, 48);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Imprimir
            // 
            this.Imprimir.HeaderText = "Imprimir";
            this.Imprimir.Image = global::Hnos_Rojas.Properties.Resources.Impresora;
            this.Imprimir.Name = "Imprimir";
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "Tipo";
            this.TIPO.HeaderText = "Tipo";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "ClienteNombre";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // Notas
            // 
            this.Notas.DataPropertyName = "Notas";
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(205, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(612, 29);
            this.lblTitulo.TabIndex = 114;
            this.lblTitulo.Text = "Título";
            // 
            // TodasFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1040, 556);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grdFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TodasFacturas";
            this.Text = "TodasFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.grdFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdFacturas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewImageColumn Imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.Label lblTitulo;
    }
}