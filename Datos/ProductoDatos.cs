using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Datos
{
    public class ProductoDatos
    {
        Conexion conexion;
        DataTable dtConsultas;
        public int AltaProveedorMarcaNicho(string nombre, string atributo)
        {
            conexion = new Conexion();
            string query = $"INSERT INTO {atributo} VALUES ('{nombre}')";
            return conexion.EjecutarAccion(query);
        }

        public int AltaProducto(string descripcion, float precioCompra, float porcGanancia, float precioFinal, int stockMin, int cantStock ,int pId, int nId, int mId, int prodId, string prodCod)
        {
            conexion = new Conexion();
            string query = $"INSERT INTO Producto VALUES ('{prodCod}', '{descripcion}', {precioCompra.ToString("0.##", CultureInfo.InvariantCulture)}, {porcGanancia}, {precioFinal.ToString("0.##", CultureInfo.InvariantCulture)}, {stockMin}, {cantStock}, {pId}, {nId}, {mId})";
            return conexion.EjecutarAccion(query);
        }
        public string ObtenerUltimoCodXPasillo(string pasillo)
        {
            conexion = new Conexion();
            string query = $"SELECT MAX(producto_codigo) FROM Producto WHERE producto_codigo LIKE '{pasillo}%'";       
            return conexion.ObtenerRegistroUnico(query).ToString(); 
        }
        public int ModificarProducto(string descripcion, float precioCompra, float porcGanancia, float precioFinal, int stockMin, int cantStock ,int pId, int nId, int mId, int prodId, string newProdId)
        {
            conexion = new Conexion();
            string query = $"UPDATE Producto SET producto_codigo = '{newProdId}', nombre_producto = '{descripcion}', precio_compra = {precioCompra.ToString("0.##", CultureInfo.InvariantCulture)}, porc_ganancia = {porcGanancia}, precio_final = {precioFinal.ToString("0.##", CultureInfo.InvariantCulture)}, stock_minimo = {stockMin}, proveedor_id = {pId}, nicho_id = {nId}, marca_id = {mId}, cantidad_producto = {cantStock} WHERE producto_id = {prodId}";
            return conexion.EjecutarAccion(query);
        }

        public DataTable ConsultaAtributos(string atributo, string atributoLowercase)
        {
            dtConsultas = new DataTable();
            conexion = new Conexion() ;
            string query = $"SELECT nombre_{atributoLowercase},{atributoLowercase}_id FROM {atributo}";
            return conexion.ObtenerRegistros(query);
        }
        public DataTable ConsultaProducto(string buscar)
        {
            dtConsultas = new DataTable();
            conexion = new Conexion();
            string query = $"SELECT p.*, CONCAT(producto_codigo, '-', nombre_producto) AS 'codesc'  FROM Producto p WHERE CONCAT(producto_codigo, '-', nombre_producto) LIKE '%{buscar}%'";
           return conexion.ObtenerRegistros(query);
        }
        public DataTable ConsultaProductosDatos()
        {
            dtConsultas = new DataTable();
            conexion = new Conexion();
            string query = "SELECT prod.producto_Id, producto_codigo AS Código, prod.nombre_producto AS Descripción, prod.stock_minimo AS 'Stock Minimo', prod.cantidad_producto AS 'Cant. en Existencia', prod.precio_compra AS '$ Compra', prod.porc_ganancia AS '% de Ganancia', prod.precio_final AS '$ Venta', prov.nombre_proveedor AS Proveedor, n.nombre_nicho AS Nicho, m.nombre_marca AS Marca FROM Producto prod INNER JOIN Proveedor prov ON prod.proveedor_id = prov.proveedor_id INNER JOIN Marca m ON m.marca_id = prod.marca_id INNER JOIN Nicho n ON n.nicho_id = prod.nicho_id";
            return conexion.ObtenerRegistros(query);
        }
        public DataTable ConsultarProductoSeleccionado(int prodId)
        {
            dtConsultas = new DataTable();
            conexion = new Conexion();
            string query = $"SELECT * FROM Producto prod INNER JOIN Proveedor prov ON prod.proveedor_id = prov.proveedor_id INNER JOIN Nicho n ON n.nicho_id = prod.nicho_id INNER JOIN Marca m ON m.marca_id = prod.marca_id  WHERE producto_id = {prodId}";
            return conexion.ObtenerRegistros(query);
        } 

        public DataTable AutoCompletarCmbProvMarcaNicho(string palabra, string atributo, string atributoLowercase)
        {
            DataTable sugerencias = new DataTable();
            conexion = new Conexion();
            //CONSULTA LIKE PARA EL AUTOCOMPLETADO: NO FUNCIONA(CRASH)
            //string query = $"SELECT {atributoLowercase}_id, nombre_{atributoLowercase} FROM {atributo} WHERE nombre_{atributoLowercase} LIKE '{palabra}%'";
            string query = $"SELECT {atributoLowercase}_id, nombre_{atributoLowercase} FROM {atributo} WHERE nombre_{atributoLowercase} LIKE '{palabra}%'";
            return conexion.ObtenerRegistros(query);
        }

        public DataTable AutoCompletaCmbLike(string buscar)
        {
            conexion = new Conexion();
            string query = $"SELECT p.producto_Id, p.producto_codigo AS Código, p.nombre_producto AS Descripción, p.stock_minimo AS 'Stock Minimo', p.cantidad_producto AS 'Cant. en Existencia' ,p.precio_compra AS '$ Compra', p.porc_ganancia AS '% de Ganancia', p.precio_final AS '$ Venta', n.nombre_nicho AS Nicho, pr.nombre_proveedor AS Proveedor, m.nombre_marca AS Marca " +
                $"FROM Producto p " +
                $"INNER JOIN Nicho n ON p.nicho_id = n.nicho_id " +
                $"INNER JOIN Proveedor pr ON p.proveedor_id = pr.proveedor_id " +
                $"INNER JOIN Marca m ON p.marca_id = m.marca_id " +
                $"WHERE n.nombre_nicho LIKE '{buscar}' OR pr.nombre_proveedor LIKE '{buscar}' OR m.nombre_marca LIKE '{buscar}' OR p.nombre_producto LIKE '{buscar}' OR p.producto_codigo LIKE '%{buscar}'";
            return conexion.AutoCompletarCmbLike(query);
        }

        public DataTable ConsultaProductoXMarca(int mId)
        {
            conexion = new Conexion();
            string query = $"SELECT p.producto_codigo, p.nombre_producto, p.precio_compra, p.precio_final, p.porc_ganancia, p.producto_id FROM Producto p INNER JOIN Marca m ON p.marca_id = m.marca_id WHERE m.marca_id = {mId}";
            return conexion.ObtenerRegistros(query);
        }
        public DataTable ConsultaProductoXProvLike(int pId, string buscar)
        {
            conexion = new Conexion();
            string query = $"SELECT p.producto_id, p.producto_codigo, p.nombre_producto, CONCAT(producto_codigo, '-', nombre_producto) AS codesc, p.precio_compra, p.cantidad_producto FROM Producto p INNER JOIN Proveedor pr ON p.proveedor_id = pr.proveedor_id WHERE p.proveedor_id = {pId} AND CONCAT(p.producto_codigo, '-', p.nombre_producto) LIKE '%{buscar}%'";
            return conexion.ObtenerRegistros(query);
        }
        public DataTable ConsultaProductoVentasLike(string buscar)
        {
            conexion = new Conexion();
            string query = $"SELECT producto_id, producto_codigo, nombre_producto, CONCAT(producto_codigo, '-', nombre_producto) AS codesc ,precio_compra, cantidad_producto, precio_final FROM Producto WHERE producto_codigo LIKE '{buscar}%' OR nombre_producto LIKE '{buscar}%'";
            return conexion.ObtenerRegistros(query);
        }
        public int ModificarPrecioCompraProdXMarca(float precioCompra, float precioFinal, int mId, int prodId)
        {
            conexion = new Conexion();
            string query = $"update Producto SET precio_compra = {precioCompra.ToString("0.##", CultureInfo.InvariantCulture)}, precio_final = {precioFinal.ToString("0.##", CultureInfo.InvariantCulture)} WHERE marca_id = {mId} AND producto_id = {prodId}";
            return conexion.EjecutarAccion(query);
        }

        public DataTable ObtenerListaDeProductos()
        {
            conexion = new Conexion();
            string query = "SELECT producto_codigo AS Código, nombre_producto AS Descripción, precio_final AS 'Precio de Venta' FROM Producto ORDER BY producto_codigo";
            return conexion.ObtenerRegistros(query);
        }

        public void CambiarPrecioCompra(float precioNuevo, int pId)
        {
            conexion = new Conexion();
            string query = $"UPDATE Producto SET precio_compra = {precioNuevo.ToString("0.##", CultureInfo.InvariantCulture)} WHERE producto_Id = {pId}";
            conexion.EjecutarAccion(query);
        }
        public object GenerarNroVenta()
        {
            conexion = new Conexion();
            string query = "SELECT MAX(venta_nro) FROM Venta";
            return conexion.ObtenerRegistroUnico(query);
        }
    }
}
