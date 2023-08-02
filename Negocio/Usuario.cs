using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Usuario
    {
        UsuarioDatos usrD;
        public int usrId { get; set; }
        public string rol { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        bool ok;
        public Usuario()
        {
            usrD = new UsuarioDatos();
        }

        public bool ComprobarUsuario()
        {
            object res = usrD.ComprobarUsuario(usuario);
            if (res != null)
            {
                return ok = true;
            }
            else
                return ok = false;

        }
        public bool VerificarPassword()
        {
            usrD = new UsuarioDatos();
            object pass = usrD.ComprobarContrasenia(usuario);
            if (pass.ToString() == contrasenia)
                return ok = true;
            else
            return ok = false;
        }
        public string IdentificarRol()
        {
            usrD = new UsuarioDatos();
            return usrD.IdentificarRol(usuario).ToString();
        }
        public DataTable ConsultarUsuarios()
        {
            usrD = new UsuarioDatos();
            return usrD.ConsultarUsuarios();
        }
        public int crearUsuario()
        {
            usrD = new UsuarioDatos();
            return usrD.crearUsuario(usuario, contrasenia, rol);
        }
        public int ModificarUsuario()
        {
            usrD = new UsuarioDatos();
            return usrD.ModificarUsuario(usuario, contrasenia, rol, usrId);
        }
        public int EliminarUsuario()
        {
            usrD = new UsuarioDatos();
            return usrD.EliminarUsuario(usrId);          
        }
    }
}
