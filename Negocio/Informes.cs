using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class Informes
    {
        public string fechaIni { get; set; }
        public string fechaFin { get; set; }
        InformesDatos infD;
        public DataTable TopCompras()
        {
            infD = new InformesDatos();
            return infD.TopCompras(fechaIni, fechaFin);
        }
        public string InformeTotalCompras()
        {
            infD = new InformesDatos();
            float totalN = infD.ObtenerTotalEnNegro(fechaIni, fechaFin);
            float totalB = infD.ObtenerTotalEnBlanco(fechaIni, fechaFin);
            string totales = totalN.ToString();
            totales += " " + totalB.ToString() + " ";
            totales += (totalN + totalB).ToString();
            return totales;  
        }
        public DataTable ObtenerComprasTodo()
        {
            infD = new InformesDatos();
            return infD.ObtenerComprasTodo(fechaIni, fechaFin);
        }
        /////////// Ventas
        public DataTable TopVentas()
        {
            infD = new InformesDatos();
            return infD.TopVentas(fechaIni, fechaFin);
        }
        public DataTable ObtenerVentasTodo()
        {
            infD = new InformesDatos();
            return infD.ObtenerVentasTodo(fechaIni, fechaFin);
        }
        public string InformeTotalVentas()
        {
            infD = new InformesDatos();
            float totalN = infD.ObtenerTotalEnNegroV(fechaIni, fechaFin);
            float totalB = infD.ObtenerTotalEnBlancoV(fechaIni, fechaFin);
            string totales = totalN.ToString();
            totales += " " + totalB.ToString() + " ";
            totales += (totalN + totalB).ToString();
            return totales;
        }
    }
}
