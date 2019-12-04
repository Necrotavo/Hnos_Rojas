namespace Hnos_Rojas
{
    partial class MensajeError
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
            this.lbMensajeError = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMensajeError
            // 
            this.lbMensajeError.AutoSize = true;
            this.lbMensajeError.Location = new System.Drawing.Point(76, 85);
            this.lbMensajeError.Name = "lbMensajeError";
            this.lbMensajeError.Size = new System.Drawing.Size(57, 13);
            this.lbMensajeError.TabIndex = 0;
            this.lbMensajeError.Text = "MENSAJE";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(250, 187);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // MensajeError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 222);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbMensajeError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MensajeError";
            this.Text = "MensajeError";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMensajeError;
        private System.Windows.Forms.Button btnAceptar;
    }
}