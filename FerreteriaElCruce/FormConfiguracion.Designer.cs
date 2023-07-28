namespace FerreteriaElCruce
{
    partial class FormConfiguracion
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
            this.pnlPantallasConfg = new System.Windows.Forms.Panel();
            this.lnkAltaProducto = new System.Windows.Forms.LinkLabel();
            this.lnkModificarProducto = new System.Windows.Forms.LinkLabel();
            this.lnkModModPrecioMas = new System.Windows.Forms.LinkLabel();
            this.lnkPdfCodigos = new System.Windows.Forms.LinkLabel();
            this.lnkUsuarios = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pnlPantallasConfg
            // 
            this.pnlPantallasConfg.Location = new System.Drawing.Point(332, 2);
            this.pnlPantallasConfg.Name = "pnlPantallasConfg";
            this.pnlPantallasConfg.Size = new System.Drawing.Size(800, 537);
            this.pnlPantallasConfg.TabIndex = 0;
            // 
            // lnkAltaProducto
            // 
            this.lnkAltaProducto.AutoSize = true;
            this.lnkAltaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAltaProducto.Location = new System.Drawing.Point(11, 27);
            this.lnkAltaProducto.Name = "lnkAltaProducto";
            this.lnkAltaProducto.Size = new System.Drawing.Size(129, 25);
            this.lnkAltaProducto.TabIndex = 1;
            this.lnkAltaProducto.TabStop = true;
            this.lnkAltaProducto.Text = "Alta Producto";
            this.lnkAltaProducto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAltaProducto_LinkClicked);
            // 
            // lnkModificarProducto
            // 
            this.lnkModificarProducto.AutoSize = true;
            this.lnkModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lnkModificarProducto.Location = new System.Drawing.Point(11, 80);
            this.lnkModificarProducto.Name = "lnkModificarProducto";
            this.lnkModificarProducto.Size = new System.Drawing.Size(174, 25);
            this.lnkModificarProducto.TabIndex = 2;
            this.lnkModificarProducto.TabStop = true;
            this.lnkModificarProducto.Text = "Modificar Producto";
            this.lnkModificarProducto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkModificarProducto_LinkClicked);
            // 
            // lnkModModPrecioMas
            // 
            this.lnkModModPrecioMas.AutoSize = true;
            this.lnkModModPrecioMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lnkModModPrecioMas.Location = new System.Drawing.Point(11, 138);
            this.lnkModModPrecioMas.Name = "lnkModModPrecioMas";
            this.lnkModModPrecioMas.Size = new System.Drawing.Size(195, 25);
            this.lnkModModPrecioMas.TabIndex = 3;
            this.lnkModModPrecioMas.TabStop = true;
            this.lnkModModPrecioMas.Text = "Modificar $/C masivo";
            this.lnkModModPrecioMas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkModModPrecioMas_LinkClicked);
            // 
            // lnkPdfCodigos
            // 
            this.lnkPdfCodigos.AutoSize = true;
            this.lnkPdfCodigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lnkPdfCodigos.Location = new System.Drawing.Point(11, 249);
            this.lnkPdfCodigos.Name = "lnkPdfCodigos";
            this.lnkPdfCodigos.Size = new System.Drawing.Size(300, 25);
            this.lnkPdfCodigos.TabIndex = 4;
            this.lnkPdfCodigos.TabStop = true;
            this.lnkPdfCodigos.Text = "Descargar Códigos de Productos";
            this.lnkPdfCodigos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPdfCodigos_LinkClicked);
            // 
            // lnkUsuarios
            // 
            this.lnkUsuarios.AutoSize = true;
            this.lnkUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lnkUsuarios.Location = new System.Drawing.Point(12, 190);
            this.lnkUsuarios.Name = "lnkUsuarios";
            this.lnkUsuarios.Size = new System.Drawing.Size(179, 25);
            this.lnkUsuarios.TabIndex = 5;
            this.lnkUsuarios.TabStop = true;
            this.lnkUsuarios.Text = "Admin. de usuarios";
            this.lnkUsuarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUsuarios_LinkClicked);
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1134, 537);
            this.Controls.Add(this.lnkUsuarios);
            this.Controls.Add(this.lnkPdfCodigos);
            this.Controls.Add(this.lnkModModPrecioMas);
            this.Controls.Add(this.lnkModificarProducto);
            this.Controls.Add(this.lnkAltaProducto);
            this.Controls.Add(this.pnlPantallasConfg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConfiguracion_FormClosed);
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPantallasConfg;
        private System.Windows.Forms.LinkLabel lnkAltaProducto;
        private System.Windows.Forms.LinkLabel lnkModificarProducto;
        private System.Windows.Forms.LinkLabel lnkModModPrecioMas;
        private System.Windows.Forms.LinkLabel lnkPdfCodigos;
        private System.Windows.Forms.LinkLabel lnkUsuarios;
    }
}