using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class Producto
    {
        //Atributos de Proveedor, Marca, Nicho
        public string tipoAtributo { get; set; }
        public string nombre { get; set; }
        public string palabraBuscar { get; set; }
        //Atributos de Producto
        public string descripcion { get; set; }
        public float precioCompra { get; set; }
        public float porcGanancia { get; set; }
        public float precioFinal { get; set; }
        public int stockMin { get; set; }
        public int cantStock { get; set; }
        public int proveedorId { get; set; }
        public int nichoId { get; set; }
        public int marcaId { get; set; }
        public int productoId { get; set; }
        public string productoCodigo { get; set; }
        public string newProdCod { get; set; }
        public string pasillo { get; set; }

        public int resultado { get; set; }
        ProductoDatos pDatos;
        public int AltaAtributo()
        {
            pDatos = new ProductoDatos();
            tipoAtributo = tipoAtributo.Split(' ')[1];
            return pDatos.AltaProveedorMarcaNicho(nombre, tipoAtributo);          
        }
        public int AltaProducto()
        {
            pDatos = new ProductoDatos();
            productoCodigo = AsignarCodXPasillo();
            return pDatos.AltaProducto(descripcion, precioCompra, porcGanancia, precioFinal, stockMin, cantStock ,proveedorId, nichoId, marcaId, productoId, productoCodigo);
        }
        public string AsignarCodXPasillo()
        {
            pDatos = new ProductoDatos();
            int aumentId = 0;
            string producto_id = pDatos.ObtenerUltimoCodXPasillo(pasillo);
            if (producto_id != "")
            {
                aumentId = Convert.ToInt32(producto_id.Substring(1));
                aumentId++;
                producto_id = producto_id.Replace(producto_id.Substring(1), aumentId.ToString());
            }
            else
                producto_id = pasillo + "1";
            return producto_id;
        }
        public int ModificarPorducto()
        {
            pDatos = new ProductoDatos();
            string compararPasillo = pDatos.ObtenerUltimoCodXPasillo(pasillo);
            if (compararPasillo == "")
                compararPasillo = pasillo;
            if (productoCodigo.Substring(0, 1) != compararPasillo.Substring(0,1))
            {
                newProdCod = AsignarCodXPasillo();
            }
            else
                newProdCod = productoCodigo;
            return pDatos.ModificarProducto(descripcion, precioCompra, porcGanancia, precioFinal, stockMin, cantStock ,proveedorId, nichoId, marcaId, productoId, newProdCod);
        }
        public DataTable ConsultaAtributos()
        {
            pDatos = new ProductoDatos();
            tipoAtributo = tipoAtributo.Split('b')[1];
            string tipoAtributoLowercase = tipoAtributo.ToLower();
            return pDatos.ConsultaAtributos(tipoAtributo, tipoAtributoLowercase);
        }

        public DataTable ConsultaProducto()
        {
            pDatos = new ProductoDatos();
            return pDatos.ConsultaProducto(palabraBuscar);
        }

        public DataTable ConsultaProductosDatos()
        {
            pDatos = new ProductoDatos();
            return pDatos.ConsultaProductosDatos();
        }
        public DataTable ConsultarProductoSeleccionado()
        {
            pDatos = new ProductoDatos();
            return pDatos.ConsultarProductoSeleccionado(productoId);
        }

        public DataTable AutoCompletarCmbProvMarcaNicho()
        {
            pDatos = new ProductoDatos();
            tipoAtributo = tipoAtributo.Split('b')[1];
            string tipoAtributoLowercase = tipoAtributo.ToLower();
            return pDatos.AutoCompletarCmbProvMarcaNicho(palabraBuscar, tipoAtributo, tipoAtributoLowercase);
        }

        public DataTable AutoCompletarCmbLike()
        {
            pDatos = new ProductoDatos();
            palabraBuscar = palabraBuscar + '%';
            return pDatos.AutoCompletaCmbLike(palabraBuscar);
        }

        public DataTable ConsultarProductoXMarca()
        {
            pDatos = new ProductoDatos();
            return pDatos.ConsultaProductoXMarca(marcaId);
        }

        public int ModificarPrecioCompraProdXMarca()
        {
            pDatos = new ProductoDatos();
            return pDatos.ModificarPrecioCompraProdXMarca(precioCompra, precioFinal, marcaId, productoId);
        }
        public DataTable ConsultarProductoXProv()
        {
            pDatos = new ProductoDatos();
            return pDatos.ConsultaProductoXProvLike(proveedorId, palabraBuscar);
        }

        public DataTable ConsultasProductoVentasLike()
        {
            pDatos = new ProductoDatos();
            return pDatos.ConsultaProductoVentasLike(palabraBuscar);
        }

        public DataTable ObtenerListaDeProductos()
        {
            pDatos = new ProductoDatos();
            DataTable dtLista = pDatos.ObtenerListaDeProductos();
            //foreach (DataRow dr in dtLista.Rows)
            //{
            //    float valor = Convert.ToSingle(dr[2]);
            //    dr[2] = valor.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
            //}
            return dtLista;

        }
        public void CambiarPrecioCompra()
        {
            pDatos = new ProductoDatos();
            pDatos.CambiarPrecioCompra(precioCompra, productoId);
        }

        public int GenerarNroVenta()
        {
            pDatos = new ProductoDatos();
            object res = pDatos.GenerarNroVenta();
            if (int.TryParse(res.ToString(), out int exsist))
                return Convert.ToInt32(res) + 1;
            else
                return 1;
        }
    }
}
