namespace Hnos_Rojas
{
    partial class Configuraciones
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
            this.btnPlantilla = new System.Windows.Forms.Button();
            this.btnUsuariosConf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlantilla
            // 
            this.btnPlantilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnPlantilla.FlatAppearance.BorderSize = 0;
            this.btnPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantilla.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnPlantilla.ForeColor = System.Drawing.Color.White;
            this.btnPlantilla.Location = new System.Drawing.Point(0, 0);
            this.btnPlantilla.Name = "btnPlantilla";
            this.btnPlantilla.Size = new System.Drawing.Size(320, 126);
            this.btnPlantilla.TabIndex = 9;
            this.btnPlantilla.Text = "Plantilla Factura";
            this.btnPlantilla.UseVisualStyleBackColor = false;
            // 
            // btnUsuariosConf
            // 
            this.btnUsuariosConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnUsuariosConf.FlatAppearance.BorderSize = 0;
            this.btnUsuariosConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosConf.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnUsuariosConf.ForeColor = System.Drawing.Color.White;
            this.btnUsuariosConf.Location = new System.Drawing.Point(0, 126);
            this.btnUsuariosConf.Name = "btnUsuariosConf";
            this.btnUsuariosConf.Size = new System.Drawing.Size(320, 126);
            this.btnUsuariosConf.TabIndex = 10;
            this.btnUsuariosConf.Text = "Usuarios";
            this.btnUsuariosConf.UseVisualStyleBackColor = false;
            // 
            // Configuraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 661);
            this.Controls.Add(this.btnUsuariosConf);
            this.Controls.Add(this.btnPlantilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuraciones";
            this.Text = "Configuraciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlantilla;
        private System.Windows.Forms.Button btnUsuariosConf;
    }
}