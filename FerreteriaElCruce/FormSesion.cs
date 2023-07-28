using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace FerreteriaElCruce
{
    public partial class FormSesion : Form
    {
        Usuario usr;
        public bool verify;
        public FormSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContrasenia.Text))
            {
                usr = new Usuario();
                usr.usuario = txtUsuario.Text;
                usr.contrasenia = txtContrasenia.Text;
                verify = usr.DesEncriptar();
                if (verify)
                {
                    FormLuancher frmL = Application.OpenForms.OfType<FormLuancher>().FirstOrDefault();
                    frmL.rol = usr.IdentificarRol();
                    frmL.sesion = true;
                    frmL.usurario = txtUsuario.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenia.Focus();
                }
            }   
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            usr = new Usuario();
            usr.usuario = txtUsuario.Text;
            verify = usr.ComprobarUsuario();
            if (!verify)
            {
                lblErr.Visible = true;
                txtUsuario.Focus();
            }
            else
                lblErr.Visible = false;
        }
    }
}
