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
            this.dtVisita = new System.Windows.Forms.DateTimePicker();
            this.rbAM = new System.Windows.Forms.RadioButton();
            this.rbPM = new System.Windows.Forms.RadioButton();
            this.btnDiaVisita = new System.Windows.Forms.Button();
            this.lbDiasDeVisita = new System.Windows.Forms.ListBox();
            this.btnEditarDia = new System.Windows.Forms.Button();
            this.btnEliminarDia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(804, 113);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(229, 35);
            this.txtNombreProveedor.TabIndex = 34;
            // 
            // lblFechaVisita
            // 
            this.lblFechaVisita.AutoSize = true;
            this.lblFechaVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVisita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaVisita.Location = new System.Drawing.Point(692, 181);
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
            this.lblNombre.Location = new System.Drawing.Point(692, 119);
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
            this.lblTitulo.Location = new System.Drawing.Point(517, 22);
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
            this.btnGuardarCambios.Location = new System.Drawing.Point(278, 394);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(754, 41);
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
            this.btnSalir.Location = new System.Drawing.Point(278, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(755, 48);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboDias
            // 
            this.cboDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDias.FormattingEnabled = true;
            this.cboDias.Location = new System.Drawing.Point(697, 213);
            this.cboDias.Name = "cboDias";
            this.cboDias.Size = new System.Drawing.Size(150, 32);
            this.cboDias.TabIndex = 38;
            // 
            // dtVisita
            // 
            this.dtVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVisita.Location = new System.Drawing.Point(853, 216);
            this.dtVisita.Name = "dtVisita";
            this.dtVisita.Size = new System.Drawing.Size(115, 29);
            this.dtVisita.TabIndex = 39;
            // 
            // rbAM
            // 
            this.rbAM.AutoSize = true;
            this.rbAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbAM.Location = new System.Drawing.Point(975, 201);
            this.rbAM.Name = "rbAM";
            this.rbAM.Size = new System.Drawing.Size(57, 28);
            this.rbAM.TabIndex = 40;
            this.rbAM.TabStop = true;
            this.rbAM.Text = "AM";
            this.rbAM.UseVisualStyleBackColor = true;
            // 
            // rbPM
            // 
            this.rbPM.AutoSize = true;
            this.rbPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbPM.Location = new System.Drawing.Point(975, 232);
            this.rbPM.Name = "rbPM";
            this.rbPM.Size = new System.Drawing.Size(56, 28);
            this.rbPM.TabIndex = 41;
            this.rbPM.TabStop = true;
            this.rbPM.Text = "PM";
            this.rbPM.UseVisualStyleBackColor = true;
            // 
            // btnDiaVisita
            // 
            this.btnDiaVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnDiaVisita.FlatAppearance.BorderSize = 0;
            this.btnDiaVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiaVisita.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnDiaVisita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiaVisita.Location = new System.Drawing.Point(698, 266);
            this.btnDiaVisita.Name = "btnDiaVisita";
            this.btnDiaVisita.Size = new System.Drawing.Size(335, 52);
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
            this.lbDiasDeVisita.Location = new System.Drawing.Point(278, 111);
            this.lbDiasDeVisita.Name = "lbDiasDeVisita";
            this.lbDiasDeVisita.Size = new System.Drawing.Size(399, 207);
            this.lbDiasDeVisita.TabIndex = 43;
            this.lbDiasDeVisita.Click += new System.EventHandler(this.lbDiasDeVisita_Click);
            // 
            // btnEditarDia
            // 
            this.btnEditarDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnEditarDia.FlatAppearance.BorderSize = 0;
            this.btnEditarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDia.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnEditarDia.ForeColor = System.Drawing.Color.White;
            this.btnEditarDia.Location = new System.Drawing.Point(278, 324);
            this.btnEditarDia.Name = "btnEditarDia";
            this.btnEditarDia.Size = new System.Drawing.Size(139, 46);
            this.btnEditarDia.TabIndex = 44;
            this.btnEditarDia.Text = "Editar";
            this.btnEditarDia.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDia
            // 
            this.btnEliminarDia.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarDia.FlatAppearance.BorderSize = 0;
            this.btnEliminarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDia.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnEliminarDia.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDia.Location = new System.Drawing.Point(538, 324);
            this.btnEliminarDia.Name = "btnEliminarDia";
            this.btnEliminarDia.Size = new System.Drawing.Size(139, 46);
            this.btnEliminarDia.TabIndex = 45;
            this.btnEliminarDia.Text = "Eliminar";
            this.btnEliminarDia.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(273, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Días de visita";
            // 
            // Agregar_ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1255, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarDia);
            this.Controls.Add(this.btnEditarDia);
            this.Controls.Add(this.lbDiasDeVisita);
            this.Controls.Add(this.btnDiaVisita);
            this.Controls.Add(this.rbPM);
            this.Controls.Add(this.rbAM);
            this.Controls.Add(this.dtVisita);
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
        private System.Windows.Forms.DateTimePicker dtVisita;
        private System.Windows.Forms.RadioButton rbPM;
        private System.Windows.Forms.RadioButton rbAM;
        private System.Windows.Forms.Button btnDiaVisita;
        private System.Windows.Forms.ListBox lbDiasDeVisita;
        private System.Windows.Forms.Button btnEditarDia;
        private System.Windows.Forms.Button btnEliminarDia;
        private System.Windows.Forms.Label label1;
    }
}