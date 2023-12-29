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
        Conexion con;
        public DataBase() {
            con = new Conexion();
        }
        public int ComprobarBDExiste()
        {
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
            con.CreateDataBase();
        }
        public bool BackUpBd()
        {
            return con.BackUpBd();
        }
        public void CorregirCodigoProducto()
        {
            con.CorregirCodigoProdcutos();
        }
    }
}
