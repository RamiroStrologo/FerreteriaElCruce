using iText.StyledXmlParser.Jsoup.Helper;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout;



namespace FerreteriaElCruce
{
    public partial class FormComprasYVentas : Form
    {
        public bool Ventas { get; set; }
        public string usuario { get; set; }
        CompraVenta compraVenta;
        Producto producto;
        DataTable stringColl;
        string[] listaOriginal = new string[0];
        float subtotalC, totalC, cantStockA, precio;
        int indexListView, lastItemIndex, resultado;
        bool fact, validar;
        public FormComprasYVentas()
        {
            InitializeComponent();
        }
        private void FormCompras_Load(object sender, EventArgs e)
        {
            CargarForm();
        }
        public void CargarForm()
        {
            producto = new Producto();
            rdbNegro.Checked = true;
            if (Ventas)
            {
                rdbBlanco.Location = new Point(rdbBlanco.Location.X, lblDesc.Location.Y + 40);
                rdbBlanco.Enabled = true;
                rdbNegro.Location = new Point(rdbNegro.Location.X, rdbBlanco.Location.Y + 23);
                rdbNegro.Enabled = true;
                lblCant.Location = new Point(lblCant.Location.X, lblProd.Location.Y);
                txtCant.Location = new Point(txtCant.Location.X, cmbProducto.Location.Y);
                txtCant.Enabled = true;
                btnAgregar.Location = new Point(btnAgregar.Location.X, cmbProducto.Location.Y);
                btnAgregar.Enabled = true;
                btnQuitar.Location = new Point(btnQuitar.Location.X, btnAgregar.Location.Y + 26);
                btnQuitar.Enabled = true;
                txtDescuento.Location = new Point(lblDescV.Location.X + 60, lblDescV.Location.Y + 30);
                //txtDescuento.Enabled = true;
                lblDesc.Location = new Point(lblDescV.Location.X, lblDescV.Location.Y + 30);
                //lblPrecioFin.Location = new Point(chkDescVenta.Location.X, chkDescVenta.Location.Y + 30);
                //lblPeso.Location = new Point(chkDescVenta.Location.X - 15, lblPrecioFin.Location.Y);
                lblPeso.Visible = false;
                chkConfirmarP.Visible = false;
                cmbProveedor.Visible = false;
                cmbProducto.Location = new Point(cmbProducto.Location.X, cmbProveedor.Location.Y);
                cmbProducto.Enabled = true;
                lblProv.Visible = false;
                lblProd.Location = new Point(lblProd.Location.X, lblProv.Location.Y);
                lblstockAct.Location = new Point(lblstockAct.Location.X, chkConfirmarP.Location.Y);
                lsvCarrito.Enabled = true;
                lsvCarrito.Columns[3].Text = "$ Venta";
                btnAceptar.Enabled = true;
                lblDescV.Visible = true;
                chkDescVenta.Visible = true;
                txtPrecioCambiar.Visible = false;
                this.Text = "Ventas";
                cmbProducto.TabIndex = 0;
                txtCant.TabIndex = 1;
                btnAgregar.TabIndex = 2;
                btnQuitar.TabIndex = 3;
                rdbBlanco.TabIndex = 4;
                rdbNegro.TabIndex = 5;
                chkDescVenta.TabIndex = 6;
                txtDescuento.TabIndex = 7;
                producto = new Producto();
                lblNumeroVenta.Visible = true;
                btnVentasAnt.Visible = true;
                txtVentaAnt.Visible = true;
                lnkVentas.Visible = true;
                btnAceptar.Enabled = false;
                lblNumeroVenta.Text += " " + producto.GenerarNroVenta().ToString();
            }

        }
        private void FormCompras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormLuancher);
            frm.WindowState = FormWindowState.Normal;
            frm.BringToFront();
        }
        public void ConfirmarOperacion()
        {
            DialogResult dr = new DialogResult();
            if (!Ventas)
            {
                dr = MessageBox.Show(this, "¿Desea realizar la compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    resultado = AltaCompra();
                    resultadoAlta();
                }
            }
            else
            {
                if (chkDescVenta.Checked)
                {
                    dr = MessageBox.Show(this, "¿Desea realizar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        resultado = AltaCompra();
                        resultadoAlta();
                    }
                }
                else
                    MessageBox.Show(this, "Debe cerrar la venta antes de continuar con la operación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
            }

        }
        public void FacturaPDF()
        {
            // Obtenemos la ruta del escritorio del usuario
            string escritorioPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Nombre de la carpeta que deseamos crear
            string nombreCarpeta = "Facturas";

            // Combinamos la ruta del escritorio con el nombre de la carpeta para obtener la ruta completa
            string carpetaCompletaPath = Path.Combine(escritorioPath, nombreCarpeta);

            if (!Directory.Exists(carpetaCompletaPath))
            {
                // Creamos la carpeta
                Directory.CreateDirectory(carpetaCompletaPath);
            }
            // Creamos el archivo PDF dentro de la carpeta
            string archivoPDFPath = Path.Combine(carpetaCompletaPath, lblNumeroVenta.Text.Split(':')[1] + "Factura " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");
            List<int> columnasImpresas = new List<int> { 1, 2, 3, 4, 5, 7 };
            // Creamos el documento PDF
            using (var writer = new PdfWriter(archivoPDFPath))
            using (var pdfDocument = new PdfDocument(writer))
            using (var document = new Document(pdfDocument))
            {
                // Crear la tabla con el mismo número de columnas que el ListView (supongamos que el ListView se llama listView1)
                Table table = new Table(columnasImpresas.Count);

                // Agregar los encabezados de las columnas seleccionadas al PDF
                foreach (int columnaIndex in columnasImpresas)
                {
                    table.AddHeaderCell(lsvCarrito.Columns[columnaIndex].Text);
                }

                // Agregar los datos del ListView a la tabla del PDF
                foreach (ListViewItem item in lsvCarrito.Items)
                {
                    foreach (int columnaIndex in columnasImpresas)
                    {
                        table.AddCell(item.SubItems[columnaIndex].Text);
                    }
                }

                // Agregar la tabla al PDF
                document.Add(table);
            }
        }
        public int AltaCompra()
        {
            Cursor.Current = Cursors.WaitCursor;
            compraVenta = new CompraVenta();
            compraVenta.usuario = usuario;
            for (int i = 0; i <= lsvCarrito.Items.Count - 2; i++)
            {
                compraVenta.productoId = Convert.ToInt32(lsvCarrito.Items[i].SubItems[0].Text);
                compraVenta.cantidad = Convert.ToSingle(lsvCarrito.Items[i].SubItems[4].Text);
                compraVenta.subTotalC = Convert.ToSingle(lsvCarrito.Items[i].SubItems[5].Text.Split('$')[1]);
                compraVenta.facturar = lsvCarrito.Items[i].SubItems[6].Text;
                if (!Ventas)
                {
                    compraVenta.RealizarCompra();
                    resultado = compraVenta.SumarStockProducto();
                }
                else
                {
                    compraVenta.nroV = Convert.ToInt32(lblNumeroVenta.Text.Split(':')[1]);
                    compraVenta.RealizarVenta();
                    resultado = compraVenta.RestarStockProducto();
                }
            }
            Cursor.Current = Cursors.Default;
            return resultado;
        }
        public void resultadoAlta()
        {
            if(resultado == 1)
                MessageBox.Show(this, "Operación registrada con exito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show(this, "Hubo un error al intentar registrar la compra, comuníquese con el proveedor del Software", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (Ventas)
                FacturaPDF();
        }
        public void AutoCompletarCombos(ComboBox cmb)
        {
            stringColl = new DataTable();
            producto.tipoAtributo = cmb.Name;
            producto.palabraBuscar = cmbProducto.Text;
            if (!Ventas)
            {
                if (cmb.Name == "cmbProveedor")
                {
                    producto.palabraBuscar = cmbProveedor.Text;
                    stringColl = producto.AutoCompletarCmbProvMarcaNicho();
                    cmb.DataSource = stringColl;
                }
                else
                {
                    producto.proveedorId = Convert.ToInt32(cmbProveedor.SelectedValue);
                    stringColl = producto.ConsultarProductoXProv();
                    cmb.DataSource = stringColl;
                }
            }
            else
            {
                stringColl = producto.ConsultasProductoVentasLike();
                cmb.DataSource = stringColl;
            }           

        }
        private bool ValidarForm()
        {
            if (lsvCarrito.Items.Count == 0)
                return validar = false;
            return validar = true;
        }
        private void ListaOriginalVenta()
        {
            if(lsvCarrito.Items.Count > 1)
            {
                Array.Resize(ref listaOriginal, lsvCarrito.Items.Count);
                for (int i = 0; i <= lsvCarrito.Items.Count - 2; i++)
                {
                    listaOriginal[i] = lsvCarrito.Items[i].SubItems[5].Text;
                }
                listaOriginal[listaOriginal.Length - 1] = lsvCarrito.Items[lsvCarrito.Items.Count - 1].SubItems[7].Text;
            }
        }
        private void ResetForm()
        {    
            lsvCarrito.Items.Clear();
            txtCant.Text = "1";
            txtDescuento.Text = "0";
            rdbNegro.Checked = true;
            cmbProducto.DataSource = null;
            txtDescuento.Text = "0";
            txtPrecioCambiar.Text = "0";
            if (!Ventas)
            {
                chkConfirmarP.Checked = false;
                rdbBlanco.Enabled = false;
                rdbNegro.Enabled = false;
                lsvCarrito.Enabled = false;
                cmbProducto.Enabled = false;
                cmbProveedor.Enabled = true;
                txtCant.Enabled = false;
                btnAceptar.Enabled = false;
                btnAgregar.Enabled = false;
                btnQuitar.Enabled = false;
                cmbProveedor.DataSource = null;
                txtDescuento.Enabled = false;
                txtPrecioCambiar.Enabled = false;
            }
            else
            {
                producto = new Producto();
                chkDescVenta.Checked = false;
                lblNumeroVenta.Text = "Número de Venta: " + producto.GenerarNroVenta().ToString();
            }
        }
        private void CargarVentaAnt(DataTable carrito)
        {
            for(int i = 0; i <= carrito.Rows.Count - 1; i++)
            {
                ListViewItem item = new ListViewItem(carrito.Rows[i][0].ToString());
                item.SubItems.Add(carrito.Rows[i][1].ToString());
                item.SubItems.Add(carrito.Rows[i][2].ToString());
                item.SubItems.Add(Convert.ToSingle(carrito.Rows[i][3]).ToString("C", CultureInfo.GetCultureInfo("es-AR")));
                item.SubItems.Add(carrito.Rows[i][4].ToString());
                item.SubItems.Add(Convert.ToSingle(carrito.Rows[i][5]).ToString("C", CultureInfo.GetCultureInfo("es-AR")));
                if (Convert.ToBoolean(carrito.Rows[i][6]))
                    item.SubItems.Add("B");
                else
                    item.SubItems.Add("N");
                item.SubItems.Add("");
                lsvCarrito.Items.Add(item);
            }
            ListViewItem totalItem = new ListViewItem("");
            totalItem.SubItems.Add(" ");
            totalItem.SubItems.Add(" ");
            totalItem.SubItems.Add(" ");
            totalItem.SubItems.Add(" ");
            totalItem.SubItems.Add(" ");
            totalItem.SubItems.Add(" ");
            totalItem.SubItems.Add(Convert.ToSingle(carrito.Rows[carrito.Rows.Count - 1][7]).ToString("C", CultureInfo.GetCultureInfo("es-AR")));
            lsvCarrito.Items.Add(totalItem);

            // Asegurarse de que la fila de "Total" se muestre en la parte inferior del ListView
            lsvCarrito.Items[lsvCarrito.Items.Count - 1].EnsureVisible();
            totalC = Convert.ToSingle(carrito.Rows[carrito.Rows.Count - 1][7]);
        }
        private void ResumenVenta()
        {
            if (chkDescVenta.Checked)
            {
                lblRtot.Text = listaOriginal[listaOriginal.Length - 1].ToString();
                lblRdesc.Text = "$" + (Convert.ToSingle(listaOriginal[listaOriginal.Length - 1].Split('$')[1]) * (Convert.ToSingle(txtDescuento.Text) / 100)).ToString();
                lblRdesctot.Text = "$" + (Convert.ToSingle(lblRtot.Text.Split('$')[1]) - Convert.ToSingle(lblRdesc.Text.Split('$')[1])).ToString();
            }
            else
            {
                lblRtot.Text = "$0";
                lblRdesc.Text = "$0";
                lblRdesctot.Text = "$0";
            }
        }
        #region EventosTxt
        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un número, la tecla de retroceso o una coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Cancelar el evento para evitar que el carácter se muestre en el TextBox
            }

            // Permitir solo una coma en el TextBox si hay al menos un número
            if (e.KeyChar == ',')
            {
                var textBox = sender as TextBox;
                if (textBox.Text.Contains(',') || textBox.Text.Length == 0 || textBox.SelectionLength > 0)
                {
                    e.Handled = true; // Cancelar el evento para evitar que se ingrese la coma
                }
            }
        }
        private void txtCant_Validating(object sender, CancelEventArgs e)
        {
            if (txtCant.Text == "0" || string.IsNullOrEmpty(txtCant.Text))
                txtCant.Text = "1";
        }
        private void txtDescuento_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescuento.Text))
                txtDescuento.Text = "0";
            if (!Ventas)
            {
                float descPrecio = Convert.ToSingle(txtPrecioCambiar.Text);
                descPrecio -= Convert.ToSingle(txtPrecioCambiar.Text) * (Convert.ToSingle(txtDescuento.Text) / 100);
                txtPrecioCambiar.Text = descPrecio.ToString();
                if (txtDescuento.Text == "0")
                {
                    txtPrecioCambiar.Enabled = true;
                    txtPrecioCambiar.Text = precio.ToString();
                }
                else
                    txtPrecioCambiar.Enabled = false;
            }
            else
            {
                if (lsvCarrito.Items.Count > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    float precioProd;
                    float nuevoPrecioDesc;
                    float nuevoTotalDesc = 0;
                    for (int i = 0; i <= lsvCarrito.Items.Count - 2; i++)
                    {                      
                        precioProd = Convert.ToSingle(lsvCarrito.Items[i].SubItems[5].Text.Split('$')[1]);
                        nuevoPrecioDesc = precioProd - precioProd * (Convert.ToSingle(txtDescuento.Text) / 100);
                        nuevoTotalDesc += nuevoPrecioDesc;
                        lsvCarrito.Items[i].SubItems[5].Text = nuevoPrecioDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                    }            
                    lsvCarrito.Items[lsvCarrito.Items.Count - 1].SubItems[7].Text = nuevoTotalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                    ResumenVenta();
                    Cursor.Current = Cursors.Default;
                }
            }
         
        }
        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que el carácter no numérico se ingrese en el TextBox
            }
        }
        private void txtPrecioCambiar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un número, la tecla de retroceso o una coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Cancelar el evento para evitar que el carácter se muestre en el TextBox
            }

            // Permitir solo una coma en el TextBox si hay al menos un número
            if (e.KeyChar == ',')
            {
                var textBox = sender as TextBox;
                if (textBox.Text.Contains(',') || textBox.Text.Length == 0 || textBox.SelectionLength > 0)
                {
                    e.Handled = true; // Cancelar el evento para evitar que se ingrese la coma
                }
            }
        }
        private void txtPrecioCambiar_Validating(object sender, CancelEventArgs e)
        {
            if(txtDescuento.Text == "0")
            {
                producto = new Producto();
                producto.precioCompra = Convert.ToInt32(txtPrecioCambiar.Text);
                producto.productoId = Convert.ToInt32(cmbProducto.SelectedValue);
                producto.CambiarPrecioCompra();
                precio = Convert.ToSingle(txtPrecioCambiar.Text);
            }
        }
        #endregion

        #region EventosBtn
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(this, "¿Desea cancelar la operación?", "Restablecer formulario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
                ResetForm();
        }
        private void btnVentasAnt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVentaAnt.Text))
            {
                DialogResult dg = MessageBox.Show(this, "¿Desea cargar la venta indicada? Se perderá la operación actual y podrá modificar la seleccionada. Si no desea realizar cambios TOQUE el boton Aceptar y realicela de nuevo. Se le cargará un nuevo Numero de venta", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    compraVenta = new CompraVenta();
                    compraVenta.nroV = Convert.ToInt32(txtVentaAnt.Text);
                    DataTable dt = compraVenta.ObtenerVentaYRestablecer();
                    if (dt.Rows.Count > 0)
                    {
                        ResetForm();
                        CargarVentaAnt(dt);
                        Cursor.Current = Cursors.Default;
                    }
                    else
                        MessageBox.Show(this, "El número de venta no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbProducto.SelectedIndex != -1)
            {
                if (Ventas)
                {
                    if (Convert.ToSingle(txtCant.Text) <= cantStockA)
                    {
                        AgregarAlCarritoV();
                        string cantNueva = (Convert.ToSingle(Regex.Replace(lblstockAct.Text, @"[^0-9,]", "")) - Convert.ToSingle(txtCant.Text)).ToString();
                        lblstockAct.Text = "(" + Convert.ToSingle(cantNueva) + ")";
                        cantStockA = Convert.ToSingle(cantNueva);
                        txtCant.Text = "1";
                    }
                    else
                        MessageBox.Show(this, "No hay suficientes productos en stock para realizar la operación", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbProducto.DataSource = null;
                }
                else
                {
                    AgregarAlCarritoC();
                    string cantNueva = (Convert.ToSingle(Regex.Replace(lblstockAct.Text, @"[^0-9,]", "")) + Convert.ToSingle(txtCant.Text)).ToString();
                    lblstockAct.Text = "(" + Convert.ToSingle(cantNueva) + ")";
                    cantStockA = Convert.ToSingle(cantNueva);
                    txtCant.Text = "1";
                }
            }
            else
                MessageBox.Show(this, "El producto no existe o no ha seleccionado ninguno", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void AgregarAlCarritoC()
        {
            Cursor.Current = Cursors.WaitCursor;
            subtotalC = Convert.ToSingle(txtPrecioCambiar.Text) * Convert.ToSingle(txtCant.Text);
            ListViewItem item = new ListViewItem(cmbProducto.SelectedValue.ToString());
            item.SubItems.Add(stringColl.Rows[cmbProducto.SelectedIndex]["producto_codigo"].ToString());
            item.SubItems.Add(cmbProducto.Text.Split('-')[1]);
            item.SubItems.Add(Convert.ToSingle(txtPrecioCambiar.Text).ToString("C", CultureInfo.GetCultureInfo("es-AR")));
            item.SubItems.Add(txtCant.Text);
            item.SubItems.Add(subtotalC.ToString("C", CultureInfo.GetCultureInfo("es-AR")));
            if (fact)
                item.SubItems.Add("B");
            else
                item.SubItems.Add("N");
            item.SubItems.Add("");
            lsvCarrito.Items.Add(item);
            lsvCarrito.Items[0].SubItems[5].BackColor = Color.Black;
            totalC += subtotalC;

            // Actualizar la fila de "Total" con el valor de "Total" calculado
            if (lsvCarrito.Items.Count > 1)
            {
                lsvCarrito.Items.RemoveAt(lsvCarrito.Items.Count - 2);
                ListViewItem totalItem = new ListViewItem("");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(totalC.ToString("C", CultureInfo.GetCultureInfo("es-AR")));
                lsvCarrito.Items.Add(totalItem);
            }
            else
            {
                ListViewItem totalItem = new ListViewItem("");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(totalC.ToString("C", CultureInfo.GetCultureInfo("es-AR")));
                lsvCarrito.Items.Add(totalItem);
            }

            // Asegurarse de que la fila de "Total" se muestre en la parte inferior del ListView
            lsvCarrito.Items[lsvCarrito.Items.Count - 1].EnsureVisible();
            Cursor.Current = Cursors.Default;
        }
        public void AgregarAlCarritoV()
        {
            Cursor.Current = Cursors.WaitCursor;
            subtotalC = Convert.ToSingle(txtPrecioCambiar.Text) * Convert.ToSingle(txtCant.Text);
            ListViewItem item = new ListViewItem(cmbProducto.SelectedValue.ToString());
            item.SubItems.Add(stringColl.Rows[cmbProducto.SelectedIndex]["producto_codigo"].ToString());
            item.SubItems.Add(cmbProducto.Text.Split('-')[1]);
            item.SubItems.Add(Convert.ToSingle(txtPrecioCambiar.Text).ToString("C", CultureInfo.GetCultureInfo("es-AR")));
            item.SubItems.Add(txtCant.Text);
            item.SubItems.Add(subtotalC.ToString("C", CultureInfo.GetCultureInfo("es-AR")));
            if (fact)
                item.SubItems.Add("B");
            else
                item.SubItems.Add("N");
            item.SubItems.Add("");
            lsvCarrito.Items.Add(item);
            //lsvCarrito.Items[0].SubItems[5].BackColor = Color.Black;
            totalC += subtotalC;

            // Actualizar la fila de "Total" con el valor de "Total" calculado
            if (lsvCarrito.Items.Count > 1)
            {
                lsvCarrito.Items.RemoveAt(lsvCarrito.Items.Count - 2);
                ListViewItem totalItem = new ListViewItem("");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(totalC.ToString("C", CultureInfo.GetCultureInfo("es-AR")));
                lsvCarrito.Items.Add(totalItem);
            }
            else
            {
                ListViewItem totalItem = new ListViewItem("");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(" ");
                totalItem.SubItems.Add(totalC.ToString("C", CultureInfo.GetCultureInfo("es-AR")));
                lsvCarrito.Items.Add(totalItem);
            }

            // Asegurarse de que la fila de "Total" se muestre en la parte inferior del ListView
            lsvCarrito.Items[lsvCarrito.Items.Count - 1].EnsureVisible();
            Cursor.Current = Cursors.Default;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ValidarForm();
            if (validar)
            {
                Cursor.Current = Cursors.WaitCursor;
                ConfirmarOperacion();
                ResetForm();
                Cursor.Current = Cursors.Default;
            }
            else
                MessageBox.Show(this, "Debe agregar productos al carrito para realizar la operación", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lsvCarrito.SelectedItems.Count > 0)
            {
                if (Ventas)
                {
                    string cantNueva = (Convert.ToSingle(Regex.Replace(lblstockAct.Text, @"[^0-9,]", "")) + Convert.ToSingle(lsvCarrito.Items[indexListView].SubItems[4].Text)).ToString();
                    lblstockAct.Text = "(" + cantNueva.ToString() + ")";
                }
                else
                {
                    string cantNueva = (Convert.ToSingle(Regex.Replace(lblstockAct.Text, @"[^0-9,]", "")) - Convert.ToSingle(lsvCarrito.Items[indexListView].SubItems[4].Text)).ToString();
                    lblstockAct.Text = "(" + cantNueva.ToString() + ")";
                }
                string subtotalRestar = lsvCarrito.Items[indexListView].SubItems[5].Text;
                totalC -= Convert.ToSingle(subtotalRestar.Split('$')[1]);
                lsvCarrito.Items[lastItemIndex].SubItems[7].Text = totalC.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                lsvCarrito.Items.RemoveAt(indexListView);
                lsvCarrito.SelectedItems.Clear();
            }
            if (lsvCarrito.Items.Count <= 1)
                lsvCarrito.Items.Clear();

        }
        #endregion

        #region EventosCmb
        private void cmbProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cmbProducto.Items.Count >= 0)
                {
                    cmbProveedor.DisplayMember = "nombre_proveedor";
                    cmbProveedor.ValueMember = "proveedor_id";
                    AutoCompletarCombos(cmbProveedor);
                }
                Cursor.Current = Cursors.Default;
            }
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.DataSource != null)
            {
                cantStockA = Convert.ToSingle(stringColl.Rows[cmbProducto.SelectedIndex]["cantidad_producto"]);
                lblstockAct.Text = "(" + cantStockA.ToString() + ")";
                if (!Ventas)
                    precio = Convert.ToSingle(stringColl.Rows[cmbProducto.SelectedIndex]["precio_compra"]);
                else
                    precio = Convert.ToSingle(stringColl.Rows[cmbProducto.SelectedIndex]["precio_final"]);
                txtPrecioCambiar.Text = precio.ToString();
                txtDescuento.Text = "0";
            }           
        }

        private void cmbProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbProducto.DisplayMember = "codesc";
                cmbProducto.ValueMember = "producto_id";
                AutoCompletarCombos(cmbProducto);
            }
        }
        #endregion

        #region EventosOtros
        private void chkDescVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescVenta.Checked)
            {
                if (lsvCarrito.Items.Count > 1)
                {
                    cmbProducto.Enabled = false;
                    txtCant.Enabled = false;
                    rdbBlanco.Enabled = false;
                    rdbNegro.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnQuitar.Enabled = false;
                    txtDescuento.Enabled = true;
                    btnAceptar.Enabled = true;
                    ListaOriginalVenta();
                }
                else
                    chkDescVenta.Checked = false;
                if (txtDescuento.Text != "0")
                    txtDescuento_Validating(null, null);
            }
            else
            {
                txtDescuento.Enabled = false;
                cmbProducto.Enabled = true;
                txtCant.Enabled = true;
                rdbBlanco.Enabled = true;
                rdbNegro.Enabled = true;
                btnAgregar.Enabled = true;
                btnQuitar.Enabled = true;
                btnAceptar.Enabled = false;
                if (lsvCarrito.Items.Count > 1)
                {
                    for (int i = 0; i <= lsvCarrito.Items.Count - 2; i++)
                    {
                        lsvCarrito.Items[i].SubItems[5].Text = listaOriginal[i].ToString();
                    }
                    lsvCarrito.Items[lsvCarrito.Items.Count - 1].SubItems[7].Text = listaOriginal[listaOriginal.Length - 1].ToString();
                }         
            }
            ResumenVenta();


        }
        private void lnkVentas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            compraVenta = new CompraVenta();
            DataTable res = new DataTable();
            int nro_venta;
            string nombreArchivo = "log_ventas.txt";
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreArchivo);
            res = compraVenta.ObtenerLogVentas();
            nro_venta = Convert.ToInt32(res.Rows[0][4]);

            // Comprobar si el archivo ya existe y borrarlo para evitar duplicados
            if (File.Exists(rutaArchivo))
            {
                File.Delete(rutaArchivo);
            }

            // Agregar línea por línea al archivo
            using (StreamWriter sw = File.AppendText(rutaArchivo))
            {

                // Agregar el contenido de cada fila
                foreach (DataRow row in res.Rows)
                {
                    if (nro_venta != Convert.ToInt32(row[4]))
                    {
                        // Imprimir una línea punteada y actualizar el número de venta
                        sw.WriteLine("------------------------------------------------------------------------------------------------------");
                        nro_venta = Convert.ToInt32(row[4]);
                    }

                    // Imprimir la fila actual
                    for (int i = 0; i < res.Columns.Count; i++)
                    {
                        sw.Write(row[i]);
                        if (i < res.Columns.Count - 1)
                        {
                            sw.Write("\t");
                        }
                    }

                    // Agregar un salto de línea después de imprimir la fila actual
                    sw.WriteLine();
                }
            }
        }
        private void chkConfirmarP_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if(Convert.ToInt32(cmbProveedor.SelectedValue) > 0)
            {
                if (chkConfirmarP.Checked)
                {
                    rdbBlanco.Enabled = true;
                    rdbNegro.Enabled = true;
                    lsvCarrito.Enabled = true;
                    cmbProducto.Enabled = true;
                    cmbProveedor.Enabled = false;
                    txtCant.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnQuitar.Enabled = true;
                    txtDescuento.Enabled = true;
                    txtPrecioCambiar.Enabled = true;
                }
                else                 
                    ResetForm();
            }
            else
            {
                chkConfirmarP.Checked = false;
                MessageBox.Show(this, "No se ha seleccionado ningun proveedor o no existe", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }               
            Cursor.Current = Cursors.Default;
        }
        private void lsvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {

            lastItemIndex = lsvCarrito.Items.Count - 1;
            if (lsvCarrito.SelectedItems.Count > 0 && lsvCarrito.SelectedItems[0].Index == lastItemIndex)
            {
                // La última fila está seleccionada, cancelar la selección
                lsvCarrito.SelectedItems.Clear();
            }
            else
            {
                if (lsvCarrito.SelectedItems.Count > 0)
                {
                    indexListView = lsvCarrito.SelectedItems[0].Index;
                }
            }
        }
        private void rdbNegro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNegro.Checked)
            {
                rdbBlanco.Checked = false;
                fact = false;
            }
            else
                rdbBlanco.Checked = true;
        }
        private void rdbBlanco_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBlanco.Checked)
            {
                rdbNegro.Checked = false;
                fact = true;
            }
            else
                rdbNegro.Checked = true;
        }
        #endregion









    }
}
