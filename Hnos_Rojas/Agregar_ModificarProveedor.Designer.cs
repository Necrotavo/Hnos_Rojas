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
            this.lblFechaVisita = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboDias = new System.Windows.Forms.ComboBox();
            this.btnDiaVisita = new System.Windows.Forms.Button();
            this.lbDiasDeVisita = new System.Windows.Forms.ListBox();
            this.btnEliminarDia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboHoras = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(797, 130);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(163, 35);
            this.txtNombreProveedor.TabIndex = 34;
            // 
            // lblFechaVisita
            // 
            this.lblFechaVisita.AutoSize = true;
            this.lblFechaVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVisita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaVisita.Location = new System.Drawing.Point(684, 191);
            this.lblFechaVisita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaVisita.Name = "lblFechaVisita";
            this.lblFechaVisita.Size = new System.Drawing.Size(180, 29);
            this.lblFechaVisita.TabIndex = 32;
            this.lblFechaVisita.Text = "Fecha de visita:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(685, 136);
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
            this.lblTitulo.Location = new System.Drawing.Point(560, 48);
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
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarCambios.Location = new System.Drawing.Point(343, 366);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(617, 41);
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
            this.btnSalir.Location = new System.Drawing.Point(343, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(617, 48);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboDias
            // 
            this.cboDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDias.FormattingEnabled = true;
            this.cboDias.Location = new System.Drawing.Point(689, 223);
            this.cboDias.Name = "cboDias";
            this.cboDias.Size = new System.Drawing.Size(150, 32);
            this.cboDias.TabIndex = 38;
            // 
            // btnDiaVisita
            // 
            this.btnDiaVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnDiaVisita.FlatAppearance.BorderSize = 0;
            this.btnDiaVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiaVisita.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnDiaVisita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiaVisita.Location = new System.Drawing.Point(690, 289);
            this.btnDiaVisita.Name = "btnDiaVisita";
            this.btnDiaVisita.Size = new System.Drawing.Size(139, 46);
            this.btnDiaVisita.TabIndex = 42;
            this.btnDiaVisita.Text = "Agregar";
            this.btnDiaVisita.UseVisualStyleBackColor = false;
            this.btnDiaVisita.Click += new System.EventHandler(this.btnDiaVisita_Click);
            // 
            // lbDiasDeVisita
            // 
            this.lbDiasDeVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiasDeVisita.FormattingEnabled = true;
            this.lbDiasDeVisita.ItemHeight = 29;
            this.lbDiasDeVisita.Location = new System.Drawing.Point(343, 130);
            this.lbDiasDeVisita.Name = "lbDiasDeVisita";
            this.lbDiasDeVisita.Size = new System.Drawing.Size(327, 149);
            this.lbDiasDeVisita.TabIndex = 43;
            this.lbDiasDeVisita.Click += new System.EventHandler(this.lbDiasDeVisita_Click);
            // 
            // btnEliminarDia
            // 
            this.btnEliminarDia.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarDia.FlatAppearance.BorderSize = 0;
            this.btnEliminarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDia.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnEliminarDia.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDia.Location = new System.Drawing.Point(531, 289);
            this.btnEliminarDia.Name = "btnEliminarDia";
            this.btnEliminarDia.Size = new System.Drawing.Size(139, 46);
            this.btnEliminarDia.TabIndex = 45;
            this.btnEliminarDia.Text = "Eliminar";
            this.btnEliminarDia.UseVisualStyleBackColor = false;
            this.btnEliminarDia.Click += new System.EventHandler(this.btnEliminarDia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(338, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Visitas:";
            // 
            // cboHoras
            // 
            this.cboHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboHoras.FormattingEnabled = true;
            this.cboHoras.Items.AddRange(new object[] {
            "08:00AM",
            "09:00AM",
            "10:00AM",
            "11:00AM",
            "12:00PM",
            "01:00PM",
            "02:00PM",
            "03:00PM",
            "04:00PM",
            "05:00PM",
            "06:00PM",
            "07:00PM"});
            this.cboHoras.Location = new System.Drawing.Point(845, 223);
            this.cboHoras.Name = "cboHoras";
            this.cboHoras.Size = new System.Drawing.Size(115, 32);
            this.cboHoras.TabIndex = 47;
            // 
            // Agregar_ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1255, 523);
            this.Controls.Add(this.cboHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarDia);
            this.Controls.Add(this.lbDiasDeVisita);
            this.Controls.Add(this.btnDiaVisita);
            this.Controls.Add(this.cboDias);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.lblFechaVisita);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Agregar_ModificarProveedor";
            this.Text = "Agregar_ModificarProveedor";
            this.Load += new System.EventHandler(this.Agregar_ModificarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblFechaVisita;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboDias;
        private System.Windows.Forms.Button btnDiaVisita;
        private System.Windows.Forms.ListBox lbDiasDeVisita;
        private System.Windows.Forms.Button btnEliminarDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHoras;
    }
}