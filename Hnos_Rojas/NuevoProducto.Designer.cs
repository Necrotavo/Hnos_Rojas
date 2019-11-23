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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlProducto = new System.Windows.Forms.TabControl();
            this.tpFormulario = new System.Windows.Forms.TabPage();
            this.btGuardar = new System.Windows.Forms.Button();
            this.nUDGanancia = new System.Windows.Forms.NumericUpDown();
            this.btCalcular = new System.Windows.Forms.Button();
            this.cbProductoEnInventario = new System.Windows.Forms.CheckBox();
            this.tbCantidadDisponible = new System.Windows.Forms.TextBox();
            this.tbPrecioVenta = new System.Windows.Forms.TextBox();
            this.tbPrecioCosto = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblCantidadDisponible = new System.Windows.Forms.Label();
            this.lblProductoInventario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tpModificar = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbBuscarCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tabControlProducto.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGanancia)).BeginInit();
            this.tpModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProducto
            // 
            this.tabControlProducto.Controls.Add(this.tpFormulario);
            this.tabControlProducto.Controls.Add(this.tpModificar);
            this.tabControlProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProducto.Location = new System.Drawing.Point(0, 0);
            this.tabControlProducto.Name = "tabControlProducto";
            this.tabControlProducto.SelectedIndex = 0;
            this.tabControlProducto.Size = new System.Drawing.Size(1229, 518);
            this.tabControlProducto.TabIndex = 0;
            // 
            // tpFormulario
            // 
            this.tpFormulario.Controls.Add(this.btGuardar);
            this.tpFormulario.Controls.Add(this.nUDGanancia);
            this.tpFormulario.Controls.Add(this.btCalcular);
            this.tpFormulario.Controls.Add(this.cbProductoEnInventario);
            this.tpFormulario.Controls.Add(this.tbCantidadDisponible);
            this.tpFormulario.Controls.Add(this.tbPrecioVenta);
            this.tpFormulario.Controls.Add(this.tbPrecioCosto);
            this.tpFormulario.Controls.Add(this.tbDescripcion);
            this.tpFormulario.Controls.Add(this.tbCodigo);
            this.tpFormulario.Controls.Add(this.lblCantidadDisponible);
            this.tpFormulario.Controls.Add(this.lblProductoInventario);
            this.tpFormulario.Controls.Add(this.panel1);
            this.tpFormulario.Controls.Add(this.lblPrecioVenta);
            this.tpFormulario.Controls.Add(this.lblPorcentaje);
            this.tpFormulario.Controls.Add(this.lblPrecioCosto);
            this.tpFormulario.Controls.Add(this.lblDescripcion);
            this.tpFormulario.Controls.Add(this.lblCodigo);
            this.tpFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFormulario.Location = new System.Drawing.Point(4, 22);
            this.tpFormulario.Name = "tpFormulario";
            this.tpFormulario.Size = new System.Drawing.Size(973, 500);
            this.tpFormulario.TabIndex = 0;
            this.tpFormulario.Text = "Formulario";
            this.tpFormulario.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(668, 273);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(88, 32);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // nUDGanancia
            // 
            this.nUDGanancia.Location = new System.Drawing.Point(159, 116);
            this.nUDGanancia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUDGanancia.Name = "nUDGanancia";
            this.nUDGanancia.Size = new System.Drawing.Size(81, 20);
            this.nUDGanancia.TabIndex = 18;
            this.nUDGanancia.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(257, 116);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(64, 20);
            this.btCalcular.TabIndex = 17;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // cbProductoEnInventario
            // 
            this.cbProductoEnInventario.AutoSize = true;
            this.cbProductoEnInventario.Checked = true;
            this.cbProductoEnInventario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbProductoEnInventario.Location = new System.Drawing.Point(278, 208);
            this.cbProductoEnInventario.Name = "cbProductoEnInventario";
            this.cbProductoEnInventario.Size = new System.Drawing.Size(15, 14);
            this.cbProductoEnInventario.TabIndex = 16;
            this.cbProductoEnInventario.UseVisualStyleBackColor = true;
            // 
            // tbCantidadDisponible
            // 
            this.tbCantidadDisponible.Location = new System.Drawing.Point(159, 239);
            this.tbCantidadDisponible.Name = "tbCantidadDisponible";
            this.tbCantidadDisponible.Size = new System.Drawing.Size(54, 20);
            this.tbCantidadDisponible.TabIndex = 15;
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.Location = new System.Drawing.Point(159, 148);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.Size = new System.Drawing.Size(113, 20);
            this.tbPrecioVenta.TabIndex = 13;
            // 
            // tbPrecioCosto
            // 
            this.tbPrecioCosto.Location = new System.Drawing.Point(159, 86);
            this.tbPrecioCosto.Name = "tbPrecioCosto";
            this.tbPrecioCosto.Size = new System.Drawing.Size(113, 20);
            this.tbPrecioCosto.TabIndex = 11;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(159, 51);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(256, 20);
            this.tbDescripcion.TabIndex = 10;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(159, 21);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(131, 20);
            this.tbCodigo.TabIndex = 9;
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Location = new System.Drawing.Point(3, 242);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(118, 13);
            this.lblCantidadDisponible.TabIndex = 8;
            this.lblCantidadDisponible.Text = "Cantidad disponible";
            // 
            // lblProductoInventario
            // 
            this.lblProductoInventario.AutoSize = true;
            this.lblProductoInventario.Location = new System.Drawing.Point(136, 208);
            this.lblProductoInventario.Name = "lblProductoInventario";
            this.lblProductoInventario.Size = new System.Drawing.Size(136, 13);
            this.lblProductoInventario.TabIndex = 6;
            this.lblProductoInventario.Text = "Producto en inventario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(121, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 10);
            this.panel1.TabIndex = 5;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(3, 148);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(80, 13);
            this.lblPrecioVenta.TabIndex = 4;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(3, 116);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(142, 13);
            this.lblPorcentaje.TabIndex = 3;
            this.lblPorcentaje.Text = "Porcentaje de ganancia";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Location = new System.Drawing.Point(3, 86);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioCosto.TabIndex = 2;
            this.lblPrecioCosto.Text = "Precio Costo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 51);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tpModificar
            // 
            this.tpModificar.Controls.Add(this.dgvProductos);
            this.tpModificar.Controls.Add(this.btBuscar);
            this.tpModificar.Controls.Add(this.tbBuscarCodigo);
            this.tpModificar.Controls.Add(this.lbCodigo);
            this.tpModificar.Location = new System.Drawing.Point(4, 22);
            this.tpModificar.Name = "tpModificar";
            this.tpModificar.Size = new System.Drawing.Size(1221, 492);
            this.tpModificar.TabIndex = 1;
            this.tpModificar.Text = "Modificar Producto";
            this.tpModificar.UseVisualStyleBackColor = true;
            this.tpModificar.Click += new System.EventHandler(this.tpModificar_Click);
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Modificar,
            this.Descripcion,
            this.PrecioCosto,
            this.PrecioVenta,
            this.CantidadDisponible,
            this.CantidadMinima});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductos.Location = new System.Drawing.Point(0, 167);
            this.dgvProductos.MinimumSize = new System.Drawing.Size(973, 325);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1221, 325);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
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
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(340, 100);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbBuscarCodigo
            // 
            this.tbBuscarCodigo.Location = new System.Drawing.Point(328, 65);
            this.tbBuscarCodigo.Name = "tbBuscarCodigo";
            this.tbBuscarCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbBuscarCodigo.TabIndex = 1;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(283, 37);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(197, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Ingrese el código o nombre del producto";
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 518);
            this.Controls.Add(this.tabControlProducto);
            this.Name = "NuevoProducto";
            this.Text = "NuevoProducto";
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.tabControlProducto.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.tpFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGanancia)).EndInit();
            this.tpModificar.ResumeLayout(false);
            this.tpModificar.PerformLayout();
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
        private System.Windows.Forms.Label lblProductoInventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.TextBox tbPrecioCosto;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbCantidadDisponible;
        private System.Windows.Forms.CheckBox cbProductoEnInventario;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.NumericUpDown nUDGanancia;
        private System.Windows.Forms.TabPage tpModificar;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbBuscarCodigo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMinima;
    }
}