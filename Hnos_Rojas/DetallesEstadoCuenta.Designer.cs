﻿namespace Hnos_Rojas
{
    partial class DetallesEstadoCuenta
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
            this.calDesde = new System.Windows.Forms.MonthCalendar();
            this.calHasta = new System.Windows.Forms.MonthCalendar();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.grdFacturas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abonar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblMsgTotal = new System.Windows.Forms.Label();
            this.lblMontoCred = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAbonarCredito = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // calDesde
            // 
            this.calDesde.Location = new System.Drawing.Point(37, 66);
            this.calDesde.Name = "calDesde";
            this.calDesde.TabIndex = 0;
            // 
            // calHasta
            // 
            this.calHasta.Location = new System.Drawing.Point(37, 336);
            this.calHasta.Name = "calHasta";
            this.calHasta.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDesde.Location = new System.Drawing.Point(115, 21);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(100, 36);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHasta.Location = new System.Drawing.Point(123, 290);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(91, 36);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta";
            // 
            // grdFacturas
            // 
            this.grdFacturas.AllowUserToAddRows = false;
            this.grdFacturas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.grdFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdFacturas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.Usuario,
            this.ClienteNombre,
            this.Estado,
            this.Monto,
            this.Saldo,
            this.Abonar,
            this.Imprimir});
            this.grdFacturas.Location = new System.Drawing.Point(381, 66);
            this.grdFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdFacturas.Name = "grdFacturas";
            this.grdFacturas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdFacturas.RowTemplate.Height = 24;
            this.grdFacturas.Size = new System.Drawing.Size(1257, 478);
            this.grdFacturas.TabIndex = 5;
            this.grdFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFacturas_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 121;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 109;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 125;
            // 
            // ClienteNombre
            // 
            this.ClienteNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClienteNombre.DataPropertyName = "ClienteNombre";
            this.ClienteNombre.HeaderText = "Cliente";
            this.ClienteNombre.Name = "ClienteNombre";
            this.ClienteNombre.ReadOnly = true;
            this.ClienteNombre.Width = 118;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 117;
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 109;
            // 
            // Saldo
            // 
            this.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 105;
            // 
            // Abonar
            // 
            this.Abonar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Abonar.DataPropertyName = "Abonar";
            this.Abonar.HeaderText = "Abonar";
            this.Abonar.Image = global::Hnos_Rojas.Properties.Resources.pagar3;
            this.Abonar.Name = "Abonar";
            this.Abonar.ReadOnly = true;
            this.Abonar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Abonar.Width = 96;
            // 
            // Imprimir
            // 
            this.Imprimir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Imprimir.HeaderText = "Impr.";
            this.Imprimir.Image = global::Hnos_Rojas.Properties.Resources.Impresora;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.ReadOnly = true;
            this.Imprimir.Width = 73;
            // 
            // lblMsgTotal
            // 
            this.lblMsgTotal.AutoSize = true;
            this.lblMsgTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMsgTotal.Location = new System.Drawing.Point(375, 587);
            this.lblMsgTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgTotal.Name = "lblMsgTotal";
            this.lblMsgTotal.Size = new System.Drawing.Size(89, 36);
            this.lblMsgTotal.TabIndex = 6;
            this.lblMsgTotal.Text = "Total:";
            // 
            // lblMontoCred
            // 
            this.lblMontoCred.AutoSize = true;
            this.lblMontoCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCred.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMontoCred.Location = new System.Drawing.Point(484, 587);
            this.lblMontoCred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoCred.Name = "lblMontoCred";
            this.lblMontoCred.Size = new System.Drawing.Size(0, 36);
            this.lblMontoCred.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1380, 580);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(259, 52);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Retroceder";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(55, 580);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(259, 52);
            this.btnFiltrar.TabIndex = 19;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAbonarCredito
            // 
            this.btnAbonarCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnAbonarCredito.FlatAppearance.BorderSize = 0;
            this.btnAbonarCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonarCredito.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonarCredito.ForeColor = System.Drawing.Color.White;
            this.btnAbonarCredito.Location = new System.Drawing.Point(679, 580);
            this.btnAbonarCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbonarCredito.Name = "btnAbonarCredito";
            this.btnAbonarCredito.Size = new System.Drawing.Size(259, 52);
            this.btnAbonarCredito.TabIndex = 20;
            this.btnAbonarCredito.Text = "Abonar Credito";
            this.btnAbonarCredito.UseVisualStyleBackColor = false;
            this.btnAbonarCredito.Click += new System.EventHandler(this.btnAbonarCredito_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(1036, 580);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(259, 52);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.Text = "Imprimir Reporte";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.DataPropertyName = "Abonar";
            this.dataGridViewImageColumn1.HeaderText = "Abonar";
            this.dataGridViewImageColumn1.Image = global::Hnos_Rojas.Properties.Resources.pagar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Imprimir";
            this.dataGridViewImageColumn2.Image = global::Hnos_Rojas.Properties.Resources.Impresora;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // DetallesEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1673, 684);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAbonarCredito);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMontoCred);
            this.Controls.Add(this.lblMsgTotal);
            this.Controls.Add(this.grdFacturas);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.calHasta);
            this.Controls.Add(this.calDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DetallesEstadoCuenta";
            this.Text = "DetallesEstadoCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.grdFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calDesde;
        private System.Windows.Forms.MonthCalendar calHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DataGridView grdFacturas;
        private System.Windows.Forms.Label lblMsgTotal;
        private System.Windows.Forms.Label lblMontoCred;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnAbonarCredito;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewImageColumn Abonar;
        private System.Windows.Forms.DataGridViewImageColumn Imprimir;
    }
}