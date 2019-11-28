namespace Hnos_Rojas
{
    partial class Ventas
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
            this.tabTicket = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nmCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.btnCerrarTicket = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnArtComun = new System.Windows.Forms.Button();
            this.tabTicket.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTicket
            // 
            this.tabTicket.Controls.Add(this.tabPage1);
            this.tabTicket.Controls.Add(this.tabAgregar);
            this.tabTicket.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTicket.Location = new System.Drawing.Point(16, 217);
            this.tabTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabTicket.Name = "tabTicket";
            this.tabTicket.SelectedIndex = 0;
            this.tabTicket.Size = new System.Drawing.Size(1703, 551);
            this.tabTicket.TabIndex = 0;
            this.tabTicket.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1695, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ticket 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabAgregar
            // 
            this.tabAgregar.Location = new System.Drawing.Point(4, 32);
            this.tabAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAgregar.Size = new System.Drawing.Size(1695, 515);
            this.tabAgregar.TabIndex = 1;
            this.tabAgregar.Text = "+";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(21, 27);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(296, 41);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Codigo de producto:";
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(28, 140);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(256, 52);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "INS Productos";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(333, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(356, 41);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(691, 27);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(357, 43);
            this.btnAgregarProducto.TabIndex = 7;
            this.btnAgregarProducto.Text = "ENTER Agregar Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nmCantidad);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboUsuarios);
            this.panel1.Controls.Add(this.btnCerrarTicket);
            this.panel1.Controls.Add(this.btnPago);
            this.panel1.Controls.Add(this.btnArtComun);
            this.panel1.Controls.Add(this.btnAgregarProducto);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.btnProducto);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Location = new System.Drawing.Point(16, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1701, 206);
            this.panel1.TabIndex = 8;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(1395, 149);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(297, 47);
            this.txtContrasena.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1543, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 41);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1052, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 52);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reimprimir Factura";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmCantidad
            // 
            this.nmCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCantidad.Location = new System.Drawing.Point(333, 80);
            this.nmCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCantidad.Name = "nmCantidad";
            this.nmCantidad.Size = new System.Drawing.Size(92, 41);
            this.nmCantidad.TabIndex = 17;
            this.nmCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmCantidad_KeyDown);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(179, 79);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(144, 41);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1473, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario actual";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(1395, 43);
            this.cboUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(297, 44);
            this.cboUsuarios.TabIndex = 11;
            this.cboUsuarios.SelectionChangeCommitted += new System.EventHandler(this.cboUsuarios_SelectionChangeCommitted);
            // 
            // btnCerrarTicket
            // 
            this.btnCerrarTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnCerrarTicket.FlatAppearance.BorderSize = 0;
            this.btnCerrarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarTicket.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnCerrarTicket.ForeColor = System.Drawing.Color.White;
            this.btnCerrarTicket.Location = new System.Drawing.Point(796, 140);
            this.btnCerrarTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarTicket.Name = "btnCerrarTicket";
            this.btnCerrarTicket.Size = new System.Drawing.Size(256, 52);
            this.btnCerrarTicket.TabIndex = 10;
            this.btnCerrarTicket.Text = "Cerrar Ticket";
            this.btnCerrarTicket.UseVisualStyleBackColor = false;
            this.btnCerrarTicket.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnPago.ForeColor = System.Drawing.Color.White;
            this.btnPago.Location = new System.Drawing.Point(540, 140);
            this.btnPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(256, 52);
            this.btnPago.TabIndex = 9;
            this.btnPago.Text = "F10 Pagos";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnArtComun
            // 
            this.btnArtComun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnArtComun.FlatAppearance.BorderSize = 0;
            this.btnArtComun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtComun.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnArtComun.ForeColor = System.Drawing.Color.White;
            this.btnArtComun.Location = new System.Drawing.Point(284, 140);
            this.btnArtComun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArtComun.Name = "btnArtComun";
            this.btnArtComun.Size = new System.Drawing.Size(256, 52);
            this.btnArtComun.TabIndex = 8;
            this.btnArtComun.Text = "CTRL+P Art. Común";
            this.btnArtComun.UseVisualStyleBackColor = false;
            this.btnArtComun.Click += new System.EventHandler(this.btnArtComun_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1735, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ventas";
            this.Text = "test";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventas_KeyDown);
            this.tabTicket.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTicket;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarTicket;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnArtComun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nmCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
    }
}