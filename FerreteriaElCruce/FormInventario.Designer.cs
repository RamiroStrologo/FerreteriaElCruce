﻿using System.Windows.Forms;

namespace FerreteriaElCruce
{
    partial class FormInventario
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
            this.components = new System.ComponentModel.Container();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.chkStockMinimo = new System.Windows.Forms.CheckBox();
            this.cmsProducto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_recargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.cmsProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(97, 22);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(230, 31);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(14, 69);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(1322, 548);
            this.dgvInventario.TabIndex = 1;
            this.dgvInventario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvInventario_MouseDown);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(1214, 16);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(114, 45);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // chkStockMinimo
            // 
            this.chkStockMinimo.AutoSize = true;
            this.chkStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStockMinimo.Location = new System.Drawing.Point(344, 20);
            this.chkStockMinimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkStockMinimo.Name = "chkStockMinimo";
            this.chkStockMinimo.Size = new System.Drawing.Size(167, 29);
            this.chkStockMinimo.TabIndex = 4;
            this.chkStockMinimo.Text = "Stock Minimo";
            this.chkStockMinimo.UseVisualStyleBackColor = true;
            this.chkStockMinimo.CheckedChanged += new System.EventHandler(this.chkStockMinimo_CheckedChanged);
            // 
            // cmsProducto
            // 
            this.cmsProducto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmModificar});
            this.cmsProducto.Name = "cmsProducto";
            this.cmsProducto.Size = new System.Drawing.Size(160, 36);
            // 
            // tsmModificar
            // 
            this.tsmModificar.Name = "tsmModificar";
            this.tsmModificar.Size = new System.Drawing.Size(159, 32);
            this.tsmModificar.Text = "Modificar";
            this.tsmModificar.Click += new System.EventHandler(this.tsmModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar:";
            // 
            // btn_recargar
            // 
            this.btn_recargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btn_recargar.BackgroundImage = global::FerreteriaElCruce.Properties.Resources.reload_ico;
            this.btn_recargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_recargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recargar.Location = new System.Drawing.Point(517, 22);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(55, 31);
            this.btn_recargar.TabIndex = 6;
            this.btn_recargar.UseVisualStyleBackColor = false;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1341, 620);
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkStockMinimo);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.txtBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInventario_FormClosed);
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.cmsProducto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.CheckBox chkStockMinimo;
        private ContextMenuStrip cmsProducto;
        private ToolStripMenuItem tsmModificar;
        private Label label1;
        private Button btn_recargar;
    }
}