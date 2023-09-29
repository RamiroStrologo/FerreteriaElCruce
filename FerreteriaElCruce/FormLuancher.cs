using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaElCruce
{
    public partial class FormLuancher : Form
    {
        DataBase db;
        public bool sesion { get; set; } = false;
        public string rol { get; set; }
        public string usurario { get; set; }
        public FormLuancher()
        {
            InitializeComponent();
            if (DateTime.Now.ToString("dd/MM/yyyy") == "20/08/2023")
            {
                MessageBox.Show("El perdiodo de prueba finalizó. Comunicarse con el Proveedor del Software", "Error: prueba finalizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                btnCompras.Enabled = false;
                btnVentas.Enabled = false;
                btnInformes.Enabled = false;
                btnConfig.Enabled = false;
                btnInventario.Enabled = false;
                btnConfig.Enabled = false;
            }

        }
        private void Permisos()
        {
            if (sesion)
            {
                switch (rol)
                {
                    case "Admin":
                        btnCompras.Enabled = true;
                        btnConfig.Enabled = true;
                        btnInformes.Enabled = true;
                        btnInventario.Enabled = true;
                        btnVentas.Enabled = true;
                        break;
                    case "Empleado":
                        btnCompras.Enabled = false;
                        btnConfig.Enabled = false;
                        btnInformes.Enabled = false;
                        btnInventario.Enabled = true;
                        btnVentas.Enabled = true;
                        break;
                }
                btnSesion.Text = "CERRAR SESIÓN";
            }
            else
            {
                btnCompras.Enabled = false;
                btnConfig.Enabled = false;
                btnInformes.Enabled = false;
                btnInventario.Enabled = false;
                btnVentas.Enabled = false;
                btnSesion.Text = "INICIAR SESIÓN";
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormInventario);
            if (frm == null)
            {
                FormInventario form = new FormInventario();
                form.rol = rol;
                form.Show();
            }
            else
                frm.BringToFront();

            this.WindowState = FormWindowState.Minimized;

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormConfiguracion);
            if (frm == null)
            {
                FormConfiguracion form = new FormConfiguracion();
                form.Show();
            }
            else
                frm.BringToFront();

            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLuancher_Load(object sender, EventArgs e)
        {
            db = new DataBase();
            int res = db.ComprobarBDExiste();
            if (res == 0)
                MessageBox.Show("Se creó la base de dato con éxito", "Base de datos creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (res == -1)
                MessageBox.Show("Error al intentar conectarse al servidor.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormComprasYVentas);
            FormComprasYVentas frmV = Application.OpenForms.OfType<FormComprasYVentas>().FirstOrDefault();
            if (frm == null)
            {
                FormComprasYVentas form = new FormComprasYVentas();
                form.usuario = usurario;
                form.Ventas = false;
                form.Show();
            }
            else
            {
                if (frmV.Ventas)
                {

                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(this, "¿Desea abrir el modulo de Ventas? Perderá las operaciones no guardadas del modulo de Compras", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        frm.Close();
                        FormComprasYVentas form = new FormComprasYVentas();
                        form.Ventas = false;
                        form.Show();
                    }
                }
                else
                    frm.BringToFront();

            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormInformesComprasVentas);
            if (frm == null)
            {
                FormInformesComprasVentas form = new FormInformesComprasVentas();
                form.Show();
            }
            else
            {
                frm.BringToFront();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormComprasYVentas);
            FormComprasYVentas frmV = Application.OpenForms.OfType<FormComprasYVentas>().FirstOrDefault();
            if (frm == null)
            {
                FormComprasYVentas form = new FormComprasYVentas();
                form.Ventas = true;
                form.usuario = usurario;
                form.Show();
            }
            else
            {
                if (!frmV.Ventas)
                {

                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(this, "¿Desea abrir el modulo de Compras? Perderá las operaciones no guardadas del modulo de Ventas", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        frm.Close();
                        FormComprasYVentas form = new FormComprasYVentas();
                        form.Ventas = true;
                        form.Show();
                    }               
                }
                else
                    frm.BringToFront();
             
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            if (!sesion)
            {
                Form frm = new FormSesion();
                frm.ShowDialog();
            }
            else
            {
                var formulariosAbiertos = Application.OpenForms.Cast<Form>().ToList();

                foreach (var formulario in formulariosAbiertos)
                {
                    if (formulario != this)
                    {
                        formulario.Close();
                    }
                }
                sesion = false;
                btnCompras.Enabled = false;
                btnVentas.Enabled = false;
                btnInformes.Enabled = false;
                btnConfig.Enabled = false;
                btnInventario.Enabled = false;
                btnConfig.Enabled = false;
            }
            Permisos();
        }

    }
}
