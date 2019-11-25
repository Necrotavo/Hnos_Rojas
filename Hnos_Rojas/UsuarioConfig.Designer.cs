namespace Hnos_Rojas
{
    partial class UsuarioConfig
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
            this.tabControlUsuarios = new System.Windows.Forms.TabControl();
            this.tabCrearUsuario = new System.Windows.Forms.TabPage();
            this.btnUsuariosConf = new System.Windows.Forms.Button();
            this.txtNombreUsuarioCrear = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtContrasenaCrear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabControlUsuarios.SuspendLayout();
            this.tabCrearUsuario.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUsuarios
            // 
            this.tabControlUsuarios.Controls.Add(this.tabCrearUsuario);
            this.tabControlUsuarios.Controls.Add(this.tabPage2);
            this.tabControlUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUsuarios.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.tabControlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tabControlUsuarios.Name = "tabControlUsuarios";
            this.tabControlUsuarios.SelectedIndex = 0;
            this.tabControlUsuarios.Size = new System.Drawing.Size(1057, 622);
            this.tabControlUsuarios.TabIndex = 0;
            // 
            // tabCrearUsuario
            // 
            this.tabCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.tabCrearUsuario.Controls.Add(this.btnUsuariosConf);
            this.tabCrearUsuario.Controls.Add(this.txtNombreUsuarioCrear);
            this.tabCrearUsuario.Controls.Add(this.lblPassword);
            this.tabCrearUsuario.Controls.Add(this.txtContrasenaCrear);
            this.tabCrearUsuario.Controls.Add(this.label1);
            this.tabCrearUsuario.Location = new System.Drawing.Point(4, 41);
            this.tabCrearUsuario.Name = "tabCrearUsuario";
            this.tabCrearUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearUsuario.Size = new System.Drawing.Size(1049, 577);
            this.tabCrearUsuario.TabIndex = 0;
            this.tabCrearUsuario.Text = "Crear Usuario";
            // 
            // btnUsuariosConf
            // 
            this.btnUsuariosConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.btnUsuariosConf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUsuariosConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosConf.Font = new System.Drawing.Font("Segoe UI Historic", 40F);
            this.btnUsuariosConf.ForeColor = System.Drawing.Color.White;
            this.btnUsuariosConf.Location = new System.Drawing.Point(3, 368);
            this.btnUsuariosConf.Name = "btnUsuariosConf";
            this.btnUsuariosConf.Size = new System.Drawing.Size(1043, 206);
            this.btnUsuariosConf.TabIndex = 21;
            this.btnUsuariosConf.Text = "Guardar";
            this.btnUsuariosConf.UseVisualStyleBackColor = false;
            this.btnUsuariosConf.Click += new System.EventHandler(this.btnUsuariosConf_Click);
            // 
            // txtNombreUsuarioCrear
            // 
            this.txtNombreUsuarioCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuarioCrear.Location = new System.Drawing.Point(404, 147);
            this.txtNombreUsuarioCrear.Name = "txtNombreUsuarioCrear";
            this.txtNombreUsuarioCrear.Size = new System.Drawing.Size(239, 35);
            this.txtNombreUsuarioCrear.TabIndex = 20;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(398, 235);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(140, 32);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtContrasenaCrear
            // 
            this.txtContrasenaCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaCrear.Location = new System.Drawing.Point(404, 270);
            this.txtContrasenaCrear.Name = "txtContrasenaCrear";
            this.txtContrasenaCrear.Size = new System.Drawing.Size(239, 35);
            this.txtContrasenaCrear.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre de usuario:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtContrasena);
            this.tabPage2.Controls.Add(this.listBoxUsuarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1049, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(377, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(383, 315);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(283, 35);
            this.txtContrasena.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 40F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(521, 174);
            this.button1.TabIndex = 22;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.ItemHeight = 32;
            this.listBoxUsuarios.Location = new System.Drawing.Point(383, 137);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(283, 132);
            this.listBoxUsuarios.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 174);
            this.panel1.TabIndex = 25;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Historic", 40F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(522, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(521, 174);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // UsuarioConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 622);
            this.Controls.Add(this.tabControlUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioConfig";
            this.Text = "UsuarioConfig";
            this.tabControlUsuarios.ResumeLayout(false);
            this.tabCrearUsuario.ResumeLayout(false);
            this.tabCrearUsuario.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUsuarios;
        private System.Windows.Forms.TabPage tabCrearUsuario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNombreUsuarioCrear;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtContrasenaCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuariosConf;
        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
    }
}