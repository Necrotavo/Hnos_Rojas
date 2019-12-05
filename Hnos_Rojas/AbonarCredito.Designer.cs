namespace Hnos_Rojas
{
    partial class AbonarCredito
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMontoAbono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMontoCredito = new System.Windows.Forms.Label();
            this.lblSaldoAbono = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(112, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 32);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Abono a Crédito";
            // 
            // lblMontoAbono
            // 
            this.lblMontoAbono.AutoSize = true;
            this.lblMontoAbono.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblMontoAbono.ForeColor = System.Drawing.Color.White;
            this.lblMontoAbono.Location = new System.Drawing.Point(26, 106);
            this.lblMontoAbono.Name = "lblMontoAbono";
            this.lblMontoAbono.Size = new System.Drawing.Size(207, 32);
            this.lblMontoAbono.TabIndex = 5;
            this.lblMontoAbono.Text = "Monto del abono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total del Crédito";
            // 
            // lblMontoCredito
            // 
            this.lblMontoCredito.AutoSize = true;
            this.lblMontoCredito.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblMontoCredito.ForeColor = System.Drawing.Color.White;
            this.lblMontoCredito.Location = new System.Drawing.Point(231, 165);
            this.lblMontoCredito.Name = "lblMontoCredito";
            this.lblMontoCredito.Size = new System.Drawing.Size(0, 32);
            this.lblMontoCredito.TabIndex = 8;
            // 
            // lblSaldoAbono
            // 
            this.lblSaldoAbono.AutoSize = true;
            this.lblSaldoAbono.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblSaldoAbono.ForeColor = System.Drawing.Color.White;
            this.lblSaldoAbono.Location = new System.Drawing.Point(26, 216);
            this.lblSaldoAbono.Name = "lblSaldoAbono";
            this.lblSaldoAbono.Size = new System.Drawing.Size(74, 32);
            this.lblSaldoAbono.TabIndex = 9;
            this.lblSaldoAbono.Text = "Saldo";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(118, 285);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(172, 48);
            this.btnPagar.TabIndex = 15;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(231, 217);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 32);
            this.lblSaldo.TabIndex = 16;
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(236, 106);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(150, 35);
            this.txtAbono.TabIndex = 17;
            this.txtAbono.TextChanged += new System.EventHandler(this.txtAbono_TextChanged);
            this.txtAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbono_KeyPress);
            // 
            // AbonarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(411, 362);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblSaldoAbono);
            this.Controls.Add(this.lblMontoCredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMontoAbono);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AbonarCredito";
            this.Text = "AbonarCredito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMontoAbono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMontoCredito;
        private System.Windows.Forms.Label lblSaldoAbono;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtAbono;
    }
}