using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FerreteriaElCruce
{
    public partial class FormInventario : Form
    {
        public string rol { get; set; } = "Admin";
        public event EventHandler FormBroughtToFront;
        Producto producto;
        int productoIdMod = 0;
        string productoNomMod = "";
        public FormInventario()
        {
            InitializeComponent();
            FormBroughtToFront += FormInventario_FormBroughtToFront;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            if (rol != "Admin")
                cmsProducto.Enabled = false;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            producto = new Producto();
            dgvInventario.DataSource = producto.ConsultaProductosDatos();
            StockMarcas();
        }
        private void StockMarcas()
        {
            double umbral;
            dgvInventario.Columns[0].Visible = false;
            for (int i = 0; i <= dgvInventario.Rows.Count - 1; i++)
            {
                umbral = Convert.ToSingle(dgvInventario[3, i].Value) * 1.3;
                if (Convert.ToInt32(dgvInventario[4, i].Value) <= Convert.ToInt32(dgvInventario[3, i].Value))
                    dgvInventario[4, i].Style.BackColor = Color.Red;
                else if (Convert.ToInt32(dgvInventario[4, i].Value) <= umbral && Convert.ToInt32(dgvInventario[4, i].Value) > Convert.ToInt32(dgvInventario[3, i].Value))
                    dgvInventario[4, i].Style.BackColor = Color.Orange;
            }
}

        private void FormInventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormLuancher);
            frm.WindowState = FormWindowState.Normal;
            frm.BringToFront();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormConfiguracion);
            if (frm == null)
            {
                FormConfiguracion form = new FormConfiguracion();
                form.configCall = "AltaProducto";
                form.Show();
            }
            else
                frm.BringToFront();
           
        }

        private void chkStockMinimo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvInventario.SuspendLayout();
                dgvInventario.ClearSelection();
                if (chkStockMinimo.Checked)
                {

                    for (int i = 0; i <= dgvInventario.Rows.Count - 1; i++)
                    {
                        if (dgvInventario[4, i].Style.BackColor != Color.Red && dgvInventario[4, i].Style.BackColor != Color.Orange)
                        {
                            dgvInventario.Rows[i].Visible = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= dgvInventario.Rows.Count - 1; i++)
                         dgvInventario.Rows[i].Visible = true;

                }
            }
            catch(InvalidOperationException er)
            {
                MessageBox.Show("No hay filas para ocultar o no hay filas con registros resaltados(Stock en mínimo o umbral)", er.Message);
                chkStockMinimo.Checked = false;
            }
       
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            producto = new Producto();
            if (!string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                producto.palabraBuscar = txtBuscador.Text;
                Cursor.Current = Cursors.WaitCursor;
                dgvInventario.DataSource = producto.AutoCompletarCmbLike();
                Cursor.Current = Cursors.Default;
                StockMarcas();
            }
            else
                CargarGrilla();
        }

        private void dgvInventario_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hitTestInfo = dgvInventario.HitTest(e.X,e.Y);
                if(hitTestInfo.RowIndex >= 0)
                {
                    dgvInventario.ClearSelection();
                    dgvInventario.Rows[hitTestInfo.RowIndex].Selected = true;
                    productoIdMod = Convert.ToInt32(dgvInventario[0, hitTestInfo.RowIndex].Value);
                    productoNomMod = dgvInventario[1, hitTestInfo.RowIndex].Value.ToString() + '-' + dgvInventario[2, hitTestInfo.RowIndex].Value.ToString();
                    cmsProducto.Show(dgvInventario, e.Location);
                }
               
            }
        }

        private void tsmModificar_Click(object sender, EventArgs e)
        {
            txtBuscador.Text = "";
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormConfiguracion);
            if (frm == null)
            {
                FormConfiguracion form = new FormConfiguracion();
                form.configCall = "ModificarProducto";
                form.productoIdMod = productoIdMod;
                form.productoNomMod = productoNomMod;
                form.Show();
            }
            else
                frm.BringToFront();
        }

        private void FormInventario_FormBroughtToFront(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        public void OnFormBroughtToFront()
        {
            FormBroughtToFront?.Invoke(this, EventArgs.Empty);
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
                e.Handled = true;
        }
    }
}
