namespace Hnos_Rojas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.calDesde = new System.Windows.Forms.MonthCalendar();
            this.calHasta = new System.Windows.Forms.MonthCalendar();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.grdFacturas = new System.Windows.Forms.DataGridView();
            this.lblMsgTotal = new System.Windows.Forms.Label();
            this.lblMontoCred = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAbonarCredito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // calDesde
            // 
            this.calDesde.Location = new System.Drawing.Point(64, 66);
            this.calDesde.Name = "calDesde";
            this.calDesde.TabIndex = 0;
            // 
            // calHasta
            // 
            this.calHasta.Location = new System.Drawing.Point(64, 336);
            this.calHasta.Name = "calHasta";
            this.calHasta.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDesde.Location = new System.Drawing.Point(141, 21);
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
            this.lblHasta.Location = new System.Drawing.Point(150, 291);
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
            this.grdFacturas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFacturas.Location = new System.Drawing.Point(390, 66);
            this.grdFacturas.Name = "grdFacturas";
            this.grdFacturas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdFacturas.RowTemplate.Height = 24;
            this.grdFacturas.Size = new System.Drawing.Size(1223, 477);
            this.grdFacturas.TabIndex = 5;
            // 
            // lblMsgTotal
            // 
            this.lblMsgTotal.AutoSize = true;
            this.lblMsgTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMsgTotal.Location = new System.Drawing.Point(859, 596);
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
            this.lblMontoCred.Location = new System.Drawing.Point(968, 596);
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
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1434, 581);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(179, 62);
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
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(64, 584);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(305, 59);
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
            this.btnAbonarCredito.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnAbonarCredito.ForeColor = System.Drawing.Color.White;
            this.btnAbonarCredito.Location = new System.Drawing.Point(1108, 583);
            this.btnAbonarCredito.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbonarCredito.Name = "btnAbonarCredito";
            this.btnAbonarCredito.Size = new System.Drawing.Size(305, 59);
            this.btnAbonarCredito.TabIndex = 20;
            this.btnAbonarCredito.Text = "Abonar Credito";
            this.btnAbonarCredito.UseVisualStyleBackColor = false;
            // 
            // DetallesEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1673, 684);
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
    }
}