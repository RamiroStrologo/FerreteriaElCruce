using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDatos
    {
        Conexion conexion;
        public UsuarioDatos() 
        { 
            conexion = new Conexion();
        }
        public object ComprobarContrasenia(string nombreUsuario)
        {
            conexion = new Conexion();
            string query = $"SELECT contrasenia FROM usuario WHERE nombre_usuario = '{nombreUsuario}' AND activo = 1";
            return conexion.ObtenerRegistroUnico(query);
        }

        public object ComprobarUsuario(string nombreUsuario)
        {
            conexion = new Conexion();
            string query = $"SELECT nombre_usuario FROM usuario WHERE nombre_usuario = '{nombreUsuario}' AND activo = 1";
            return conexion.ObtenerRegistroUnico(query);
        }
        public object IdentificarRol(string nombreUsuario)
        {
            conexion = new Conexion();
            string query = $"SELECT rol FROM usuario WHERE nombre_usuario = '{nombreUsuario}' AND activo = 1";
            return conexion.ObtenerRegistroUnico(query);
        }
        public DataTable ConsultarUsuarios()
        {
            conexion = new Conexion();
            string query = "SELECT usr_id AS 'Id', nombre_usuario AS 'Usuario', rol AS 'Rol en el sistema' FROM usuario WHERE activo = 1 ORDER BY Rol";
            return conexion.ObtenerRegistros(query);
        }
        public object ObtenerUsrId(string nombreUsuario)
        {
            conexion = new Conexion();
            string query = $"SELECT usr_id FROM usuario WHERE nombre_usuario = '{nombreUsuario}' AND activo = 1";
            return conexion.ObtenerRegistroUnico(query);
        }
        public int crearUsuario(string nombreUsuario, string contrasenia, string rol)
        {
            conexion = new Conexion();
            string query = $"INSERT INTO usuario VALUES ('{rol}', '{nombreUsuario}', '{contrasenia}', 1)";
            return conexion.EjecutarAccion(query);
        }
        public int ModificarUsuario(string nombreUsuario, string contrasenia, string rol, int usrId)
        {
            conexion = new Conexion();
            string query = $"UPDATE usuario SET nombre_usuario = '{nombreUsuario}', contrasenia = '{contrasenia}', rol = '{rol}' WHERE usr_id = {usrId}";
            return conexion.EjecutarAccion(query);
        }
        public int EliminarUsuario(int usr_id)
        {
            conexion = new Conexion();
            string query = $"UPDATE usuario SET activo = 0 WHERE usr_id = {usr_id}";
            return conexion.EjecutarAccion(query);
        }
    }
}
