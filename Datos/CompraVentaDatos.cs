using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace Datos
{
    public class CompraVentaDatos
    {
        Conexion conexion;
        public int RealizarCompra(int prodId, float cant, float subTotalC, bool fact, int usrId)
        {
            conexion = new Conexion();
            string query = $"INSERT INTO Compra VALUES (CONVERT(DATE, GETDATE(), 103), {prodId}, {cant.ToString("0.##", CultureInfo.InvariantCulture)}, {subTotalC.ToString("0.##", CultureInfo.InvariantCulture)}, '{fact}', {usrId})";
            return conexion.EjecutarAccion(query); 
        }

        public int SumarStockProducto(float stockTotal, int prodId)
        {
            conexion = new Conexion();
            string query1 = $"SELECT cantidad_producto FROM Producto WHERE producto_id = '{prodId}'";
            float cantActual = Convert.ToInt32(conexion.ObtenerRegistroUnico(query1));
            cantActual += stockTotal;
            string query2 = $"UPDATE Producto SET cantidad_producto = {cantActual.ToString("0.##", CultureInfo.InvariantCulture)} WHERE producto_id = '{prodId}'";
            return conexion.EjecutarAccion(query2);
        }

        public int RealizarVenta(int prodId, float cant, float subTotalC, bool fact, int nroV ,int usrId)
        {
            conexion = new Conexion();
            string query = $"INSERT INTO Venta VALUES (CONVERT(DATE, GETDATE(), 103), {prodId}, {cant.ToString("0.##", CultureInfo.InvariantCulture)}, {subTotalC.ToString("0.##", CultureInfo.InvariantCulture)}, '{fact}', {nroV}, {usrId})";
            return conexion.EjecutarAccion(query);
        }

        public int RestarStockProducto(float stockTotal, int prodId)
        {
            conexion = new Conexion();
            string query1 = $"SELECT cantidad_producto FROM Producto WHERE producto_id = '{prodId}'";
            float cantActual = Convert.ToInt32(conexion.ObtenerRegistroUnico(query1));
            cantActual -= stockTotal;
            string query2 = $"UPDATE Producto SET cantidad_producto = {cantActual.ToString("0.##", CultureInfo.InvariantCulture)} WHERE producto_id = '{prodId}'";
            return conexion.EjecutarAccion(query2);
        }

        public DataTable ObtenerLogVentas()
        {
            conexion = new Conexion();
            string query = "SELECT v.fecha_venta AS Fecha, p.nombre_producto AS 'Nombre de Producto', v.cantidad_prod_vendida AS Cantidad, v.total_vendido AS '$ Total', v.venta_nro AS 'Nro. de Venta', u.nombre_usuario AS 'Usuario' FROM Venta v INNER JOIN Producto p ON v.producto_id = p.producto_id INNER JOIN usuario u ON u.usr_id = v.usr_id Order BY v.venta_nro DESC";
            return conexion.ObtenerRegistros(query);
        }
    }
}
