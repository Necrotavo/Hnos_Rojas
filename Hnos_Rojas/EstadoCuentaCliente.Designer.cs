﻿namespace Hnos_Rojas
{
    partial class EstadoCuentaCliente
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
            this.listBClientes = new System.Windows.Forms.ListBox();
            this.txtEstadoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBClientes
            // 
            this.listBClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBClientes.FormattingEnabled = true;
            this.listBClientes.ItemHeight = 36;
            this.listBClientes.Location = new System.Drawing.Point(604, 294);
            this.listBClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBClientes.Name = "listBClientes";
            this.listBClientes.Size = new System.Drawing.Size(423, 148);
            this.listBClientes.TabIndex = 0;
            this.listBClientes.Click += new System.EventHandler(this.listBClientes_Click);
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoCliente.Location = new System.Drawing.Point(604, 217);
            this.txtEstadoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.Size = new System.Drawing.Size(423, 41);
            this.txtEstadoCliente.TabIndex = 1;
            this.txtEstadoCliente.TextChanged += new System.EventHandler(this.txtEstadoCliente_TextChanged);
            this.txtEstadoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstadoCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(541, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el nombre o apellido del cliente";
            // 
            // EstadoCuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1673, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstadoCliente);
            this.Controls.Add(this.listBClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EstadoCuentaCliente";
            this.Text = "EstadoCuentaCliente";
            this.Load += new System.EventHandler(this.EstadoCuentaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBClientes;
        private System.Windows.Forms.TextBox txtEstadoCliente;
        private System.Windows.Forms.Label label1;
    }
}