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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.calDesde = new System.Windows.Forms.MonthCalendar();
            this.calHasta = new System.Windows.Forms.MonthCalendar();
            this.grdFacturas = new System.Windows.Forms.DataGridView();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDesde.Location = new System.Drawing.Point(15, 43);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(84, 29);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHasta.Location = new System.Drawing.Point(15, 252);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(74, 29);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta";
            // 
            // calDesde
            // 
            this.calDesde.Location = new System.Drawing.Point(18, 81);
            this.calDesde.Name = "calDesde";
            this.calDesde.TabIndex = 6;
            // 
            // calHasta
            // 
            this.calHasta.Location = new System.Drawing.Point(18, 302);
            this.calHasta.Name = "calHasta";
            this.calHasta.TabIndex = 7;
            // 
            // grdFacturas
            // 
            this.grdFacturas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.Usuario,
            this.Cliente,
            this.Estado,
            this.Monto,
            this.Notas,
            this.TIPO,
            this.Imprimir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdFacturas.Location = new System.Drawing.Point(278, 76);
            this.grdFacturas.Name = "grdFacturas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdFacturas.Size = new System.Drawing.Size(750, 388);
            this.grdFacturas.TabIndex = 8;
            this.grdFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFacturas_CellClick);
            this.grdFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFacturas_CellContentClick);
            this.grdFacturas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdFacturas_CellFormatting);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnDetalles.ForeColor = System.Drawing.Color.White;
            this.btnDetalles.Location = new System.Drawing.Point(563, 480);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(229, 48);
            this.btnDetalles.TabIndex = 22;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnImprimir_Click);
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
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(18, 476);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(248, 48);
            this.btnFiltrar.TabIndex = 24;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            // Notas
            // 
            this.Notas.DataPropertyName = "Notas";
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "Tipo";
            this.TIPO.HeaderText = "Tipo";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // Imprimir
            // 
            this.Imprimir.HeaderText = "Imprimir";
            this.Imprimir.Image = global::Hnos_Rojas.Properties.Resources.Impresora;
            this.Imprimir.Name = "Imprimir";
            // 
            // TodasFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1040, 556);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.grdFacturas);
            this.Controls.Add(this.calHasta);
            this.Controls.Add(this.calDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TodasFacturas";
            this.Text = "TodasFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.grdFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.MonthCalendar calDesde;
        private System.Windows.Forms.MonthCalendar calHasta;
        private System.Windows.Forms.DataGridView grdFacturas;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewImageColumn Imprimir;
    }
}