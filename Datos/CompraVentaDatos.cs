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

        public DataTable ObtenerProductosVentaAnt(int nroV)
        {
            conexion = new Conexion();
            string query = $"SELECT producto_id, cantidad_prod_vendida FROM Venta WHERE venta_nro = {nroV}";
            return conexion.ObtenerRegistros(query);
        }

        public int RestablecerStockVentAnt(int pId, int stock)
        {
            conexion = new Conexion();
            string query = $"UPDATE Producto SET cantidad_producto = cantidad_producto + {stock} WHERE producto_id = {pId}";
            return conexion.EjecutarAccion(query);
        }
        public int RestablecerVentAnt(int nroV)
        {
            conexion = new Conexion();
            string query = $"UPDATE Venta SET cantidad_prod_vendida = 0, total_vendido = 0 WHERE venta_nro = {nroV}";
            return conexion.EjecutarAccion(query);
        }
        public DataTable ObtenerVentasPorNumero(int nroV)
        {
            conexion = new Conexion();
            string query = $"SELECT p.producto_id, p.producto_codigo, p.nombre_producto, p.precio_final, v.cantidad_prod_vendida, v.total_vendido, v.facturar_venta, (SELECT SUM(total_vendido) FROM Venta WHERE venta_nro = {nroV}), p.cantidad_producto FROM Producto p INNER JOIN Venta v ON v.producto_id = p.producto_id WHERE v.venta_nro = {nroV}";
            return conexion.ObtenerRegistros(query);
        }
    }
}
