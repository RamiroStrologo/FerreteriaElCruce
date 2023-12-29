using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

//TAREAS:
//1.VERIFICAR QUE LOS COMBOS PROV, NICHO Y MARCA TENGAN COMO SELECTEDVALUE = 1 POR DEFAULT
//2.HACER QUE AL AGREGAR PROV, NICHO O MARCA, EL COMBO SE SELECCIONE AUTOMATICAMENTE CON EL NUEVO REGISTRO
//3.VERIFICAR QUE LAS MODIFICACIONES NO PINCHEN CUANDO NO HAR PRODUCTO CARGADOS
namespace FerreteriaElCruce
{
    public partial class FormAltaProducto : Form
    {
        Producto producto;
        public bool Modificar { get; set; }
        public int productoIdMod { get; set; }
        public string productoNomMod { get; set; }
        public string productoCod { get; set; }
        int resultado;
        float precioCompra, porcGanancia, precioFinal;
        bool validar;
        ComboBox cmbProducto;
        public FormAltaProducto()
        {
            InitializeComponent();
        }

        private void FormAltaProducto_Load(object sender, EventArgs e)
        {
            if (!Modificar)
            {
               txtDescProducto.Focus();
            }
            else
            {
                //Agrego los controles para la seleccion del producto a modificar
                cmbProducto = new ComboBox();
                cmbProducto.Name = "cmbProducto";
                cmbProducto.Left = txtDescProducto.Left;
                cmbProducto.Top = txtDescProducto.Top - 30; // Mover el ComboBox 30 píxeles hacia arriba
                cmbProducto.Width = txtDescProducto.Width;
                cmbProducto.Height = txtDescProducto.Height;
                cmbProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.Controls.Add(cmbProducto);
                Label labelModificar = new Label();
                labelModificar.Left = label1.Left;
                labelModificar.Top = label1.Top - 30; // Mover el ComboBox 30 píxeles hacia arriba
                labelModificar.Width = label1.Width;
                labelModificar.Height = label1.Height;
                labelModificar.Text = "Producto:";
                labelModificar.Font = new Font("Tahoma", 16);
                this.Controls.Add(labelModificar);
                /////////////////////////
                btnAddMarca.Visible = false;
                btnAddNicho.Visible = false;
                btnAddProv.Visible = false;
                btnCargarProducto.Text = "Modificar";
                btnCargaryVolverProd.Text = "Modificar y volver";
                CargarProducto(cmbProducto);

            }
            
        }
        public void CargarProducto(ComboBox cmb)
        {
            //Cargo el combo y configuro el evento SelectedIndexChange
            cmb.DisplayMember = "nombre_producto";
            cmb.ValueMember = "producto_id";
            cmb.SelectedIndexChanged += new EventHandler(cmbProducto_SelectedIndexChanged);
            cmb.KeyDown += new KeyEventHandler(cmbProducto_KeyDown);
            if (productoIdMod != 0)
            {
                cmb.Text = productoNomMod;
                cmbProducto_KeyDown(cmb, new KeyEventArgs(Keys.Enter));
                cmbProducto_SelectedIndexChanged(cmb, null);
                cmbNicho_KeyDown(cmb, new KeyEventArgs(Keys.Enter));
                cmbMarca_KeyDown(cmb, new KeyEventArgs(Keys.Enter));
                cmbProveedor_KeyDown(cmb, new KeyEventArgs(Keys.Enter));
            }
        }
        public void AltaProducto()
        {
            producto.descripcion = txtDescProducto.Text;
            producto.precioCompra = Convert.ToSingle(txtPrecioCompraProducto.Text.Substring(1));
            producto.porcGanancia = porcGanancia;
            producto.precioFinal = precioFinal;
            producto.stockMin = Convert.ToInt32(txtStockMinimoProducto.Text);
            producto.cantStock = Convert.ToInt32(txtCantStock.Text);
            producto.pasillo = txtPasillo.Text;
            producto.productoCodigo = productoCod;
            if (cmbProveedor.SelectedValue != null)
                producto.proveedorId = Convert.ToInt32(cmbProveedor.SelectedValue);
            else
                producto.proveedorId = 1;
            if(cmbNicho.SelectedValue != null)
               producto.nichoId = Convert.ToInt32(cmbNicho.SelectedValue);
            else
                producto.nichoId = 1;
            if (cmbMarca.SelectedValue != null)
                producto.marcaId = Convert.ToInt32(cmbMarca.SelectedValue);
            else
                producto.marcaId = 1;
            if (!Modificar)
                resultado = producto.AltaProducto();
            else
            {
                producto.productoId = Convert.ToInt32(cmbProducto.SelectedValue);
                resultado = producto.ModificarPorducto();
            }               
           
        }
        private void ConfirmarOperacion()
        {
            Cursor.Current = Cursors.WaitCursor;
            DialogResult dialogResult = new DialogResult();
            if (!Modificar)
                dialogResult = MessageBox.Show(this, "¿Desea guardar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                dialogResult = MessageBox.Show(this, "¿Desea modificar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                AltaProducto();
                resultadoAlta(resultado);
            }
            Cursor.Current = Cursors.Default;
        }
        public void resultadoAlta(int resultado)
        {
            if (!Modificar)
            {
                if (resultado == 1)
                    MessageBox.Show(this, "Registro guardado con exito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show(this, "Hubo un error al intentar guardar el registro, comuníquese con el proveedor del Software", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (resultado == 1)
                    MessageBox.Show(this, "Registro modificado con exito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show(this, "Hubo un error al intentar modificar el registro, comuníquese con el proveedor del Software", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        public void ReiniciarForm()
        {
            txtDescProducto.Text = "";
            txtDescProducto.Focus();
            txtPrecioCompraProducto.Text = "";
            txtProcGananciaProducto.Text = "";
            txtPrecioFinalProducto.Text = "";
            txtStockMinimoProducto.Text = "0";
            txtCantStock.Text = "0";
            txtPasillo.Text = "";
            txtDesc.Text = "0";
            cmbProveedor.SelectedIndex = -1;
            cmbNicho.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            precioCompra = 0;
            porcGanancia = 0;
            precioFinal = 0;

        }
        private bool ValidarForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return validar = false;
                    }
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.SelectedItem == null || Convert.ToInt32(comboBox.SelectedValue) <= 0)
                    {
                        return validar = false;
                    }
                }
            }
            return validar = true;
        }
        #region EventosBtn

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            ReiniciarForm();
        }
        private void btnCargaryVolverProd_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            ValidarForm();
            if (validar)
            {
                ConfirmarOperacion();
                Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormConfiguracion);
                Form frmI = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormInventario);
                if (frmI == null)
                {
                    FormInventario form = new FormInventario();
                    form.Show();
                }
                frmC.Close();
            }
            else
                MessageBox.Show(this, "Debe completar todos los campos para realizar la carga", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            ValidarForm();
            if (validar)
            {
                ConfirmarOperacion();
                ReiniciarForm();
            }
            else
                MessageBox.Show(this, "Debe completar todos los campos para realizar la carga", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnAddProv_Click(object sender, EventArgs e)
        {
            FormAltaProvMarcaNicho form = new FormAltaProvMarcaNicho();
            form.Text = "Agregar Proveedor";
            form.ShowDialog();
            resultadoAlta(form.resultado);
            cmbProveedor.Focus();
        }

        private void btnAddNicho_Click(object sender, EventArgs e)
        {
            FormAltaProvMarcaNicho form = new FormAltaProvMarcaNicho();
            form.Text = "Agregar Nicho";
            form.ShowDialog();
            resultadoAlta(form.resultado);
            cmbNicho.Focus();
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            FormAltaProvMarcaNicho form = new FormAltaProvMarcaNicho();
            form.Text = "Agregar Marca";
            form.ShowDialog();
            resultadoAlta(form.resultado);
            cmbMarca.Focus();        
        }

        #endregion

        #region EventosCombos
        private void cmbProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                producto = new Producto();
                producto.tipoAtributo = cmbProveedor.Name;
                producto.palabraBuscar = cmbProveedor.Text;
                cmbProveedor.DisplayMember = "nombre_proveedor";
                cmbProveedor.ValueMember = "proveedor_id";
                autoCompletarCmb(cmbProveedor);
            }
        }

        private void cmbNicho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                producto = new Producto();
                producto.tipoAtributo = cmbNicho.Name;
                producto.palabraBuscar = cmbNicho.Text;
                cmbNicho.DisplayMember = "nombre_nicho";
                cmbNicho.ValueMember = "nicho_id";
                autoCompletarCmb(cmbNicho);
            }               
        }

        private void cmbMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                producto = new Producto();
                producto.tipoAtributo = cmbMarca.Name;
                producto.palabraBuscar = cmbMarca.Text;
                cmbMarca.DisplayMember = "nombre_marca";
                cmbMarca.ValueMember = "marca_id";
                autoCompletarCmb(cmbMarca);
            }
        }

        private void cmbProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComboBox comboBox = sender as ComboBox;
                producto = new Producto();
                producto.palabraBuscar = comboBox.Text;
                comboBox.DisplayMember = "codesc";
                comboBox.ValueMember = "producto_id";
                autoCompletarCmb(comboBox);
            }
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox comboBox = sender as ComboBox;
                //Cargo los campos del Form con los datos del producto seleccionado
                DataTable datosProducto = new DataTable();
                producto = new Producto();                  
                producto.productoId = Convert.ToInt32(comboBox.SelectedValue);                 
                datosProducto = producto.ConsultarProductoSeleccionado();
                txtDescProducto.Text = datosProducto.Rows[0]["nombre_producto"].ToString();
                txtStockMinimoProducto.Text = datosProducto.Rows[0]["stock_minimo"].ToString();
                txtCantStock.Text = datosProducto.Rows[0]["cantidad_producto"].ToString();
                precioCompra = Convert.ToSingle(datosProducto.Rows[0]["precio_compra"].ToString());
                txtPrecioCompraProducto.Text = precioCompra.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                txtProcGananciaProducto.Text = datosProducto.Rows[0]["porc_ganancia"].ToString();
                txtPasillo.Text = datosProducto.Rows[0]["producto_codigo"].ToString().Substring(0, 1);
                cmbMarca.Text = datosProducto.Rows[0]["nombre_marca"].ToString();
                cmbProveedor.Text = datosProducto.Rows[0]["nombre_proveedor"].ToString();
                cmbNicho.Text = datosProducto.Rows[0]["nombre_nicho"].ToString();
                productoCod = datosProducto.Rows[0]["producto_codigo"].ToString();
                txtPrecioCompraProducto_Validating(txtPrecioCompraProducto, null);
                txtProcGananciaProducto_Validating(txtProcGananciaProducto, null);
            }
            catch(System.IndexOutOfRangeException er)
            {
                MessageBox.Show("Debe cargar productos antes de utilizar esta pantalla.\nSi cree que se trata de un error, comunicarse con el proveedor de Software.", er.ToString()); 
            }

        }

        private void autoCompletarCmb(ComboBox cmb)
        {
            DataTable stringColl = new DataTable();
            if (cmb.Name != "cmbProducto")
            {
                stringColl = producto.AutoCompletarCmbProvMarcaNicho();
                cmb.DataSource = stringColl;
            }            
            else
            {
                stringColl = producto.ConsultaProducto();
                cmb.DataSource = stringColl;
            }                     
        }

        #endregion

        #region EventosTxt

        private void txtPrecioCompraProducto_Validating(object sender, CancelEventArgs e)
        {
            if (!float.TryParse(txtPrecioCompraProducto.Text, out float value) && !txtPrecioCompraProducto.Text.Contains("$"))
            {
                // Si el valor no se puede convertir a decimal, establecer el texto en vacío
                txtPrecioCompraProducto.Focus();
            }
            else
            {
                if (txtDesc.Text != "0")
                {
                    float valueP = precioCompra;       
                    if (!string.IsNullOrWhiteSpace(txtProcGananciaProducto.Text))
                    {
                        valueP -= precioCompra * (Convert.ToSingle(txtDesc.Text) / 100);
                        txtPrecioCompraProducto.Text = valueP.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                        float valuePF = valueP + (valueP * ((porcGanancia / 100) + 1));
                        txtPrecioFinalProducto.Text = valuePF.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                        txtProcGananciaProducto_Validating(null, null);
                    }          
                }
                else
                {
                    if(float.TryParse(txtPrecioCompraProducto.Text, out float precioN))
                    {
                        precioCompra = precioN;
                        txtPrecioCompraProducto.Text = precioCompra.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                    }
                    else
                        txtPrecioCompraProducto.Text = precioCompra.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

                } 
            }

        }

        private void txtPrecioCompraProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDescProducto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescProducto.Text))
                txtDescProducto.Focus();
        }

        private void txtCantStock_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantStock.Text))
            {
                txtStockMinimoProducto.Focus();
                txtCantStock.Text = "0";
            }  
        }

        private void txtPasillo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasillo.Text))
                txtPasillo.Focus();
               
        }

        private void txtPasillo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                // Permitir borrar el contenido del TextBox
                return;
            }
            if (char.IsLetter(e.KeyChar))
            {
                if (txtPasillo.Text.Length > 0)
                {
                    // Detener el evento KeyPress si ya hay una letra
                    e.Handled = true;
                }
                else if (char.IsLower(e.KeyChar))
                {   // Convertir el carácter a mayúscula si es una letra minúscula
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }


            }
            else
            {
                // Detener el evento KeyPress si el carácter no es una letra
                e.Handled = true;
            }
        }

        private void txtStockMinimoProducto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStockMinimoProducto.Text))
            {
                txtStockMinimoProducto.Focus();
                txtStockMinimoProducto.Text = "0";
            }   
        }

        private void txtProcGananciaProducto_Validating(object sender, CancelEventArgs e)
        {
            if (float.TryParse(txtProcGananciaProducto.Text, out float valuePg))
            {
                porcGanancia = valuePg;
                txtPrecioFinalProducto.Text = (Convert.ToSingle(txtPrecioCompraProducto.Text.Split('$')[1]) * ((porcGanancia / 100) + 1)).ToString();
                if (!float.TryParse(txtPrecioFinalProducto.Text, out float valuePf))
                {
                    txtPrecioFinalProducto.Text = " ";
                    return;
                }
                precioFinal = valuePf;
                txtPrecioFinalProducto.Text = valuePf.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
            }
            else
                txtProcGananciaProducto.Focus();
            
        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                txtDesc.Focus();
                txtDesc.Text = "0";
            }
            else
            {
                float valueP;
                valueP = (Convert.ToSingle(txtPrecioCompraProducto.Text.Split('$')[1]) - (precioCompra * (Convert.ToSingle(txtDesc.Text) / 100)));
                //precioCompra = valueP;
                txtPrecioCompraProducto.Text = valueP.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                txtPrecioCompraProducto_Validating(null, null);
                txtProcGananciaProducto_Validating(null, null);
            }
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento para evitar que el carácter se muestre en el TextBox
            }
        }
        #endregion
    }
}
