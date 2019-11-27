namespace Hnos_Rojas
{
    partial class Proveedor
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
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.btnAsociados = new System.Windows.Forms.Button();
            this.btnAgregarProv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificarProv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelProveedores
            // 
            this.panelProveedores.Location = new System.Drawing.Point(24, 83);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(1255, 556);
            this.panelProveedores.TabIndex = 20;
            // 
            // btnAsociados
            // 
            this.btnAsociados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnAsociados.FlatAppearance.BorderSize = 0;
            this.btnAsociados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsociados.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnAsociados.ForeColor = System.Drawing.Color.White;
            this.btnAsociados.Location = new System.Drawing.Point(24, 20);
            this.btnAsociados.Name = "btnAsociados";
            this.btnAsociados.Size = new System.Drawing.Size(254, 42);
            this.btnAsociados.TabIndex = 21;
            this.btnAsociados.Text = "Ver Asociados";
            this.btnAsociados.UseVisualStyleBackColor = false;
            this.btnAsociados.Click += new System.EventHandler(this.btnAsociados_Click);
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnAgregarProv.FlatAppearance.BorderSize = 0;
            this.btnAgregarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProv.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnAgregarProv.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProv.Location = new System.Drawing.Point(354, 20);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(254, 42);
            this.btnAgregarProv.TabIndex = 22;
            this.btnAgregarProv.Text = "Insertar";
            this.btnAgregarProv.UseVisualStyleBackColor = false;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1024, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Eliminar Proveedor";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnModificarProv
            // 
            this.btnModificarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnModificarProv.FlatAppearance.BorderSize = 0;
            this.btnModificarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProv.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnModificarProv.ForeColor = System.Drawing.Color.White;
            this.btnModificarProv.Location = new System.Drawing.Point(699, 20);
            this.btnModificarProv.Name = "btnModificarProv";
            this.btnModificarProv.Size = new System.Drawing.Size(254, 42);
            this.btnModificarProv.TabIndex = 24;
            this.btnModificarProv.Text = "Modificar";
            this.btnModificarProv.UseVisualStyleBackColor = false;
            this.btnModificarProv.Click += new System.EventHandler(this.btnModificarProv_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.btnModificarProv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarProv);
            this.Controls.Add(this.btnAsociados);
            this.Controls.Add(this.panelProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(32, 102);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Button btnAsociados;
        private System.Windows.Forms.Button btnAgregarProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificarProv;
    }
}