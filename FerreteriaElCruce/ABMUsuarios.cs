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
    public partial class ABMUsuarios : Form
    {
        Usuario usr;
        bool create = false;
        public ABMUsuarios()
        {
            InitializeComponent();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                create = false;
                groupBox2.Enabled = true;
                groupBox2.Text = "(Modificar) Datos de usuario:";
                btnCrear.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                txtNomUsr.Text = dgvUsuarios[1, dgvUsuarios.CurrentRow.Index].Value.ToString();
                cmbRol.Text = dgvUsuarios[2, dgvUsuarios.CurrentRow.Index].Value.ToString();
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox2.Text = "(Crear) Datos de usuario:";
            btnCrear.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            create = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvUsuarios.SelectedRows.Count > 0)
            {
                if (dgvUsuarios[2, dgvUsuarios.CurrentRow.Index].Value.ToString() != "Admin")
                {
                    DialogResult dr = MessageBox.Show("¿Desea eliminar el usuario? Quedará inactivo pero no se perderan sus datos", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        usr = new Usuario();
                        usr.usrId = Convert.ToInt32(dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value);
                        usr.EliminarUsuario();
                        ReiniciarForm();
                    }                
                }
                else
                    MessageBox.Show("No se pueden eliminar los usuarios Administradores", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int res = 0;
            if (txtClave.Text == txtClaveRep.Text)
            {
                usr = new Usuario();
                if (create)
                   res = crearUsuario();
                else
                    res = ModificarUsuario();
                if(res > 0)
                    MessageBox.Show(this, "Operación realizada con exito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show(this, "Hubo un error al intentar realizar la operación, comuníquese con el proveedor del Software", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ReiniciarForm();
            }
            else
                MessageBox.Show("La contraseña no coincide en los campos", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private int crearUsuario()
        {
            usr.rol = cmbRol.Text;
            usr.usuario = txtNomUsr.Text;
            usr.contrasenia = txtClave.Text;
            return usr.crearUsuario();
        }
        private int ModificarUsuario()
        {
            usr.rol = cmbRol.Text;
            usr.usuario = txtNomUsr.Text;
            usr.contrasenia = txtClave.Text;
            usr.usrId = Convert.ToInt32(dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value);
            return usr.ModificarUsuario();
        }
        private void ABMUsuarios_Load(object sender, EventArgs e)
        {
            usr = new Usuario();
            dgvUsuarios.DataSource = usr.ConsultarUsuarios();
        }
        private void ReiniciarForm()
        {
            txtClave.Text = "";
            txtClaveRep.Text = "";
            txtNomUsr.Text = "";
            cmbRol.Text = "";
            groupBox2.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCrear.Enabled = true;
            ABMUsuarios_Load(null, null);
        }


        private void txtNomUsr_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomUsr.Text))
                txtNomUsr.Focus();
            else
            {
                usr.usuario = txtNomUsr.Text;
                bool ok = usr.ComprobarUsuario();
                if (ok)
                {
                    MessageBox.Show("El usuario ya exista, elija otro nombre", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomUsr.Focus();
                }
                   
            }

        }

        private void cmbRol_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbRol.Text))
                cmbRol.Focus();
        }

        private void txtClave_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClave.Text))
                txtClave.Focus();
        }

        private void txtClaveRep_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveRep.Text) || txtClave.Text != txtClaveRep.Text)
            {
                txtClaveRep.Focus();
            }          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReiniciarForm();
        }

 
    }
}
