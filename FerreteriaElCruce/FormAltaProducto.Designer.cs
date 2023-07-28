namespace FerreteriaElCruce
{
    partial class FormAltaProducto
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
            this.txtDescProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioFinalProducto = new System.Windows.Forms.TextBox();
            this.txtProcGananciaProducto = new System.Windows.Forms.TextBox();
            this.txtStockMinimoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddMarca = new System.Windows.Forms.Button();
            this.btnAddNicho = new System.Windows.Forms.Button();
            this.btnAddProv = new System.Windows.Forms.Button();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.btnCargaryVolverProd = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbNicho = new System.Windows.Forms.ComboBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtPrecioCompraProducto = new System.Windows.Forms.TextBox();
            this.txtCantStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPasillo = new System.Windows.Forms.TextBox();
            this.lbl11 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDescProducto
            // 
            this.txtDescProducto.Location = new System.Drawing.Point(130, 49);
            this.txtDescProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescProducto.Name = "txtDescProducto";
            this.txtDescProducto.Size = new System.Drawing.Size(473, 27);
            this.txtDescProducto.TabIndex = 1;
            this.txtDescProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescProducto_Validating);
            // 
            // txtPrecioFinalProducto
            // 
            this.txtPrecioFinalProducto.Enabled = false;
            this.txtPrecioFinalProducto.Location = new System.Drawing.Point(538, 387);
            this.txtPrecioFinalProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrecioFinalProducto.Name = "txtPrecioFinalProducto";
            this.txtPrecioFinalProducto.Size = new System.Drawing.Size(65, 27);
            this.txtPrecioFinalProducto.TabIndex = 11;
            // 
            // txtProcGananciaProducto
            // 
            this.txtProcGananciaProducto.Location = new System.Drawing.Point(541, 332);
            this.txtProcGananciaProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtProcGananciaProducto.Name = "txtProcGananciaProducto";
            this.txtProcGananciaProducto.Size = new System.Drawing.Size(62, 27);
            this.txtProcGananciaProducto.TabIndex = 10;
            this.txtProcGananciaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompraProducto_KeyPress);
            this.txtProcGananciaProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtProcGananciaProducto_Validating);
            // 
            // txtStockMinimoProducto
            // 
            this.txtStockMinimoProducto.Location = new System.Drawing.Point(130, 274);
            this.txtStockMinimoProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtStockMinimoProducto.Name = "txtStockMinimoProducto";
            this.txtStockMinimoProducto.Size = new System.Drawing.Size(93, 27);
            this.txtStockMinimoProducto.TabIndex = 5;
            this.txtStockMinimoProducto.Text = "0";
            this.txtStockMinimoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompraProducto_KeyPress);
            this.txtStockMinimoProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtStockMinimoProducto_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nicho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stock Min.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "P/Compra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ganancia: %";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 390);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "P/Final:";
            // 
            // btnAddMarca
            // 
            this.btnAddMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnAddMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMarca.Location = new System.Drawing.Point(618, 219);
            this.btnAddMarca.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddMarca.Name = "btnAddMarca";
            this.btnAddMarca.Size = new System.Drawing.Size(36, 29);
            this.btnAddMarca.TabIndex = 0;
            this.btnAddMarca.Text = "+";
            this.btnAddMarca.UseVisualStyleBackColor = false;
            this.btnAddMarca.Click += new System.EventHandler(this.btnAddMarca_Click);
            // 
            // btnAddNicho
            // 
            this.btnAddNicho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnAddNicho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddNicho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNicho.Location = new System.Drawing.Point(618, 162);
            this.btnAddNicho.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddNicho.Name = "btnAddNicho";
            this.btnAddNicho.Size = new System.Drawing.Size(36, 29);
            this.btnAddNicho.TabIndex = 0;
            this.btnAddNicho.Text = "+";
            this.btnAddNicho.UseVisualStyleBackColor = false;
            this.btnAddNicho.Click += new System.EventHandler(this.btnAddNicho_Click);
            // 
            // btnAddProv
            // 
            this.btnAddProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnAddProv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProv.Location = new System.Drawing.Point(618, 109);
            this.btnAddProv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddProv.Name = "btnAddProv";
            this.btnAddProv.Size = new System.Drawing.Size(36, 29);
            this.btnAddProv.TabIndex = 0;
            this.btnAddProv.Text = "+";
            this.btnAddProv.UseVisualStyleBackColor = false;
            this.btnAddProv.Click += new System.EventHandler(this.btnAddProv_Click);
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnCancelarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarProducto.Location = new System.Drawing.Point(129, 433);
            this.btnCancelarProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(94, 29);
            this.btnCancelarProducto.TabIndex = 12;
            this.btnCancelarProducto.Tag = "";
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = false;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnCargarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCargarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarProducto.Location = new System.Drawing.Point(280, 433);
            this.btnCargarProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(170, 29);
            this.btnCargarProducto.TabIndex = 13;
            this.btnCargarProducto.Text = "Cargar";
            this.btnCargarProducto.UseVisualStyleBackColor = false;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // btnCargaryVolverProd
            // 
            this.btnCargaryVolverProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnCargaryVolverProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCargaryVolverProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargaryVolverProd.Location = new System.Drawing.Point(484, 433);
            this.btnCargaryVolverProd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCargaryVolverProd.Name = "btnCargaryVolverProd";
            this.btnCargaryVolverProd.Size = new System.Drawing.Size(170, 29);
            this.btnCargaryVolverProd.TabIndex = 14;
            this.btnCargaryVolverProd.Text = "Cargar y Volver";
            this.btnCargaryVolverProd.UseVisualStyleBackColor = false;
            this.btnCargaryVolverProd.Click += new System.EventHandler(this.btnCargaryVolverProd_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.ItemHeight = 20;
            this.cmbMarca.Location = new System.Drawing.Point(130, 220);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(473, 28);
            this.cmbMarca.TabIndex = 4;
            this.cmbMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMarca_KeyDown);
            // 
            // cmbNicho
            // 
            this.cmbNicho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNicho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbNicho.FormattingEnabled = true;
            this.cmbNicho.ItemHeight = 20;
            this.cmbNicho.Location = new System.Drawing.Point(130, 159);
            this.cmbNicho.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNicho.Name = "cmbNicho";
            this.cmbNicho.Size = new System.Drawing.Size(473, 28);
            this.cmbNicho.TabIndex = 3;
            this.cmbNicho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNicho_KeyDown);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.ItemHeight = 20;
            this.cmbProveedor.Location = new System.Drawing.Point(130, 105);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(473, 28);
            this.cmbProveedor.TabIndex = 2;
            this.cmbProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProveedor_KeyDown);
            // 
            // txtPrecioCompraProducto
            // 
            this.txtPrecioCompraProducto.Location = new System.Drawing.Point(130, 334);
            this.txtPrecioCompraProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompraProducto.Name = "txtPrecioCompraProducto";
            this.txtPrecioCompraProducto.Size = new System.Drawing.Size(93, 27);
            this.txtPrecioCompraProducto.TabIndex = 8;
            this.txtPrecioCompraProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompraProducto_KeyPress);
            this.txtPrecioCompraProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecioCompraProducto_Validating);
            // 
            // txtCantStock
            // 
            this.txtCantStock.Location = new System.Drawing.Point(345, 274);
            this.txtCantStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantStock.Name = "txtCantStock";
            this.txtCantStock.Size = new System.Drawing.Size(64, 27);
            this.txtCantStock.TabIndex = 6;
            this.txtCantStock.Text = "0";
            this.txtCantStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompraProducto_KeyPress);
            this.txtCantStock.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantStock_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cant. Stock:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 277);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pasillo:";
            // 
            // txtPasillo
            // 
            this.txtPasillo.Location = new System.Drawing.Point(541, 275);
            this.txtPasillo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasillo.Name = "txtPasillo";
            this.txtPasillo.Size = new System.Drawing.Size(62, 27);
            this.txtPasillo.TabIndex = 7;
            this.txtPasillo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasillo_KeyPress);
            this.txtPasillo.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasillo_Validating);
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(260, 337);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(78, 20);
            this.lbl11.TabIndex = 0;
            this.lbl11.Text = "Desc.: %";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(344, 334);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(65, 27);
            this.txtDesc.TabIndex = 9;
            this.txtDesc.Text = "0";
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            this.txtDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // FormAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(840, 601);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.txtPasillo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCantStock);
            this.Controls.Add(this.txtPrecioCompraProducto);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.cmbNicho);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnCargaryVolverProd);
            this.Controls.Add(this.btnCargarProducto);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnAddProv);
            this.Controls.Add(this.btnAddNicho);
            this.Controls.Add(this.btnAddMarca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStockMinimoProducto);
            this.Controls.Add(this.txtProcGananciaProducto);
            this.Controls.Add(this.txtPrecioFinalProducto);
            this.Controls.Add(this.txtDescProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormAltaProducto";
            this.Text = "FormAltaProducto";
            this.Load += new System.EventHandler(this.FormAltaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescProducto;
        private System.Windows.Forms.TextBox txtPrecioFinalProducto;
        private System.Windows.Forms.TextBox txtProcGananciaProducto;
        private System.Windows.Forms.TextBox txtStockMinimoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddMarca;
        private System.Windows.Forms.Button btnAddNicho;
        private System.Windows.Forms.Button btnAddProv;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.Button btnCargaryVolverProd;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbNicho;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtPrecioCompraProducto;
        private System.Windows.Forms.TextBox txtCantStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPasillo;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.TextBox txtDesc;
    }
}