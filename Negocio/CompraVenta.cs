using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class CompraVenta
    {
        public int productoId { get; set; }
        public int usrId { get; set; }
        public int nroV { get; set; }
        public string usuario { get; set; }
        public float cantidad { get; set; }
        public float subTotalC { get; set; }
        public string facturar { get; set; }
        CompraVentaDatos compraVentaD;
        UsuarioDatos usrD;
        public int RealizarCompra()
        {
            compraVentaD = new CompraVentaDatos();
            facturar = (facturar == "N") ? "false" : "true";
            usrId = Convert.ToInt32(ObtenerUsrId());
            return compraVentaD.RealizarCompra(productoId, cantidad, subTotalC, Convert.ToBoolean(facturar), usrId);
        }
        public int SumarStockProducto()
        {
            compraVentaD = new CompraVentaDatos();
            return compraVentaD.SumarStockProducto(cantidad, productoId);
        }

        public int RealizarVenta()
        {
            compraVentaD = new CompraVentaDatos();
            facturar = (facturar == "N") ? "false" : "true";
            usrId = Convert.ToInt32(ObtenerUsrId());
            return compraVentaD.RealizarVenta(productoId, cantidad, subTotalC, Convert.ToBoolean(facturar), nroV, usrId);
        }
        public object ObtenerUsrId()
        {
            usrD = new UsuarioDatos();
            return usrD.ObtenerUsrId(usuario);
        }
        public int RestarStockProducto()
        {
            compraVentaD = new CompraVentaDatos();
            return compraVentaD.RestarStockProducto(cantidad, productoId);
        }

        public DataTable ObtenerLogVentas()
        {
            compraVentaD = new CompraVentaDatos();
            return compraVentaD.ObtenerLogVentas();
        }
        
        public DataTable ObtenerVentaYRestablecer()
        {
            compraVentaD = new CompraVentaDatos();
            DataTable pIdVenAnt = new DataTable();
            DataTable ventaAnt = new DataTable();
            pIdVenAnt = compraVentaD.ObtenerProductosVentaAnt(nroV);
            if (pIdVenAnt.Rows.Count > 0)
            {
                for (int i = 0; i <= pIdVenAnt.Rows.Count - 1; i++)
                {
                    compraVentaD.RestablecerStockVentAnt(Convert.ToInt32(pIdVenAnt.Rows[i][0]), Convert.ToInt32(pIdVenAnt.Rows[i][1]));
                }
                ventaAnt = compraVentaD.ObtenerVentasPorNumero(nroV);
                compraVentaD.RestablecerVentAnt(nroV);
                return ventaAnt;
            }
            else
                return pIdVenAnt;
    
        }
    }
}
