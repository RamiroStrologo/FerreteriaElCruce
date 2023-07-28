using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Datos
{
    public class InformesDatos
    {
        Conexion conexion;
        public DataTable TopCompras(string fechaIni, string fechaFin)
        {
            conexion = new Conexion();
            string query = $" SELECT TOP 10 p.nombre_producto, (SELECT SUM(cantidad_prod_comprada) FROM Compra  WHERE producto_id = p.producto_id AND fecha_compra BETWEEN '{fechaIni}' AND '{fechaFin}') AS total_cantidad, " +
            $"(SELECT SUM(total_comprado) FROM Compra  WHERE producto_id = p.producto_id AND fecha_compra BETWEEN '{fechaIni}' AND '{fechaFin}') AS total_pagado FROM Compra c INNER JOIN Producto p ON c.producto_id = p.producto_id " +
            $"WHERE c.fecha_compra BETWEEN '{fechaIni}' AND '{fechaFin}' GROUP BY p.producto_id, p.nombre_producto ORDER BY total_pagado DESC ";
            return conexion.ObtenerRegistros(query);
        }
        public DataTable ObtenerComprasTodo(string fechaIni, string fechaFin)
        {
            conexion = new Conexion();
            string query = $" SELECT p.producto_codigo AS Código, p.nombre_producto AS Descripción, (SELECT SUM(cantidad_prod_comprada) FROM Compra  WHERE producto_id = p.producto_id) AS 'Cant. comprada', " +
            "(SELECT SUM(total_comprado) FROM Compra  WHERE producto_id = p.producto_id) AS 'Total pagado' FROM Compra c INNER JOIN Producto p ON c.producto_id = p.producto_id " +
            $"WHERE c.fecha_compra BETWEEN '{fechaIni}' AND '{fechaFin}' GROUP BY p.producto_id, p.nombre_producto, p.producto_codigo ORDER BY 'Total pagado' DESC ";
            return conexion.ObtenerRegistros(query);
        }

        public float ObtenerTotalEnNegro(string fechaIni, string fechaFin)
        {
            conexion = new Conexion();
            string query = $"SELECT SUM(total_comprado) AS 'total negro' FROM Compra WHERE fecha_compra BETWEEN '{fechaIni}' AND '{fechaFin}' AND facturar_compra = 0";
            DataTable dt = conexion.ObtenerRegistros(query);
            if (float.TryParse(dt.Rows[0][0].ToString(), out float value))
                return value;
            else
                return 0;           
        }
        public float ObtenerTotalEnBlanco(string fechaIni, string fechaFin)
        {
            conexion = new Conexion();
            string query = $"SELECT SUM(total_comprado) AS 'total blanco' FROM Compra WHERE fecha_compra BETWEEN '{fechaIni}' AND '{fechaFin}' AND facturar_compra = 1";
            DataTable dt = conexion.ObtenerRegistros(query);
            if (float.TryParse(dt.Rows[0][0].ToString(), out float value))
                return value;
            else
                return 0;
        }
        /// ///////////////////////////////////////////// Ventas

        public DataTable TopVentas(string fechaIni, string fechaFin)
        {
            conexion = new Conexion();
            string query = $" SELECT TOP 10 p.nombre_producto, (SELECT SUM(cantidad_prod_vendida) FROM Venta WHERE producto_id = p.producto_id AND fecha_venta BETWEEN '{fechaIni}' AND '{fechaFin}') AS total_cantidad, " +
            $"(SELECT SUM(total_vendido) FROM Venta WHERE producto_id = p.producto_id AND fecha_venta BETWEEN '{fechaIni}' AND '{fechaFin}') AS total_pagado FROM Venta v INNER JOIN Producto p ON v.producto_id = p.producto_id " +
            $"WHERE v.fecha_venta BETWEEN '{fechaIni}' AND '{fechaFin}' GROUP BY p.producto_id, p.nombre_producto ORDER BY total_pagado DESC ";
            return conexion.ObtenerRegistros(query);
        }
        public DataTable ObtenerVentasTodo(string fechaIni, string fechaFin)
        {
            conexion = new Conexion();
            string query = $" SELECT p.producto_codigo AS Código, p.nombre_producto AS Descripción, (SELECT SUM(cantidad_prod_vendida) FROM Venta  WHERE producto_id = p.producto_id) AS 'Cant. vendida', " +
            "(SELECT SUM(total_vendido) FROM Venta  WHERE producto_id = p.producto_id) AS 'Total Vendido' FROM Venta v INNER JOIN Producto p ON v.producto_id = p.producto_id " +
            $"WHERE v.fecha_venta BETWEEN '{fechaIni}' AND '{fechaFin}' GROUP BY p.producto_id, p.nombre_producto, p.producto_codigo ORDER BY 'Total Vendido' DESC ";
            return conexion.ObtenerRegistros(query);
        }
        public float ObtenerTotalEnNegroV(string fechaIni, string fechaFin)
        {
            conexion = new Conexion();
            string query = $"SELECT SUM(total_vendido) AS 'total negro' FROM Venta WHERE fecha_venta BETWEEN '{fechaIni}' AND '{fechaFin}' AND facturar_venta = 0";
            DataTable dt = conexion.ObtenerRegistros(query);
            if (float.TryParse(dt.Rows[0][0].ToString(), out float value))
                return value;
            else
                return 0;
        }
        public float ObtenerTotalEnBlancoV(string fechaIni, string fechaFin)
        {
            conexion = new Conexion();
            string query = $"SELECT SUM(total_vendido) AS 'total blanco' FROM Venta WHERE fecha_venta BETWEEN '{fechaIni}' AND '{fechaFin}' AND facturar_venta = 1";
            DataTable dt = conexion.ObtenerRegistros(query);
            if (float.TryParse(dt.Rows[0][0].ToString(), out float value))
                return value;
            else
                return 0;
        }
    }
}
