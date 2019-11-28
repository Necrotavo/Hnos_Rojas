namespace Hnos_Rojas
{
    partial class Agregar_ModificarProveedor
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
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtFechaVisita = new System.Windows.Forms.TextBox();
            this.lblFechaVisita = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(636, 210);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(151, 35);
            this.txtNombreProveedor.TabIndex = 34;
            // 
            // txtFechaVisita
            // 
            this.txtFechaVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVisita.Location = new System.Drawing.Point(636, 247);
            this.txtFechaVisita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechaVisita.Name = "txtFechaVisita";
            this.txtFechaVisita.Size = new System.Drawing.Size(151, 35);
            this.txtFechaVisita.TabIndex = 33;
            // 
            // lblFechaVisita
            // 
            this.lblFechaVisita.AutoSize = true;
            this.lblFechaVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVisita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaVisita.Location = new System.Drawing.Point(475, 249);
            this.lblFechaVisita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaVisita.Name = "lblFechaVisita";
            this.lblFechaVisita.Size = new System.Drawing.Size(149, 29);
            this.lblFechaVisita.TabIndex = 32;
            this.lblFechaVisita.Text = "Día de visita:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(475, 212);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(535, 132);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 29);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "Agregar/Modificar";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarCambios.Location = new System.Drawing.Point(479, 336);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(307, 41);
            this.btnGuardarCambios.TabIndex = 36;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(480, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(307, 48);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Agregar_ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1255, 523);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.txtFechaVisita);
            this.Controls.Add(this.lblFechaVisita);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Agregar_ModificarProveedor";
            this.Text = "Agregar_ModificarProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtFechaVisita;
        private System.Windows.Forms.Label lblFechaVisita;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnSalir;
    }
}