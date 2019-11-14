namespace Hnos_Rojas
{
    partial class Tickets
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
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rdoContado = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(-1, 0);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.RowTemplate.ReadOnly = true;
            this.gridProductos.Size = new System.Drawing.Size(770, 251);
            this.gridProductos.TabIndex = 0;
            this.gridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Historic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(775, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(209, 86);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "₡0,00";
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(775, 89);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(289, 82);
            this.btnCobrar.TabIndex = 2;
            this.btnCobrar.Text = "F12 Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-1, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "DEL Borrar Producto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdoContado
            // 
            this.rdoContado.AutoSize = true;
            this.rdoContado.Checked = true;
            this.rdoContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoContado.Location = new System.Drawing.Point(775, 177);
            this.rdoContado.Name = "rdoContado";
            this.rdoContado.Size = new System.Drawing.Size(157, 41);
            this.rdoContado.TabIndex = 4;
            this.rdoContado.TabStop = true;
            this.rdoContado.Text = "Contado";
            this.rdoContado.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(775, 210);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(138, 41);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Crédito";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 322);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rdoContado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gridProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tickets";
            this.Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdoContado;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}