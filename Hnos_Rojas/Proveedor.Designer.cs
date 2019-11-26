namespace Hnos_Rojas
{
    partial class Proveedor
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
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.btnAsociados = new System.Windows.Forms.Button();
            this.btnInsModProv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelProveedores
            // 
            this.panelProveedores.Location = new System.Drawing.Point(32, 102);
            this.panelProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(1673, 684);
            this.panelProveedores.TabIndex = 20;
            // 
            // btnAsociados
            // 
            this.btnAsociados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnAsociados.FlatAppearance.BorderSize = 0;
            this.btnAsociados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsociados.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnAsociados.ForeColor = System.Drawing.Color.White;
            this.btnAsociados.Location = new System.Drawing.Point(32, 25);
            this.btnAsociados.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsociados.Name = "btnAsociados";
            this.btnAsociados.Size = new System.Drawing.Size(339, 52);
            this.btnAsociados.TabIndex = 21;
            this.btnAsociados.Text = "Ver Asociados";
            this.btnAsociados.UseVisualStyleBackColor = false;
            // 
            // btnInsModProv
            // 
            this.btnInsModProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnInsModProv.FlatAppearance.BorderSize = 0;
            this.btnInsModProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsModProv.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.btnInsModProv.ForeColor = System.Drawing.Color.White;
            this.btnInsModProv.Location = new System.Drawing.Point(698, 25);
            this.btnInsModProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsModProv.Name = "btnInsModProv";
            this.btnInsModProv.Size = new System.Drawing.Size(339, 52);
            this.btnInsModProv.TabIndex = 22;
            this.btnInsModProv.Text = "Insertar/Modificar Proveedor";
            this.btnInsModProv.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1366, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "Eliminar Proveedor";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1735, 814);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInsModProv);
            this.Controls.Add(this.btnAsociados);
            this.Controls.Add(this.panelProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(32, 102);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Button btnAsociados;
        private System.Windows.Forms.Button btnInsModProv;
        private System.Windows.Forms.Button button1;
    }
}