namespace Hnos_Rojas
{
    partial class NuevoProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlProducto = new System.Windows.Forms.TabControl();
            this.tpFormulario = new System.Windows.Forms.TabPage();
            this.btGuardar = new System.Windows.Forms.Button();
            this.nUDGanancia = new System.Windows.Forms.NumericUpDown();
            this.btCalcular = new System.Windows.Forms.Button();
            this.tbCantidadDisponible = new System.Windows.Forms.TextBox();
            this.tbPrecioVenta = new System.Windows.Forms.TextBox();
            this.tbPrecioCosto = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblCantidadDisponible = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tpModificar = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbBuscarCodigo = new System.Windows.Forms.TextBox();
            this.tabControlProducto.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGanancia)).BeginInit();
            this.tpModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProducto
            // 
            this.tabControlProducto.Controls.Add(this.tpFormulario);
            this.tabControlProducto.Controls.Add(this.tpModificar);
            this.tabControlProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProducto.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlProducto.Location = new System.Drawing.Point(0, 0);
            this.tabControlProducto.Name = "tabControlProducto";
            this.tabControlProducto.SelectedIndex = 0;
            this.tabControlProducto.Size = new System.Drawing.Size(1028, 549);
            this.tabControlProducto.TabIndex = 0;
            this.tabControlProducto.SelectedIndexChanged += new System.EventHandler(this.tabControlProducto_SelectedIndexChanged);
            // 
            // tpFormulario
            // 
            this.tpFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.tpFormulario.Controls.Add(this.btGuardar);
            this.tpFormulario.Controls.Add(this.nUDGanancia);
            this.tpFormulario.Controls.Add(this.btCalcular);
            this.tpFormulario.Controls.Add(this.tbCantidadDisponible);
            this.tpFormulario.Controls.Add(this.tbPrecioVenta);
            this.tpFormulario.Controls.Add(this.tbPrecioCosto);
            this.tpFormulario.Controls.Add(this.tbDescripcion);
            this.tpFormulario.Controls.Add(this.tbCodigo);
            this.tpFormulario.Controls.Add(this.lblCantidadDisponible);
            this.tpFormulario.Controls.Add(this.lblPrecioVenta);
            this.tpFormulario.Controls.Add(this.lblPorcentaje);
            this.tpFormulario.Controls.Add(this.lblPrecioCosto);
            this.tpFormulario.Controls.Add(this.lblDescripcion);
            this.tpFormulario.Controls.Add(this.lblCodigo);
            this.tpFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFormulario.Location = new System.Drawing.Point(4, 41);
            this.tpFormulario.Name = "tpFormulario";
            this.tpFormulario.Size = new System.Drawing.Size(1020, 504);
            this.tpFormulario.TabIndex = 0;
            this.tpFormulario.Text = "Datos del Producto";
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btGuardar.FlatAppearance.BorderSize = 0;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(398, 396);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(406, 54);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // nUDGanancia
            // 
            this.nUDGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDGanancia.Location = new System.Drawing.Point(548, 215);
            this.nUDGanancia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUDGanancia.Name = "nUDGanancia";
            this.nUDGanancia.Size = new System.Drawing.Size(81, 35);
            this.nUDGanancia.TabIndex = 3;
            this.nUDGanancia.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btCalcular.FlatAppearance.BorderSize = 0;
            this.btCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalcular.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.Color.White;
            this.btCalcular.Location = new System.Drawing.Point(635, 209);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(129, 43);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // tbCantidadDisponible
            // 
            this.tbCantidadDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidadDisponible.Location = new System.Drawing.Point(548, 323);
            this.tbCantidadDisponible.Name = "tbCantidadDisponible";
            this.tbCantidadDisponible.Size = new System.Drawing.Size(54, 35);
            this.tbCantidadDisponible.TabIndex = 5;
            this.tbCantidadDisponible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidadDisponible_KeyPress);
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioVenta.Location = new System.Drawing.Point(548, 276);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.Size = new System.Drawing.Size(113, 35);
            this.tbPrecioVenta.TabIndex = 4;
            this.tbPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioVenta_KeyPress);
            // 
            // tbPrecioCosto
            // 
            this.tbPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioCosto.Location = new System.Drawing.Point(548, 161);
            this.tbPrecioCosto.Name = "tbPrecioCosto";
            this.tbPrecioCosto.Size = new System.Drawing.Size(113, 35);
            this.tbPrecioCosto.TabIndex = 2;
            this.tbPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioCosto_KeyPress);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(548, 112);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(256, 35);
            this.tbDescripcion.TabIndex = 1;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(548, 63);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(256, 35);
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblCantidadDisponible.ForeColor = System.Drawing.Color.White;
            this.lblCantidadDisponible.Location = new System.Drawing.Point(392, 323);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(115, 32);
            this.lblCantidadDisponible.TabIndex = 13;
            this.lblCantidadDisponible.Text = "Cantidad:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.lblPrecioVenta.Location = new System.Drawing.Point(392, 276);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(154, 32);
            this.lblPrecioVenta.TabIndex = 12;
            this.lblPrecioVenta.Text = "Precio Venta:";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.White;
            this.lblPorcentaje.Location = new System.Drawing.Point(392, 220);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(142, 32);
            this.lblPorcentaje.TabIndex = 11;
            this.lblPorcentaje.Text = "% ganancia:";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblPrecioCosto.ForeColor = System.Drawing.Color.White;
            this.lblPrecioCosto.Location = new System.Drawing.Point(392, 161);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(153, 32);
            this.lblPrecioCosto.TabIndex = 10;
            this.lblPrecioCosto.Text = "Precio Costo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(392, 112);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(144, 32);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(392, 63);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(97, 32);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código:";
            // 
            // tpModificar
            // 
            this.tpModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.tpModificar.Controls.Add(this.pictureBox1);
            this.tpModificar.Controls.Add(this.dgvProductos);
            this.tpModificar.Controls.Add(this.btBuscar);
            this.tpModificar.Controls.Add(this.tbBuscarCodigo);
            this.tpModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpModificar.Location = new System.Drawing.Point(4, 41);
            this.tpModificar.Name = "tpModificar";
            this.tpModificar.Size = new System.Drawing.Size(1020, 504);
            this.tpModificar.TabIndex = 1;
            this.tpModificar.Text = "Modificar Producto";
            this.tpModificar.Click += new System.EventHandler(this.tpModificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hnos_Rojas.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(356, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.codigo,
            this.Descripcion,
            this.PrecioCosto,
            this.PrecioVenta,
            this.CantidadDisponible,
            this.CantidadMinima});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductos.Location = new System.Drawing.Point(0, 152);
            this.dgvProductos.MinimumSize = new System.Drawing.Size(973, 325);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1020, 352);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Image = global::Hnos_Rojas.Properties.Resources.output_onlinepngtools;
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.DataPropertyName = "precioCosto";
            this.PrecioCosto.HeaderText = "Precio Costo";
            this.PrecioCosto.Name = "PrecioCosto";
            this.PrecioCosto.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "precioVenta";
            this.PrecioVenta.HeaderText = "Precio venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // CantidadDisponible
            // 
            this.CantidadDisponible.DataPropertyName = "cantidadDisponible";
            this.CantidadDisponible.HeaderText = "Cantidad disponible";
            this.CantidadDisponible.Name = "CantidadDisponible";
            this.CantidadDisponible.ReadOnly = true;
            // 
            // CantidadMinima
            // 
            this.CantidadMinima.DataPropertyName = "cantMinBodega";
            this.CantidadMinima.HeaderText = "Cantidad mínima";
            this.CantidadMinima.Name = "CantidadMinima";
            this.CantidadMinima.ReadOnly = true;
            this.CantidadMinima.Visible = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.White;
            this.btBuscar.Location = new System.Drawing.Point(553, 71);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(114, 52);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbBuscarCodigo
            // 
            this.tbBuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarCodigo.Location = new System.Drawing.Point(476, 30);
            this.tbBuscarCodigo.Name = "tbBuscarCodigo";
            this.tbBuscarCodigo.Size = new System.Drawing.Size(191, 35);
            this.tbBuscarCodigo.TabIndex = 1;
            this.tbBuscarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarCodigo_KeyPress);
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1028, 549);
            this.Controls.Add(this.tabControlProducto);
            this.Name = "NuevoProducto";
            this.Text = "Administrar Productos";
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.tabControlProducto.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.tpFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGanancia)).EndInit();
            this.tpModificar.ResumeLayout(false);
            this.tpModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProducto;
        private System.Windows.Forms.TabPage tpFormulario;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCantidadDisponible;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.TextBox tbPrecioCosto;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbCantidadDisponible;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.NumericUpDown nUDGanancia;
        private System.Windows.Forms.TabPage tpModificar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbBuscarCodigo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMinima;
    }
}