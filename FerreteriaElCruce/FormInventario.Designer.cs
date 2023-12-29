using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.chkStockMinimo = new System.Windows.Forms.CheckBox();
            this.cmsProducto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_recargar = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmsProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBuscador.Location = new System.Drawing.Point(276, 20);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(267, 32);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAgregarProducto.Location = new System.Drawing.Point(1095, 4);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(270, 65);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // chkStockMinimo
            // 
            this.chkStockMinimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkStockMinimo.AutoSize = true;
            this.chkStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chkStockMinimo.Location = new System.Drawing.Point(822, 21);
            this.chkStockMinimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkStockMinimo.Name = "chkStockMinimo";
            this.chkStockMinimo.Size = new System.Drawing.Size(163, 30);
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
            this.cmsProducto.Size = new System.Drawing.Size(126, 26);
            // 
            // tsmModificar
            // 
            this.tsmModificar.Name = "tsmModificar";
            this.tsmModificar.Size = new System.Drawing.Size(125, 22);
            this.tsmModificar.Text = "Modificar";
            this.tsmModificar.Click += new System.EventHandler(this.tsmModificar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(184, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar:";
            // 
            // btn_recargar
            // 
            this.btn_recargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_recargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btn_recargar.BackgroundImage = global::FerreteriaElCruce.Properties.Resources.reload_ico;
            this.btn_recargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_recargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recargar.Location = new System.Drawing.Point(647, 3);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(71, 67);
            this.btn_recargar.TabIndex = 6;
            this.btn_recargar.UseVisualStyleBackColor = false;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvInventario, 5);
            this.dgvInventario.Location = new System.Drawing.Point(3, 77);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(1362, 657);
            this.dgvInventario.TabIndex = 1;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            this.dgvInventario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvInventario_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvInventario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkStockMinimo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscador, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarProducto, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_recargar, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1368, 738);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInventario_FormClosed);
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.cmsProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.CheckBox chkStockMinimo;
        private ContextMenuStrip cmsProducto;
        private ToolStripMenuItem tsmModificar;
        private Label label1;
        private Button btn_recargar;
        private DataGridView dgvInventario;
        private TableLayoutPanel tableLayoutPanel1;
    }
}