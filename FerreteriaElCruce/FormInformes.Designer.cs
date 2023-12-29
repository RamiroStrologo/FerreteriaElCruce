namespace FerreteriaElCruce
{
    partial class FormInformesComprasVentas
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
            this.tabInformes = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.lnkDescargarPdfV = new System.Windows.Forms.LinkLabel();
            this.lblTV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBV = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNV = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.rtbTopVentas = new System.Windows.Forms.RichTextBox();
            this.tabCompras = new System.Windows.Forms.TabPage();
            this.lnkDescargaPdf = new System.Windows.Forms.LinkLabel();
            this.lblT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbTopCompras = new System.Windows.Forms.RichTextBox();
            this.dtpPeriodoFin = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodoIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabInformes.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabCompras.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInformes
            // 
            this.tabInformes.Controls.Add(this.tabVentas);
            this.tabInformes.Controls.Add(this.tabCompras);
            this.tabInformes.Location = new System.Drawing.Point(6, 44);
            this.tabInformes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabInformes.Name = "tabInformes";
            this.tabInformes.SelectedIndex = 0;
            this.tabInformes.Size = new System.Drawing.Size(1341, 640);
            this.tabInformes.TabIndex = 0;
            // 
            // tabVentas
            // 
            this.tabVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabVentas.Controls.Add(this.lnkDescargarPdfV);
            this.tabVentas.Controls.Add(this.lblTV);
            this.tabVentas.Controls.Add(this.label5);
            this.tabVentas.Controls.Add(this.lblBV);
            this.tabVentas.Controls.Add(this.label9);
            this.tabVentas.Controls.Add(this.lblNV);
            this.tabVentas.Controls.Add(this.lbl11);
            this.tabVentas.Controls.Add(this.rtbTopVentas);
            this.tabVentas.Location = new System.Drawing.Point(4, 34);
            this.tabVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabVentas.Size = new System.Drawing.Size(1333, 602);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            // 
            // lnkDescargarPdfV
            // 
            this.lnkDescargarPdfV.AutoSize = true;
            this.lnkDescargarPdfV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lnkDescargarPdfV.Location = new System.Drawing.Point(488, 4);
            this.lnkDescargarPdfV.Name = "lnkDescargarPdfV";
            this.lnkDescargarPdfV.Size = new System.Drawing.Size(160, 26);
            this.lnkDescargarPdfV.TabIndex = 16;
            this.lnkDescargarPdfV.TabStop = true;
            this.lnkDescargarPdfV.Text = "Descargar todo";
            this.lnkDescargarPdfV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDescargarPdfV_LinkClicked);
            // 
            // lblTV
            // 
            this.lblTV.AutoSize = true;
            this.lblTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTV.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTV.Location = new System.Drawing.Point(6, 347);
            this.lblTV.Name = "lblTV";
            this.lblTV.Size = new System.Drawing.Size(72, 26);
            this.lblTV.TabIndex = 15;
            this.lblTV.Text = "$0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(6, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total de ventas:";
            // 
            // lblBV
            // 
            this.lblBV.AutoSize = true;
            this.lblBV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblBV.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblBV.Location = new System.Drawing.Point(6, 230);
            this.lblBV.Name = "lblBV";
            this.lblBV.Size = new System.Drawing.Size(72, 26);
            this.lblBV.TabIndex = 13;
            this.lblBV.Text = "$0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(6, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total de ventas en blanco:";
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNV.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblNV.Location = new System.Drawing.Point(6, 118);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(72, 26);
            this.lblNV.TabIndex = 11;
            this.lblNV.Text = "$0000";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl11.Location = new System.Drawing.Point(6, 83);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(256, 26);
            this.lbl11.TabIndex = 10;
            this.lbl11.Text = "Total de ventas en negro:";
            // 
            // rtbTopVentas
            // 
            this.rtbTopVentas.BackColor = System.Drawing.SystemColors.Control;
            this.rtbTopVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rtbTopVentas.Location = new System.Drawing.Point(493, 59);
            this.rtbTopVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbTopVentas.Name = "rtbTopVentas";
            this.rtbTopVentas.ReadOnly = true;
            this.rtbTopVentas.Size = new System.Drawing.Size(809, 482);
            this.rtbTopVentas.TabIndex = 9;
            this.rtbTopVentas.Text = "";
            // 
            // tabCompras
            // 
            this.tabCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCompras.Controls.Add(this.lnkDescargaPdf);
            this.tabCompras.Controls.Add(this.lblT);
            this.tabCompras.Controls.Add(this.label8);
            this.tabCompras.Controls.Add(this.lblB);
            this.tabCompras.Controls.Add(this.label6);
            this.tabCompras.Controls.Add(this.lblN);
            this.tabCompras.Controls.Add(this.label3);
            this.tabCompras.Controls.Add(this.rtbTopCompras);
            this.tabCompras.Location = new System.Drawing.Point(4, 34);
            this.tabCompras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCompras.Size = new System.Drawing.Size(1333, 599);
            this.tabCompras.TabIndex = 2;
            this.tabCompras.Text = "Compras";
            // 
            // lnkDescargaPdf
            // 
            this.lnkDescargaPdf.AutoSize = true;
            this.lnkDescargaPdf.Location = new System.Drawing.Point(487, 4);
            this.lnkDescargaPdf.Name = "lnkDescargaPdf";
            this.lnkDescargaPdf.Size = new System.Drawing.Size(160, 26);
            this.lnkDescargaPdf.TabIndex = 8;
            this.lnkDescargaPdf.TabStop = true;
            this.lnkDescargaPdf.Text = "Descargar todo";
            this.lnkDescargaPdf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDescargaPdf_LinkClicked);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblT.Location = new System.Drawing.Point(6, 347);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(72, 26);
            this.lblT.TabIndex = 7;
            this.lblT.Text = "$0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total de compras:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblB.Location = new System.Drawing.Point(6, 230);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(72, 26);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "$0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total de compras en blanco:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblN.Location = new System.Drawing.Point(6, 118);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(72, 26);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "$0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total de compras en negro:";
            // 
            // rtbTopCompras
            // 
            this.rtbTopCompras.BackColor = System.Drawing.SystemColors.Control;
            this.rtbTopCompras.Location = new System.Drawing.Point(492, 58);
            this.rtbTopCompras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbTopCompras.Name = "rtbTopCompras";
            this.rtbTopCompras.ReadOnly = true;
            this.rtbTopCompras.Size = new System.Drawing.Size(809, 482);
            this.rtbTopCompras.TabIndex = 1;
            this.rtbTopCompras.Text = "";
            // 
            // dtpPeriodoFin
            // 
            this.dtpPeriodoFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpPeriodoFin.Location = new System.Drawing.Point(760, 15);
            this.dtpPeriodoFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPeriodoFin.Name = "dtpPeriodoFin";
            this.dtpPeriodoFin.Size = new System.Drawing.Size(421, 32);
            this.dtpPeriodoFin.TabIndex = 0;
            this.dtpPeriodoFin.ValueChanged += new System.EventHandler(this.dtpPeriodoFin_ValueChange);
            this.dtpPeriodoFin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpPeriodoIni_MouseDown);
            // 
            // dtpPeriodoIni
            // 
            this.dtpPeriodoIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpPeriodoIni.Location = new System.Drawing.Point(197, 15);
            this.dtpPeriodoIni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPeriodoIni.Name = "dtpPeriodoIni";
            this.dtpPeriodoIni.Size = new System.Drawing.Size(421, 32);
            this.dtpPeriodoIni.TabIndex = 1;
            this.dtpPeriodoIni.ValueChanged += new System.EventHandler(this.dtpPeriodoIni_ValueChange);
            this.dtpPeriodoIni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpPeriodoIni_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Período:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(655, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "---";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabInformes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1366, 640);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informes:";
            // 
            // FormInformesComprasVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPeriodoFin);
            this.Controls.Add(this.dtpPeriodoIni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInformesComprasVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInformesComprasVentas_FormClosed);
            this.Load += new System.EventHandler(this.FormInformesComprasVentas_Load);
            this.tabInformes.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            this.tabCompras.ResumeLayout(false);
            this.tabCompras.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabInformes;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabCompras;
        private System.Windows.Forms.DateTimePicker dtpPeriodoFin;
        private System.Windows.Forms.DateTimePicker dtpPeriodoIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbTopCompras;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkDescargaPdf;
        private System.Windows.Forms.LinkLabel lnkDescargarPdfV;
        private System.Windows.Forms.Label lblTV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.RichTextBox rtbTopVentas;
    }
}