namespace Hnos_Rojas
{
    partial class EstadoCuentaCliente
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
            this.listBClientes = new System.Windows.Forms.ListBox();
            this.txtEstadoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBClientes
            // 
            this.listBClientes.FormattingEnabled = true;
            this.listBClientes.ItemHeight = 16;
            this.listBClientes.Location = new System.Drawing.Point(23, 101);
            this.listBClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBClientes.Name = "listBClientes";
            this.listBClientes.Size = new System.Drawing.Size(423, 116);
            this.listBClientes.TabIndex = 0;
            this.listBClientes.Click += new System.EventHandler(this.listBClientes_Click);
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.Location = new System.Drawing.Point(23, 53);
            this.txtEstadoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.Size = new System.Drawing.Size(423, 22);
            this.txtEstadoCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el nombre o apellido del clliente";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(23, 248);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // EstadoCuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 491);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstadoCliente);
            this.Controls.Add(this.listBClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EstadoCuentaCliente";
            this.Text = "EstadoCuentaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBClientes;
        private System.Windows.Forms.TextBox txtEstadoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
    }
}