using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.StyledXmlParser.Css.Validate.Impl.Datatype;
using Negocio;

namespace FerreteriaElCruce
{
    public partial class FormModPrecioMasivo : Form
    {
        Producto producto;
        DataTable dtConsulta;
        CultureInfo culture = new CultureInfo("en-US");
        bool modificar = false;
        public FormModPrecioMasivo()
        {
            InitializeComponent();
        }

        private void cmbMarcasMod_Enter(object sender, EventArgs e)
        {
            if(cmbMarcasMod.Items.Count <= 0)
            {
                producto = new Producto();
                if (rdbMarca.Checked)
                {
                    producto.tipoAtributo = "bMarca";
                    cmbMarcasMod.DisplayMember = "nombre_marca";
                    cmbMarcasMod.ValueMember = "marca_id";
                    cmbMarcasMod.AutoCompleteCustomSource = autoCompletarCmb(cmbMarcasMod);
                }
                else
                {
                    producto.tipoAtributo = "bProveedor";
                    cmbMarcasMod.DisplayMember = "nombre_proveedor";
                    cmbMarcasMod.ValueMember = "proveedor_id";
                    cmbMarcasMod.AutoCompleteCustomSource = autoCompletarCmb(cmbMarcasMod);
                }
            }
        }

        private AutoCompleteStringCollection autoCompletarCmb(ComboBox cmb)
        {
            DataTable stringColl = new DataTable();
            AutoCompleteStringCollection sugerencias = new AutoCompleteStringCollection();
            stringColl = producto.AutoCompletarCmbProvMarcaNicho();
            cmb.DataSource = stringColl;
            foreach(DataRow row in stringColl.Rows) 
            {
                sugerencias.Add(Convert.ToString(row[cmb.DisplayMember.ToString()]));
            }
            return sugerencias;
        }

        private void cmbMarcasMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            producto = new Producto();
            dtConsulta = new DataTable();
            dgvProductosMarca.Rows.Clear();
            txtAumento.Text = "0";
            producto.marcaId = Convert.ToInt32(cmbMarcasMod.SelectedValue);
            dtConsulta = producto.ConsultarProductoXMarca();
            for(int i = 0; i <= dtConsulta.Rows.Count - 1; i++)
            {
                dgvProductosMarca.Rows.Add();
                dgvProductosMarca[0, i].Value = dtConsulta.Rows[i][0];
                dgvProductosMarca[1, i].Value = dtConsulta.Rows[i][1];
                dgvProductosMarca[2, i].Value = dtConsulta.Rows[i][2];
                dgvProductosMarca[4, i].Value = dtConsulta.Rows[i][3];
                dgvProductosMarca[6, i].Value = dtConsulta.Rows[i][4];
                dgvProductosMarca[7, i].Value = dtConsulta.Rows[i][5];
            }
            dgvProductosMarca.DefaultCellStyle.Font = new Font("Tahoma", 16);
        }

        private void txtAumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Cancelar el evento para evitar que el carácter se muestre en el TextBox
            }
            //else if(txtAumento.Text == "0")
            //    txtAumento.SelectionStart = 1;
        }

        private void txtAumento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAumento.Text))
                txtAumento.Text = "0";
            if (txtAumento.Text != "0")
                modificar = true;
            else
                modificar = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtAumento.Text, out float result))
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Se realizará el cálculo sobre los registros seleccionados", "Calcular descuento", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (txtAumento.Text != "0")
                    {
                        for (int i = 0; i <= dgvProductosMarca.Rows.Count - 1; i++)
                        {
                            if (Convert.ToBoolean(dgvProductosMarca.Rows[i].Cells[8].Value) == true)
                            {
                                dgvProductosMarca[3, i].Value = (Convert.ToSingle(dgvProductosMarca[2, i].Value, culture) * ((Convert.ToSingle(txtAumento.Text) / 100) + 1)).ToString("0.##", CultureInfo.InvariantCulture);
                                dgvProductosMarca[5, i].Value = (Convert.ToSingle(dgvProductosMarca[3, i].Value, culture) * ((Convert.ToSingle(dgvProductosMarca[6, i].Value) / 100) + 1)).ToString("0.##", CultureInfo.InvariantCulture);
                                dgvProductosMarca.Rows[i].Cells[3].Style.BackColor = Color.GreenYellow;
                                dgvProductosMarca.Rows[i].Cells[5].Style.BackColor = Color.GreenYellow;
                            }
                        }
                        btnCalcular.Enabled = false;
                        txtAumento.Enabled = false;
                        cmbMarcasMod.Enabled = false;
                        rdbMarca.Enabled = false;
                        rdbProv.Enabled = false;
                    }
                }
            }
            else
                MessageBox.Show("El dato ingresado no es valido", "Calculo fallido ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.Default;
        }

        private void btnAceptaryVolver_Click(object sender, EventArgs e)
        {
            ConfirmarOperacion();
            if (modificar)
            {
                Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormConfiguracion);
                Form frmI = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormInventario);
                if (frmI == null)
                {
                    FormInventario form = new FormInventario();
                    form.Show();
                }
                frmC.Close();
            }       
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ConfirmarOperacion();
            cmbMarcasMod.SelectedIndex = -1;
            Cursor.Current = Cursors.Default;
        }

        private void ConfirmarOperacion()
        {
            if (modificar)
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(this, "¿Desea confirmar las modificaciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    resultadoAlta(ModificarPrecioCompraProdXMarca());
            }   btnCalcular.Enabled = true;

        }
        public int ModificarPrecioCompraProdXMarca()
        {
            producto = new Producto();
            int resultado = 0;
            producto.marcaId = Convert.ToInt32(cmbMarcasMod.SelectedValue);
            for(int i = 0; i <= dgvProductosMarca.Rows.Count - 1; i++)
            {
                producto.precioCompra = Convert.ToSingle(dgvProductosMarca[3, i].Value, culture);
                producto.precioFinal = Convert.ToSingle(dgvProductosMarca[5, i].Value, culture);
                producto.productoId = Convert.ToInt32(dgvProductosMarca[7, i].Value);
                resultado = producto.ModificarPrecioCompraProdXMarca();
            }
            return resultado;
        }

        public void resultadoAlta(int resultado)
        {
                if (resultado != 0)
                    MessageBox.Show(this, "Registros modificados con exito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show(this, "Hubo un error al intentar modificar los registros, comuníquese con el proveedor del Software", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);           
        }

        private void FormModPrecioMasivo_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbMarcasMod.DataSource = null;
            btnCalcular.Enabled = true;
            cmbMarcasMod.Enabled = true;
            txtAumento.Enabled = true;
            rdbMarca.Enabled = true;
            rdbProv.Enabled = true;
            txtAumento.Text = "0";
            dgvProductosMarca.Rows.Clear();
        }

        private void rdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            cmbMarcasMod.DataSource = null;
            txtAumento.Text = "0";
            dgvProductosMarca.Rows.Clear();
            if (rdbMarca.Checked)
                lblAtributo.Text = "Marcas:";
            else
                lblAtributo.Text = "Prov.:";
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSelectAll.Checked)
            {
                for(int i = 0; i <= dgvProductosMarca.Rows.Count -1 ; i++)
                {
                    dgvProductosMarca[8, i].Value = true;
                }
            }
            else
            {
                for (int i = 0; i <= dgvProductosMarca.Rows.Count - 1; i++)
                {
                    dgvProductosMarca[8, i].Value = false;
                }
            }
        }
    }
}
