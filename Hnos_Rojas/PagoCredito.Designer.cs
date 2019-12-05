namespace Hnos_Rojas
{
    partial class PagoCredito
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCreditoAnterior = new System.Windows.Forms.Label();
            this.lbCreditoDisp = new System.Windows.Forms.Label();
            this.listBClientes = new System.Windows.Forms.ListBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCredActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(429, 317);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(194, 42);
            this.btnPagar.TabIndex = 25;
            this.btnPagar.Text = "Asignar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Saldo actual:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Historic", 25F);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(490, 250);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 46);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "c0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Notas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-84, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre de cliente";
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(147, 280);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(239, 35);
            this.txtNotas.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, -46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 35);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cliente ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Saldo Anterior: ";
            // 
            // lbCreditoAnterior
            // 
            this.lbCreditoAnterior.AutoSize = true;
            this.lbCreditoAnterior.Font = new System.Drawing.Font("Segoe UI Historic", 25F);
            this.lbCreditoAnterior.ForeColor = System.Drawing.Color.White;
            this.lbCreditoAnterior.Location = new System.Drawing.Point(197, 317);
            this.lbCreditoAnterior.Name = "lbCreditoAnterior";
            this.lbCreditoAnterior.Size = new System.Drawing.Size(97, 46);
            this.lbCreditoAnterior.TabIndex = 29;
            this.lbCreditoAnterior.Text = "c0.00";
            // 
            // lbCreditoDisp
            // 
            this.lbCreditoDisp.AutoSize = true;
            this.lbCreditoDisp.Font = new System.Drawing.Font("Segoe UI Historic", 25F);
            this.lbCreditoDisp.ForeColor = System.Drawing.Color.White;
            this.lbCreditoDisp.Location = new System.Drawing.Point(289, 374);
            this.lbCreditoDisp.Name = "lbCreditoDisp";
            this.lbCreditoDisp.Size = new System.Drawing.Size(97, 46);
            this.lbCreditoDisp.TabIndex = 30;
            this.lbCreditoDisp.Text = "c0.00";
            this.lbCreditoDisp.Visible = false;
            // 
            // listBClientes
            // 
            this.listBClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBClientes.FormattingEnabled = true;
            this.listBClientes.ItemHeight = 25;
            this.listBClientes.Location = new System.Drawing.Point(147, 85);
            this.listBClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBClientes.Name = "listBClientes";
            this.listBClientes.Size = new System.Drawing.Size(239, 104);
            this.listBClientes.TabIndex = 31;
            this.listBClientes.Click += new System.EventHandler(this.listBClientes_Click);
            this.listBClientes.SelectedIndexChanged += new System.EventHandler(this.listBClientes_SelectedIndexChanged);
            this.listBClientes.SelectedValueChanged += new System.EventHandler(this.listBClientes_SelectedValueChanged);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(147, 21);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(239, 35);
            this.txtBuscarCliente.TabIndex = 32;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(429, 25);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(194, 42);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(429, 88);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(194, 42);
            this.btnAgregarCliente.TabIndex = 34;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(429, 373);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 42);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(407, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 32);
            this.label6.TabIndex = 36;
            this.label6.Text = "Total:";
            // 
            // lblCredActual
            // 
            this.lblCredActual.AutoSize = true;
            this.lblCredActual.Font = new System.Drawing.Font("Segoe UI Historic", 25F);
            this.lblCredActual.ForeColor = System.Drawing.Color.White;
            this.lblCredActual.Location = new System.Drawing.Point(197, 369);
            this.lblCredActual.Name = "lblCredActual";
            this.lblCredActual.Size = new System.Drawing.Size(97, 46);
            this.lblCredActual.TabIndex = 37;
            this.lblCredActual.Text = "c0.00";
            // 
            // PagoCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(636, 461);
            this.ControlBox = false;
            this.Controls.Add(this.lblCredActual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.listBClientes);
            this.Controls.Add(this.lbCreditoDisp);
            this.Controls.Add(this.lbCreditoAnterior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PagoCredito";
            this.Text = "Credito";
            this.Load += new System.EventHandler(this.PagoCredito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCreditoAnterior;
        private System.Windows.Forms.Label lbCreditoDisp;
        private System.Windows.Forms.ListBox listBClientes;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCredActual;
    }
}