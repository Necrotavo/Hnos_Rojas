namespace Hnos_Rojas
{
    partial class HorarioProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdAsociados = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAsociados)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAsociados
            // 
            this.grdAsociados.AllowUserToAddRows = false;
            this.grdAsociados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.grdAsociados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAsociados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAsociados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAsociados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAsociados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sabado,
            this.Domingo});
            this.grdAsociados.Location = new System.Drawing.Point(84, 48);
            this.grdAsociados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdAsociados.Name = "grdAsociados";
            this.grdAsociados.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAsociados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdAsociados.RowTemplate.Height = 24;
            this.grdAsociados.Size = new System.Drawing.Size(1077, 368);
            this.grdAsociados.TabIndex = 7;
            this.grdAsociados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdAsociados_CellFormatting);
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Hora.DataPropertyName = "Hora";
            this.Hora.FillWeight = 120F;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hora.Width = 57;
            // 
            // Lunes
            // 
            this.Lunes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lunes.DataPropertyName = "Lunes";
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            this.Lunes.ReadOnly = true;
            this.Lunes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lunes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Martes
            // 
            this.Martes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Martes.DataPropertyName = "Martes";
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            this.Martes.ReadOnly = true;
            this.Martes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Martes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Miercoles
            // 
            this.Miercoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Miercoles.DataPropertyName = "Miercoles";
            this.Miercoles.HeaderText = "Miércoles";
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.ReadOnly = true;
            this.Miercoles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Miercoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Jueves
            // 
            this.Jueves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jueves.DataPropertyName = "Jueves";
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            this.Jueves.ReadOnly = true;
            this.Jueves.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Jueves.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Viernes
            // 
            this.Viernes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Viernes.DataPropertyName = "Viernes";
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            this.Viernes.ReadOnly = true;
            this.Viernes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Viernes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sabado
            // 
            this.Sabado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sabado.DataPropertyName = "Sabado";
            this.Sabado.HeaderText = "Sábado";
            this.Sabado.Name = "Sabado";
            this.Sabado.ReadOnly = true;
            this.Sabado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Domingo
            // 
            this.Domingo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Domingo.DataPropertyName = "Domingo";
            this.Domingo.HeaderText = "Domingo";
            this.Domingo.Name = "Domingo";
            this.Domingo.ReadOnly = true;
            this.Domingo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(967, 454);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 42);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // HorarioProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1240, 560);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grdAsociados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HorarioProveedores";
            this.Text = "HorarioProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.grdAsociados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAsociados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
    }
}