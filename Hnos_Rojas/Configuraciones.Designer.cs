﻿namespace Hnos_Rojas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlantilla
            // 
            this.btnPlantilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnPlantilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantilla.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnPlantilla.ForeColor = System.Drawing.Color.White;
            this.btnPlantilla.Location = new System.Drawing.Point(0, 108);
            this.btnPlantilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlantilla.Name = "btnPlantilla";
            this.btnPlantilla.Size = new System.Drawing.Size(221, 108);
            this.btnPlantilla.TabIndex = 9;
            this.btnPlantilla.Text = "Plantilla Factura";
            this.btnPlantilla.UseVisualStyleBackColor = false;
            this.btnPlantilla.Click += new System.EventHandler(this.btnPlantilla_Click);
            // 
            // btnUsuariosConf
            // 
            this.btnUsuariosConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnUsuariosConf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuariosConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosConf.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnUsuariosConf.ForeColor = System.Drawing.Color.White;
            this.btnUsuariosConf.Location = new System.Drawing.Point(0, 0);
            this.btnUsuariosConf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuariosConf.Name = "btnUsuariosConf";
            this.btnUsuariosConf.Size = new System.Drawing.Size(221, 108);
            this.btnUsuariosConf.TabIndex = 10;
            this.btnUsuariosConf.Text = "Usuarios";
            this.btnUsuariosConf.UseVisualStyleBackColor = false;
            this.btnUsuariosConf.Click += new System.EventHandler(this.btnUsuariosConf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnPlantilla);
            this.panel1.Controls.Add(this.btnUsuariosConf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 814);
            this.panel1.TabIndex = 11;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(0, 216);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(221, 108);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1514, 814);
            this.panel2.TabIndex = 12;
            // 
            // Configuraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 814);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Configuraciones";
            this.Text = "Configuraciones";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlantilla;
        private System.Windows.Forms.Button btnUsuariosConf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAyuda;
    }
}