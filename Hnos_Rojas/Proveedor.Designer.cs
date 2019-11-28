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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificarProv = new System.Windows.Forms.Button();
            this.btnHorario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelProveedores
            // 
            this.panelProveedores.Location = new System.Drawing.Point(32, 102);
            this.panelProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(1673, 684);
            this.panelProveedores.TabIndex = 20;
            // 
            // btnAsociados
            // 
            this.btnAsociados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnAsociados.FlatAppearance.BorderSize = 0;
            this.btnAsociados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsociados.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnAsociados.ForeColor = System.Drawing.Color.White;
            this.btnAsociados.Location = new System.Drawing.Point(32, 25);
            this.btnAsociados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsociados.Name = "btnAsociados";
            this.btnAsociados.Size = new System.Drawing.Size(259, 52);
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
            this.btnAgregarProv.Location = new System.Drawing.Point(389, 25);
            this.btnAgregarProv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(259, 52);
            this.btnAgregarProv.TabIndex = 22;
            this.btnAgregarProv.Text = "Insertar";
            this.btnAgregarProv.UseVisualStyleBackColor = false;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1445, 25);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(259, 52);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar Proveedor";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificarProv
            // 
            this.btnModificarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnModificarProv.Enabled = false;
            this.btnModificarProv.FlatAppearance.BorderSize = 0;
            this.btnModificarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProv.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnModificarProv.ForeColor = System.Drawing.Color.White;
            this.btnModificarProv.Location = new System.Drawing.Point(742, 25);
            this.btnModificarProv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarProv.Name = "btnModificarProv";
            this.btnModificarProv.Size = new System.Drawing.Size(259, 52);
            this.btnModificarProv.TabIndex = 24;
            this.btnModificarProv.Text = "Modificar";
            this.btnModificarProv.UseVisualStyleBackColor = false;
            this.btnModificarProv.Click += new System.EventHandler(this.btnModificarProv_Click);
            // 
            // btnHorario
            // 
            this.btnHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.Location = new System.Drawing.Point(1110, 25);
            this.btnHorario.Margin = new System.Windows.Forms.Padding(4);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(259, 52);
            this.btnHorario.TabIndex = 25;
            this.btnHorario.Text = "Horario";
            this.btnHorario.UseVisualStyleBackColor = false;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1735, 814);
            this.Controls.Add(this.btnHorario);
            this.Controls.Add(this.btnModificarProv);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarProv);
            this.Controls.Add(this.btnAsociados);
            this.Controls.Add(this.panelProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(32, 102);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Button btnAsociados;
        private System.Windows.Forms.Button btnAgregarProv;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificarProv;
        private System.Windows.Forms.Button btnHorario;
    }
}