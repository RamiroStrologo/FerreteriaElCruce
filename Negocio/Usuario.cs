using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
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
        string hashedPassword;

        public Usuario()
        {
            usrD = new UsuarioDatos();
        }

        public void Encriptar()
        {
            usrD = new UsuarioDatos();
            hashedPassword = BCrypt.Net.BCrypt.HashPassword(contrasenia);
            // hashedPassword ahora contiene la contraseña encriptada
        }
        public bool DesEncriptar()
        {
            usrD = new UsuarioDatos();
            hashedPassword = usrD.ComprobarContrasenia(usuario).ToString();
            // Verificar si una contraseña ingresada coincide con la contraseña encriptada
            bool passwordsMatch = BCrypt.Net.BCrypt.Verify(contrasenia, hashedPassword);
            return passwordsMatch;
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
            Encriptar();
            return usrD.crearUsuario(usuario, hashedPassword, rol);
        }
        public int ModificarUsuario()
        {
            usrD = new UsuarioDatos();
            Encriptar();
            return usrD.ModificarUsuario(usuario, hashedPassword, rol, usrId);
        }
        public int EliminarUsuario()
        {
            usrD = new UsuarioDatos();
            return usrD.EliminarUsuario(usrId);          
        }
    }
}
