namespace FerreteriaElCruce
{
    partial class FormSesion
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.picLogoUser = new System.Windows.Forms.PictureBox();
            this.lblErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSalir.Location = new System.Drawing.Point(272, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(302, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnIniciar.Location = new System.Drawing.Point(272, 266);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(302, 35);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(129, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(166, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtContrasenia.Location = new System.Drawing.Point(272, 210);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(302, 32);
            this.txtContrasenia.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtUsuario.Location = new System.Drawing.Point(272, 163);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(302, 32);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // picLogoUser
            // 
            this.picLogoUser.Image = global::FerreteriaElCruce.Properties.Resources.profile_icon_login_head_icon_vector;
            this.picLogoUser.Location = new System.Drawing.Point(319, 61);
            this.picLogoUser.Name = "picLogoUser";
            this.picLogoUser.Size = new System.Drawing.Size(227, 96);
            this.picLogoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoUser.TabIndex = 6;
            this.picLogoUser.TabStop = false;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblErr.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErr.Location = new System.Drawing.Point(596, 163);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(188, 26);
            this.lblErr.TabIndex = 7;
            this.lblErr.Text = "Usuario incorrecto";
            this.lblErr.Visible = false;
            // 
            // FormSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(805, 443);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.picLogoUser);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.FormSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox picLogoUser;
        private System.Windows.Forms.Label lblErr;
    }
}