namespace FerreteriaElCruce
{
    partial class FormComprasYVentas
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
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProv = new System.Windows.Forms.Label();
            this.lsvCarrito = new System.Windows.Forms.ListView();
            this.prodId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.producto_nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio_compra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad_producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.facturar_sino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad_stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblProd = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.chkConfirmarP = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.rdbBlanco = new System.Windows.Forms.RadioButton();
            this.rdbNegro = new System.Windows.Forms.RadioButton();
            this.lblstockAct = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.chkDescVenta = new System.Windows.Forms.CheckBox();
            this.lblDescV = new System.Windows.Forms.Label();
            this.gpbResumenVenta = new System.Windows.Forms.GroupBox();
            this.lblRtot = new System.Windows.Forms.Label();
            this.lblRdesc = new System.Windows.Forms.Label();
            this.lblRdesctot = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioCambiar = new System.Windows.Forms.TextBox();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.btnVentasAnt = new System.Windows.Forms.Button();
            this.lnkVentas = new System.Windows.Forms.LinkLabel();
            this.txtVentaAnt = new System.Windows.Forms.TextBox();
            this.gpbResumenVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(195, 55);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(289, 33);
            this.cmbProveedor.TabIndex = 1;
            this.cmbProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProveedor_KeyDown);
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblProv.Location = new System.Drawing.Point(26, 58);
            this.lblProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(118, 26);
            this.lblProv.TabIndex = 3;
            this.lblProv.Text = "Proveedor:";
            // 
            // lsvCarrito
            // 
            this.lsvCarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodId,
            this.prodCod,
            this.producto_nombre,
            this.precio_compra,
            this.cantidad_producto,
            this.subtotal,
            this.facturar_sino,
            this.total,
            this.cantidad_stock});
            this.lsvCarrito.Enabled = false;
            this.lsvCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lsvCarrito.FullRowSelect = true;
            this.lsvCarrito.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvCarrito.HideSelection = false;
            this.lsvCarrito.Location = new System.Drawing.Point(546, 55);
            this.lsvCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.lsvCarrito.MultiSelect = false;
            this.lsvCarrito.Name = "lsvCarrito";
            this.lsvCarrito.ShowItemToolTips = true;
            this.lsvCarrito.Size = new System.Drawing.Size(844, 232);
            this.lsvCarrito.TabIndex = 8;
            this.lsvCarrito.UseCompatibleStateImageBehavior = false;
            this.lsvCarrito.View = System.Windows.Forms.View.Details;
            this.lsvCarrito.SelectedIndexChanged += new System.EventHandler(this.lsvCarrito_SelectedIndexChanged);
            // 
            // prodId
            // 
            this.prodId.Text = "pId";
            this.prodId.Width = 0;
            // 
            // prodCod
            // 
            this.prodCod.Text = "Código";
            this.prodCod.Width = 100;
            // 
            // producto_nombre
            // 
            this.producto_nombre.Text = "Descripción";
            this.producto_nombre.Width = 215;
            // 
            // precio_compra
            // 
            this.precio_compra.Text = "$ Compra";
            this.precio_compra.Width = 130;
            // 
            // cantidad_producto
            // 
            this.cantidad_producto.Text = "Cant.";
            this.cantidad_producto.Width = 101;
            // 
            // subtotal
            // 
            this.subtotal.Text = "SubTotal ";
            this.subtotal.Width = 121;
            // 
            // facturar_sino
            // 
            this.facturar_sino.Text = "       ---              ";
            this.facturar_sino.Width = 41;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 100;
            // 
            // cantidad_stock
            // 
            this.cantidad_stock.Text = "stock_actual";
            this.cantidad_stock.Width = 0;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblProd.Location = new System.Drawing.Point(28, 120);
            this.lblProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(116, 26);
            this.lblProd.TabIndex = 5;
            this.lblProd.Text = "Productos:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProducto.Enabled = false;
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(195, 113);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(289, 33);
            this.cmbProducto.TabIndex = 3;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            this.cmbProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProducto_KeyDown);
            // 
            // chkConfirmarP
            // 
            this.chkConfirmarP.AutoSize = true;
            this.chkConfirmarP.Location = new System.Drawing.Point(492, 55);
            this.chkConfirmarP.Margin = new System.Windows.Forms.Padding(4);
            this.chkConfirmarP.Name = "chkConfirmarP";
            this.chkConfirmarP.Size = new System.Drawing.Size(15, 14);
            this.chkConfirmarP.TabIndex = 2;
            this.chkConfirmarP.UseVisualStyleBackColor = true;
            this.chkConfirmarP.CheckedChanged += new System.EventHandler(this.chkConfirmarP_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAceptar.Location = new System.Drawing.Point(291, 391);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(142, 49);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCancelar.Location = new System.Drawing.Point(152, 391);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 49);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCant
            // 
            this.txtCant.Enabled = false;
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtCant.Location = new System.Drawing.Point(124, 227);
            this.txtCant.Margin = new System.Windows.Forms.Padding(4);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(46, 32);
            this.txtCant.TabIndex = 4;
            this.txtCant.Text = "1";
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            this.txtCant.Validating += new System.ComponentModel.CancelEventHandler(this.txtCant_Validating);
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCant.Location = new System.Drawing.Point(20, 227);
            this.lblCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(105, 26);
            this.lblCant.TabIndex = 11;
            this.lblCant.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAgregar.Location = new System.Drawing.Point(205, 231);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 29);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnQuitar.Enabled = false;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnQuitar.Location = new System.Drawing.Point(205, 268);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(66, 29);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // rdbBlanco
            // 
            this.rdbBlanco.AutoSize = true;
            this.rdbBlanco.Enabled = false;
            this.rdbBlanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rdbBlanco.Location = new System.Drawing.Point(16, 299);
            this.rdbBlanco.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBlanco.Name = "rdbBlanco";
            this.rdbBlanco.Size = new System.Drawing.Size(121, 30);
            this.rdbBlanco.TabIndex = 13;
            this.rdbBlanco.TabStop = true;
            this.rdbBlanco.Text = "BLANCO";
            this.rdbBlanco.UseVisualStyleBackColor = true;
            this.rdbBlanco.CheckedChanged += new System.EventHandler(this.rdbBlanco_CheckedChanged);
            // 
            // rdbNegro
            // 
            this.rdbNegro.AutoSize = true;
            this.rdbNegro.Enabled = false;
            this.rdbNegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rdbNegro.Location = new System.Drawing.Point(16, 331);
            this.rdbNegro.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNegro.Name = "rdbNegro";
            this.rdbNegro.Size = new System.Drawing.Size(111, 30);
            this.rdbNegro.TabIndex = 14;
            this.rdbNegro.TabStop = true;
            this.rdbNegro.Text = "NEGRO";
            this.rdbNegro.UseVisualStyleBackColor = true;
            this.rdbNegro.CheckedChanged += new System.EventHandler(this.rdbNegro_CheckedChanged);
            // 
            // lblstockAct
            // 
            this.lblstockAct.AutoSize = true;
            this.lblstockAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblstockAct.Location = new System.Drawing.Point(488, 113);
            this.lblstockAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstockAct.Name = "lblstockAct";
            this.lblstockAct.Size = new System.Drawing.Size(38, 26);
            this.lblstockAct.TabIndex = 15;
            this.lblstockAct.Text = "(0)";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDesc.Location = new System.Drawing.Point(24, 162);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(94, 26);
            this.lblDesc.TabIndex = 17;
            this.lblDesc.Text = "Desc %:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtDescuento.Location = new System.Drawing.Point(124, 159);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(36, 32);
            this.txtDescuento.TabIndex = 18;
            this.txtDescuento.Text = "0";
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            this.txtDescuento.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescuento_Validating);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPeso.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPeso.Location = new System.Drawing.Point(200, 159);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(24, 26);
            this.lblPeso.TabIndex = 19;
            this.lblPeso.Text = "$";
            // 
            // chkDescVenta
            // 
            this.chkDescVenta.AutoSize = true;
            this.chkDescVenta.Location = new System.Drawing.Point(348, 201);
            this.chkDescVenta.Name = "chkDescVenta";
            this.chkDescVenta.Size = new System.Drawing.Size(15, 14);
            this.chkDescVenta.TabIndex = 20;
            this.chkDescVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDescVenta.UseVisualStyleBackColor = false;
            this.chkDescVenta.Visible = false;
            this.chkDescVenta.CheckedChanged += new System.EventHandler(this.chkDescVenta_CheckedChanged);
            // 
            // lblDescV
            // 
            this.lblDescV.AutoSize = true;
            this.lblDescV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDescV.Location = new System.Drawing.Point(200, 201);
            this.lblDescV.Name = "lblDescV";
            this.lblDescV.Size = new System.Drawing.Size(142, 26);
            this.lblDescV.TabIndex = 21;
            this.lblDescV.Text = "Cerrar Venta:";
            this.lblDescV.Visible = false;
            // 
            // gpbResumenVenta
            // 
            this.gpbResumenVenta.Controls.Add(this.lblRtot);
            this.gpbResumenVenta.Controls.Add(this.lblRdesc);
            this.gpbResumenVenta.Controls.Add(this.lblRdesctot);
            this.gpbResumenVenta.Controls.Add(this.lbl20);
            this.gpbResumenVenta.Controls.Add(this.label2);
            this.gpbResumenVenta.Controls.Add(this.label1);
            this.gpbResumenVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.gpbResumenVenta.Location = new System.Drawing.Point(546, 294);
            this.gpbResumenVenta.Name = "gpbResumenVenta";
            this.gpbResumenVenta.Size = new System.Drawing.Size(539, 146);
            this.gpbResumenVenta.TabIndex = 22;
            this.gpbResumenVenta.TabStop = false;
            this.gpbResumenVenta.Text = "Resumen de venta:";
            this.gpbResumenVenta.Visible = false;
            // 
            // lblRtot
            // 
            this.lblRtot.AutoSize = true;
            this.lblRtot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRtot.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblRtot.Location = new System.Drawing.Point(93, 64);
            this.lblRtot.Name = "lblRtot";
            this.lblRtot.Size = new System.Drawing.Size(36, 26);
            this.lblRtot.TabIndex = 7;
            this.lblRtot.Text = "$0";
            // 
            // lblRdesc
            // 
            this.lblRdesc.AutoSize = true;
            this.lblRdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRdesc.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblRdesc.Location = new System.Drawing.Point(274, 64);
            this.lblRdesc.Name = "lblRdesc";
            this.lblRdesc.Size = new System.Drawing.Size(36, 26);
            this.lblRdesc.TabIndex = 6;
            this.lblRdesc.Text = "$0";
            // 
            // lblRdesctot
            // 
            this.lblRdesctot.AutoSize = true;
            this.lblRdesctot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRdesctot.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblRdesctot.Location = new System.Drawing.Point(497, 64);
            this.lblRdesctot.Name = "lblRdesctot";
            this.lblRdesctot.Size = new System.Drawing.Size(36, 26);
            this.lblRdesctot.TabIndex = 5;
            this.lblRdesctot.Text = "$0";
            this.lblRdesctot.Click += new System.EventHandler(this.lblRdesctot_Click);
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl20.Location = new System.Drawing.Point(342, 64);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(149, 26);
            this.lbl20.TabIndex = 2;
            this.lbl20.Text = "Total C/ Desc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(146, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descuento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(5, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // txtPrecioCambiar
            // 
            this.txtPrecioCambiar.Enabled = false;
            this.txtPrecioCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPrecioCambiar.Location = new System.Drawing.Point(225, 159);
            this.txtPrecioCambiar.Name = "txtPrecioCambiar";
            this.txtPrecioCambiar.Size = new System.Drawing.Size(100, 32);
            this.txtPrecioCambiar.TabIndex = 23;
            this.txtPrecioCambiar.Text = "0";
            this.txtPrecioCambiar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCambiar_KeyPress);
            this.txtPrecioCambiar.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecioCambiar_Validating);
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNumeroVenta.Location = new System.Drawing.Point(8, 9);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(189, 26);
            this.lblNumeroVenta.TabIndex = 24;
            this.lblNumeroVenta.Text = "Número de Venta:";
            this.lblNumeroVenta.Visible = false;
            // 
            // btnVentasAnt
            // 
            this.btnVentasAnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnVentasAnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentasAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnVentasAnt.Location = new System.Drawing.Point(1246, 329);
            this.btnVentasAnt.Name = "btnVentasAnt";
            this.btnVentasAnt.Size = new System.Drawing.Size(114, 32);
            this.btnVentasAnt.TabIndex = 25;
            this.btnVentasAnt.Text = "Buscar Ventas";
            this.btnVentasAnt.UseVisualStyleBackColor = false;
            this.btnVentasAnt.Visible = false;
            this.btnVentasAnt.Click += new System.EventHandler(this.btnVentasAnt_Click);
            // 
            // lnkVentas
            // 
            this.lnkVentas.AutoSize = true;
            this.lnkVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lnkVentas.Location = new System.Drawing.Point(1113, 393);
            this.lnkVentas.Name = "lnkVentas";
            this.lnkVentas.Size = new System.Drawing.Size(247, 26);
            this.lnkVentas.TabIndex = 26;
            this.lnkVentas.TabStop = true;
            this.lnkVentas.Text = "Descargar log de ventas";
            this.lnkVentas.Visible = false;
            this.lnkVentas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVentas_LinkClicked);
            // 
            // txtVentaAnt
            // 
            this.txtVentaAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtVentaAnt.Location = new System.Drawing.Point(1118, 329);
            this.txtVentaAnt.Name = "txtVentaAnt";
            this.txtVentaAnt.Size = new System.Drawing.Size(110, 32);
            this.txtVentaAnt.TabIndex = 27;
            this.txtVentaAnt.Visible = false;
            // 
            // FormComprasYVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1455, 571);
            this.Controls.Add(this.txtVentaAnt);
            this.Controls.Add(this.lnkVentas);
            this.Controls.Add(this.btnVentasAnt);
            this.Controls.Add(this.lblNumeroVenta);
            this.Controls.Add(this.txtPrecioCambiar);
            this.Controls.Add(this.gpbResumenVenta);
            this.Controls.Add(this.lblDescV);
            this.Controls.Add(this.chkDescVenta);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblstockAct);
            this.Controls.Add(this.rdbNegro);
            this.Controls.Add(this.rdbBlanco);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkConfirmarP);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lsvCarrito);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.cmbProveedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormComprasYVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCompras_FormClosed);
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.gpbResumenVenta.ResumeLayout(false);
            this.gpbResumenVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.ListView lsvCarrito;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.CheckBox chkConfirmarP;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ColumnHeader prodId;
        private System.Windows.Forms.ColumnHeader producto_nombre;
        private System.Windows.Forms.ColumnHeader precio_compra;
        private System.Windows.Forms.ColumnHeader cantidad_producto;
        private System.Windows.Forms.ColumnHeader subtotal;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ColumnHeader cantidad_stock;
        private System.Windows.Forms.ColumnHeader prodCod;
        private System.Windows.Forms.RadioButton rdbBlanco;
        private System.Windows.Forms.RadioButton rdbNegro;
        private System.Windows.Forms.ColumnHeader facturar_sino;
        private System.Windows.Forms.Label lblstockAct;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.CheckBox chkDescVenta;
        private System.Windows.Forms.Label lblDescV;
        private System.Windows.Forms.GroupBox gpbResumenVenta;
        private System.Windows.Forms.Label lblRtot;
        private System.Windows.Forms.Label lblRdesc;
        private System.Windows.Forms.Label lblRdesctot;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioCambiar;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Button btnVentasAnt;
        private System.Windows.Forms.LinkLabel lnkVentas;
        private System.Windows.Forms.TextBox txtVentaAnt;
    }
}