using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DataBase
    {
        public int ComprobarBDExiste()
        {
            Conexion con = new Conexion();
            int res = con.ComprobarBDExiste();
            if (res == 0)
            {
                con.CreateDataBase();
                return 0;
            }
            else if (res == 1)
                return 1;
            else 
                return -1;
        }

        public void CreateDataBase()
        {
            Conexion con = new Conexion();
            con.CreateDataBase();
        }
    }
}
