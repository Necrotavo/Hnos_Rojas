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
            this.calDesde = new System.Windows.Forms.MonthCalendar();
            this.calHasta = new System.Windows.Forms.MonthCalendar();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.grdFacturas = new System.Windows.Forms.DataGridView();
            this.lblMsgTotal = new System.Windows.Forms.Label();
            this.lblMontoCred = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // calDesde
            // 
            this.calDesde.Location = new System.Drawing.Point(18, 62);
            this.calDesde.Name = "calDesde";
            this.calDesde.TabIndex = 0;
            // 
            // calHasta
            // 
            this.calHasta.Location = new System.Drawing.Point(18, 349);
            this.calHasta.Name = "calHasta";
            this.calHasta.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDesde.Location = new System.Drawing.Point(95, 17);
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
            this.lblHasta.Location = new System.Drawing.Point(104, 304);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(91, 36);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta";
            // 
            // grdFacturas
            // 
            this.grdFacturas.BackgroundColor = System.Drawing.Color.White;
            this.grdFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFacturas.Location = new System.Drawing.Point(326, 62);
            this.grdFacturas.Name = "grdFacturas";
            this.grdFacturas.RowTemplate.Height = 24;
            this.grdFacturas.Size = new System.Drawing.Size(742, 414);
            this.grdFacturas.TabIndex = 5;
            // 
            // lblMsgTotal
            // 
            this.lblMsgTotal.AutoSize = true;
            this.lblMsgTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMsgTotal.Location = new System.Drawing.Point(801, 505);
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
            this.lblMontoCred.Location = new System.Drawing.Point(933, 505);
            this.lblMontoCred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoCred.Name = "lblMontoCred";
            this.lblMontoCred.Size = new System.Drawing.Size(0, 36);
            this.lblMontoCred.TabIndex = 7;
            // 
            // DetallesEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1080, 574);
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
    }
}