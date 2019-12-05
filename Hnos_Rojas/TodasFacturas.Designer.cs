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
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.calDesde = new System.Windows.Forms.MonthCalendar();
            this.calHasta = new System.Windows.Forms.MonthCalendar();
            this.grdFacturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDesde.Location = new System.Drawing.Point(25, 43);
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
            this.lblHasta.Location = new System.Drawing.Point(25, 277);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(74, 29);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta";
            // 
            // calDesde
            // 
            this.calDesde.Location = new System.Drawing.Point(30, 81);
            this.calDesde.Name = "calDesde";
            this.calDesde.TabIndex = 6;
            // 
            // calHasta
            // 
            this.calHasta.Location = new System.Drawing.Point(30, 327);
            this.calHasta.Name = "calHasta";
            this.calHasta.TabIndex = 7;
            // 
            // grdFacturas
            // 
            this.grdFacturas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFacturas.Location = new System.Drawing.Point(329, 81);
            this.grdFacturas.Name = "grdFacturas";
            this.grdFacturas.Size = new System.Drawing.Size(240, 150);
            this.grdFacturas.TabIndex = 8;
            // 
            // TodasFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1024, 517);
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
    }
}