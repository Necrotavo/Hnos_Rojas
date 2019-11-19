namespace Hnos_Rojas
{
    partial class Clientes
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
            this.btnEstadoCuenta = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnEstadoCuenta
            // 
            this.btnEstadoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnEstadoCuenta.FlatAppearance.BorderSize = 0;
            this.btnEstadoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoCuenta.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnEstadoCuenta.ForeColor = System.Drawing.Color.White;
            this.btnEstadoCuenta.Location = new System.Drawing.Point(24, 23);
            this.btnEstadoCuenta.Name = "btnEstadoCuenta";
            this.btnEstadoCuenta.Size = new System.Drawing.Size(192, 42);
            this.btnEstadoCuenta.TabIndex = 16;
            this.btnEstadoCuenta.Text = "Estado de Cuenta";
            this.btnEstadoCuenta.UseVisualStyleBackColor = false;
            this.btnEstadoCuenta.Click += new System.EventHandler(this.btnEstadoCuenta_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(244, 23);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(192, 42);
            this.btnNuevoCliente.TabIndex = 17;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnModificarCliente.ForeColor = System.Drawing.Color.White;
            this.btnModificarCliente.Location = new System.Drawing.Point(464, 23);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(192, 42);
            this.btnModificarCliente.TabIndex = 18;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            // 
            // panelClientes
            // 
            this.panelClientes.Location = new System.Drawing.Point(24, 101);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(1000, 430);
            this.panelClientes.TabIndex = 19;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 554);
            this.Controls.Add(this.panelClientes);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnEstadoCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstadoCuenta;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Panel panelClientes;
    }
}