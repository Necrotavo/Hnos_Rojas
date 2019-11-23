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
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tbCantidadDisponible = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.cbProductoEnInventario = new System.Windows.Forms.CheckBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.nUDGanancia = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabProductos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGanancia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.tabPage1);
            this.tabProductos.Controls.Add(this.tabPage2);
            this.tabProductos.Location = new System.Drawing.Point(1, 2);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(433, 304);
            this.tabProductos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nUDGanancia);
            this.tabPage1.Controls.Add(this.btCalcular);
            this.tabPage1.Controls.Add(this.cbProductoEnInventario);
            this.tabPage1.Controls.Add(this.tbCantidadDisponible);
            this.tabPage1.Controls.Add(this.tbPrecioVenta);
            this.tabPage1.Controls.Add(this.tbPrecioCosto);
            this.tabPage1.Controls.Add(this.tbDescripcion);
            this.tabPage1.Controls.Add(this.tbCodigo);
            this.tabPage1.Controls.Add(this.lblCantidadDisponible);
            this.tabPage1.Controls.Add(this.lblProductoInventario);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lblPrecioVenta);
            this.tabPage1.Controls.Add(this.lblPorcentaje);
            this.tabPage1.Controls.Add(this.lblPrecioCosto);
            this.tabPage1.Controls.Add(this.lblDescripcion);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(425, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Formulario";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tbCantidadDisponible
            // 
            this.tbCantidadDisponible.Location = new System.Drawing.Point(159, 239);
            this.tbCantidadDisponible.Name = "tbCantidadDisponible";
            this.tbCantidadDisponible.Size = new System.Drawing.Size(54, 20);
            this.tbCantidadDisponible.TabIndex = 15;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(332, 308);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(88, 32);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // cbProductoEnInventario
            // 
            this.cbProductoEnInventario.AutoSize = true;
            this.cbProductoEnInventario.Location = new System.Drawing.Point(278, 208);
            this.cbProductoEnInventario.Name = "cbProductoEnInventario";
            this.cbProductoEnInventario.Size = new System.Drawing.Size(15, 14);
            this.cbProductoEnInventario.TabIndex = 16;
            this.cbProductoEnInventario.UseVisualStyleBackColor = true;
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
            // nUDGanancia
            // 
            this.nUDGanancia.Location = new System.Drawing.Point(159, 116);
            this.nUDGanancia.Name = "nUDGanancia";
            this.nUDGanancia.Size = new System.Drawing.Size(81, 20);
            this.nUDGanancia.TabIndex = 18;
            this.nUDGanancia.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(425, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 341);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tabProductos);
            this.Name = "NuevoProducto";
            this.Text = "NuevoProducto";
            this.tabProductos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGanancia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage tabPage2;
    }
}