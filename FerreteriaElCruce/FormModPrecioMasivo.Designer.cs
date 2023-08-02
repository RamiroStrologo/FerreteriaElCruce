namespace FerreteriaElCruce
{
    partial class FormModPrecioMasivo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAtributo = new System.Windows.Forms.Label();
            this.cmbMarcasMod = new System.Windows.Forms.ComboBox();
            this.dgvProductosMarca = new System.Windows.Forms.DataGridView();
            this.producto_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompraN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinalN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSelec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAceptaryVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.rdbProv = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtributo
            // 
            this.lblAtributo.AutoSize = true;
            this.lblAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtributo.Location = new System.Drawing.Point(50, 35);
            this.lblAtributo.Name = "lblAtributo";
            this.lblAtributo.Size = new System.Drawing.Size(70, 20);
            this.lblAtributo.TabIndex = 0;
            this.lblAtributo.Text = "Marcas:";
            // 
            // cmbMarcasMod
            // 
            this.cmbMarcasMod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMarcasMod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbMarcasMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarcasMod.FormattingEnabled = true;
            this.cmbMarcasMod.Location = new System.Drawing.Point(133, 31);
            this.cmbMarcasMod.Name = "cmbMarcasMod";
            this.cmbMarcasMod.Size = new System.Drawing.Size(216, 28);
            this.cmbMarcasMod.TabIndex = 1;
            this.cmbMarcasMod.SelectedIndexChanged += new System.EventHandler(this.cmbMarcasMod_SelectedIndexChanged);
            this.cmbMarcasMod.Enter += new System.EventHandler(this.cmbMarcasMod_Enter);
            // 
            // dgvProductosMarca
            // 
            this.dgvProductosMarca.AllowUserToAddRows = false;
            this.dgvProductosMarca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductosMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProductosMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProductosMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto_codigo,
            this.Descripcion,
            this.PrecioCompra,
            this.PrecioCompraN,
            this.PrecioFinal,
            this.PrecioFinalN,
            this.Column1,
            this.prodId,
            this.chkSelec});
            this.dgvProductosMarca.Location = new System.Drawing.Point(31, 114);
            this.dgvProductosMarca.Name = "dgvProductosMarca";
            this.dgvProductosMarca.RowHeadersVisible = false;
            this.dgvProductosMarca.RowHeadersWidth = 51;
            this.dgvProductosMarca.RowTemplate.Height = 24;
            this.dgvProductosMarca.Size = new System.Drawing.Size(975, 437);
            this.dgvProductosMarca.TabIndex = 2;
            // 
            // producto_codigo
            // 
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto_codigo.DefaultCellStyle = dataGridViewCellStyle21;
            this.producto_codigo.HeaderText = "Código";
            this.producto_codigo.MinimumWidth = 6;
            this.producto_codigo.Name = "producto_codigo";
            this.producto_codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle22;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioCompra.DefaultCellStyle = dataGridViewCellStyle23;
            this.PrecioCompra.HeaderText = "$ Compra(Actual)";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioCompraN
            // 
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioCompraN.DefaultCellStyle = dataGridViewCellStyle24;
            this.PrecioCompraN.HeaderText = "$ Compra(Nuevo)";
            this.PrecioCompraN.MinimumWidth = 6;
            this.PrecioCompraN.Name = "PrecioCompraN";
            this.PrecioCompraN.ReadOnly = true;
            // 
            // PrecioFinal
            // 
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioFinal.DefaultCellStyle = dataGridViewCellStyle25;
            this.PrecioFinal.HeaderText = "$ Final(Actual)";
            this.PrecioFinal.MinimumWidth = 6;
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            // 
            // PrecioFinalN
            // 
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioFinalN.DefaultCellStyle = dataGridViewCellStyle26;
            this.PrecioFinalN.HeaderText = "$ Final(Nuevo)";
            this.PrecioFinalN.MinimumWidth = 6;
            this.PrecioFinalN.Name = "PrecioFinalN";
            this.PrecioFinalN.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "porcGanancia";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // prodId
            // 
            this.prodId.HeaderText = "productoId";
            this.prodId.MinimumWidth = 6;
            this.prodId.Name = "prodId";
            this.prodId.ReadOnly = true;
            this.prodId.Visible = false;
            // 
            // chkSelec
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.NullValue = false;
            this.chkSelec.DefaultCellStyle = dataGridViewCellStyle27;
            this.chkSelec.HeaderText = "Seleccionar";
            this.chkSelec.MinimumWidth = 6;
            this.chkSelec.Name = "chkSelec";
            this.chkSelec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkSelec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aumento: %";
            // 
            // txtAumento
            // 
            this.txtAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumento.Location = new System.Drawing.Point(133, 81);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(53, 27);
            this.txtAumento.TabIndex = 4;
            this.txtAumento.Text = "0";
            this.txtAumento.TextChanged += new System.EventHandler(this.txtAumento_TextChanged);
            this.txtAumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAumento_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(225, 79);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 29);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(739, 557);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 32);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAceptaryVolver
            // 
            this.btnAceptaryVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnAceptaryVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptaryVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptaryVolver.Location = new System.Drawing.Point(852, 557);
            this.btnAceptaryVolver.Name = "btnAceptaryVolver";
            this.btnAceptaryVolver.Size = new System.Drawing.Size(154, 32);
            this.btnAceptaryVolver.TabIndex = 7;
            this.btnAceptaryVolver.Text = "Aceptar y Volver";
            this.btnAceptaryVolver.UseVisualStyleBackColor = false;
            this.btnAceptaryVolver.Click += new System.EventHandler(this.btnAceptaryVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(31, 557);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Checked = true;
            this.rdbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rdbMarca.Location = new System.Drawing.Point(133, 5);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(86, 24);
            this.rdbMarca.TabIndex = 9;
            this.rdbMarca.TabStop = true;
            this.rdbMarca.Text = "Marcas";
            this.rdbMarca.UseVisualStyleBackColor = true;
            this.rdbMarca.CheckedChanged += new System.EventHandler(this.rdbMarca_CheckedChanged);
            // 
            // rdbProv
            // 
            this.rdbProv.AutoSize = true;
            this.rdbProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rdbProv.Location = new System.Drawing.Point(225, 5);
            this.rdbProv.Name = "rdbProv";
            this.rdbProv.Size = new System.Drawing.Size(124, 24);
            this.rdbProv.TabIndex = 10;
            this.rdbProv.Text = "Proveedores";
            this.rdbProv.UseVisualStyleBackColor = true;
            // 
            // FormModPrecioMasivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1018, 601);
            this.Controls.Add(this.rdbProv);
            this.Controls.Add(this.rdbMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptaryVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProductosMarca);
            this.Controls.Add(this.cmbMarcasMod);
            this.Controls.Add(this.lblAtributo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModPrecioMasivo";
            this.Text = "FormModPrecioMasivo";
            this.Load += new System.EventHandler(this.FormModPrecioMasivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtributo;
        private System.Windows.Forms.ComboBox cmbMarcasMod;
        private System.Windows.Forms.DataGridView dgvProductosMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAceptaryVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdbMarca;
        private System.Windows.Forms.RadioButton rdbProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompraN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinalN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelec;
    }
}