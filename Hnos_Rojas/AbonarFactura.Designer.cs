namespace Hnos_Rojas
{
    partial class AbonarFactura
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
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblSaldoAbono = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMontoAbono = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(343, 180);
            this.txtAbono.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(198, 41);
            this.txtAbono.TabIndex = 25;
            this.txtAbono.TextChanged += new System.EventHandler(this.txtAbono_TextChanged);
            this.txtAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbono_KeyPress);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(336, 316);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 41);
            this.lblSaldo.TabIndex = 24;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(177, 401);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(230, 59);
            this.btnPagar.TabIndex = 23;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblSaldoAbono
            // 
            this.lblSaldoAbono.AutoSize = true;
            this.lblSaldoAbono.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblSaldoAbono.ForeColor = System.Drawing.Color.White;
            this.lblSaldoAbono.Location = new System.Drawing.Point(35, 316);
            this.lblSaldoAbono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoAbono.Name = "lblSaldoAbono";
            this.lblSaldoAbono.Size = new System.Drawing.Size(281, 41);
            this.lblSaldoAbono.TabIndex = 22;
            this.lblSaldoAbono.Text = "Saldo con el abono:";
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblSaldoActual.ForeColor = System.Drawing.Color.White;
            this.lblSaldoActual.Location = new System.Drawing.Point(336, 251);
            this.lblSaldoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(0, 41);
            this.lblSaldoActual.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Saldo actual:";
            // 
            // lblMontoAbono
            // 
            this.lblMontoAbono.AutoSize = true;
            this.lblMontoAbono.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblMontoAbono.ForeColor = System.Drawing.Color.White;
            this.lblMontoAbono.Location = new System.Drawing.Point(35, 180);
            this.lblMontoAbono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoAbono.Name = "lblMontoAbono";
            this.lblMontoAbono.Size = new System.Drawing.Size(258, 41);
            this.lblMontoAbono.TabIndex = 19;
            this.lblMontoAbono.Text = "Monto del abono:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(172, 33);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 41);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Abono a Factura";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(336, 115);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 41);
            this.lblCodigo.TabIndex = 27;
            // 
            // lblCodTxt
            // 
            this.lblCodTxt.AutoSize = true;
            this.lblCodTxt.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblCodTxt.ForeColor = System.Drawing.Color.White;
            this.lblCodTxt.Location = new System.Drawing.Point(35, 115);
            this.lblCodTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodTxt.Name = "lblCodTxt";
            this.lblCodTxt.Size = new System.Drawing.Size(269, 41);
            this.lblCodTxt.TabIndex = 26;
            this.lblCodTxt.Text = "Código de Factura:";
            // 
            // AbonarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(576, 511);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCodTxt);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblSaldoAbono);
            this.Controls.Add(this.lblSaldoActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMontoAbono);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AbonarFactura";
            this.Text = "AbonarFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblSaldoAbono;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMontoAbono;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodTxt;
    }
}