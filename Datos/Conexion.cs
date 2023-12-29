using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Diagnostics;
using System.Collections;

namespace Datos
{
    public class Conexion
    {
        //Primero se declara el objeto
        public SqlConnection Conector;
        //Luego se instancia en el constructor
        public Conexion()
        {
            string server = ".\\" + System.Environment.UserName;
            //Servidor SQL Server - Base de Datos
            string strConexion = @"data source=RAMIRO\RAMIRO;initial catalog=ferrta_elcruce_db;integrated security=true";
            //string strConexion = @"Data Source=DESKTOP-VPS7PHR\SQLEXPRESS;initial catalog=ferrta_elcruce_db;integrated security=true";
            this.Conector = new SqlConnection(strConexion);
        }
        //LOGICA AUXILIAR
        public int ComprobarBDExiste()
        {
            try
            {

                string con = this.Conector.ConnectionString;
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM sys.databases WHERE name = 'ferrta_elcruce_db'", connection);
                    int res = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    return res;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }


        }
        public void CreateDataBase()
        {
            string script = @"USE [master]
GO
/****** Object:  Database [ferrta_elcruce_db]    Script Date: 9/9/2023 19:39:03 ******/
CREATE DATABASE [ferrta_elcruce_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ferrta_elcruce_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ferrta_elcruce_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ferrta_elcruce_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ferrta_elcruce_db_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ferrta_elcruce_db] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ferrta_elcruce_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ferrta_elcruce_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ferrta_elcruce_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ferrta_elcruce_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ferrta_elcruce_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ferrta_elcruce_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET RECOVERY FULL 
GO
ALTER DATABASE [ferrta_elcruce_db] SET  MULTI_USER 
GO
ALTER DATABASE [ferrta_elcruce_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ferrta_elcruce_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ferrta_elcruce_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ferrta_elcruce_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ferrta_elcruce_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ferrta_elcruce_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ferrta_elcruce_db', N'ON'
GO
ALTER DATABASE [ferrta_elcruce_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [ferrta_elcruce_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ferrta_elcruce_db]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 9/9/2023 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[compra_id] [int] IDENTITY(1,1) NOT NULL,
	[fecha_compra] [date] NOT NULL,
	[producto_id] [int] NULL,
	[cantidad_prod_comprada] [float] NULL,
	[total_comprado] [float] NOT NULL,
	[facturar_compra] [bit] NULL,
	[usr_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[compra_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 9/9/2023 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[marca_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_marca] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[marca_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nicho]    Script Date: 9/9/2023 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nicho](
	[nicho_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_nicho] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nicho_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 9/9/2023 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[producto_id] [int] IDENTITY(1,1) NOT NULL,
	[producto_codigo] [char](5) NOT NULL,
	[nombre_producto] [varchar](100) NOT NULL,
	[precio_compra] [float] NOT NULL,
	[porc_ganancia] [int] NOT NULL,
	[precio_final] [float] NOT NULL,
	[stock_minimo] [int] NOT NULL,
	[cantidad_producto] [int] NULL,
	[proveedor_id] [int] NULL,
	[nicho_id] [int] NULL,
	[marca_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[producto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 9/9/2023 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[proveedor_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_proveedor] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[proveedor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 9/9/2023 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[usr_id] [int] IDENTITY(1,1) NOT NULL,
	[rol] [varchar](10) NULL,
	[nombre_usuario] [varchar](15) NULL,
	[contrasenia] [varchar](max) NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[usr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 9/9/2023 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[venta_id] [int] IDENTITY(1,1) NOT NULL,
	[fecha_venta] [date] NOT NULL,
	[producto_id] [int] NULL,
	[cantidad_prod_vendida] [float] NULL,
	[total_vendido] [float] NOT NULL,
	[facturar_venta] [bit] NULL,
	[venta_nro] [int] NULL,
	[usr_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[venta_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [cantidad_producto]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD FOREIGN KEY([producto_id])
REFERENCES [dbo].[Producto] ([producto_id])
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD FOREIGN KEY([usr_id])
REFERENCES [dbo].[usuario] ([usr_id])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([marca_id])
REFERENCES [dbo].[Marca] ([marca_id])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([nicho_id])
REFERENCES [dbo].[Nicho] ([nicho_id])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([proveedor_id])
REFERENCES [dbo].[Proveedor] ([proveedor_id])
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD FOREIGN KEY([producto_id])
REFERENCES [dbo].[Producto] ([producto_id])
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD FOREIGN KEY([usr_id])
REFERENCES [dbo].[usuario] ([usr_id])
GO
USE [master]
GO
ALTER DATABASE [ferrta_elcruce_db] SET  READ_WRITE 
GO
INSERT INTO usuario VALUES ('Admin', 'admin', 'admin', 1) 
";
            string con = this.Conector.ConnectionString;

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    string[] commands = script.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                    connection.Open();
                    foreach (string commandText in commands)
                    {
                        using (SqlCommand command = new SqlCommand(commandText, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    Console.WriteLine("Base de datos creada exitosamente.");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al crear la base de datos: " + ex.Message);
                }
            }
        }
        public bool BackUpBd()
        {
            //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string desktopPath = "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.RAMIRO\\MSSQL\\Backup";
            string backupQuery = $"BACKUP DATABASE ferrta_elcruce_db TO DISK = '{desktopPath}'";
            try
            {
                var Comando = new SqlCommand(backupQuery, this.Conector);
                this.Conector.Open();
                Comando.ExecuteNonQuery();
                this.Conector.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public void CorregirCodigoProdcutos()
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            dt = ObtenerRegistros("SELECT producto_id, producto_codigo FROM Producto WHERE producto_codigo LIKE 'B%'");
            dt2 = ObtenerRegistros("SELECT producto_id, producto_codigo FROM Producto WHERE producto_codigo LIKE 'C%'");
            dt3 = ObtenerRegistros("SELECT producto_id, producto_codigo FROM Producto WHERE producto_codigo LIKE 'G%'");

            for (int i = 0; i <= dt3.Rows.Count - 1; i++)
            {

                //string query = $"UPDATE Producto SET producto_codigo = 'B{i + 1}' FROM Producto WHERE producto_id = {dt.Rows[i][0]}";
                // EjecutarAccion(query);
                //string query2 = $"UPDATE Producto SET producto_codigo = 'C{i + 1}' FROM Producto WHERE producto_id = {dt2.Rows[i][0]}";
                //EjecutarAccion(query2);
                string query3 = $"UPDATE Producto SET producto_codigo = 'G{i + 1}' FROM Producto WHERE producto_id = {dt3.Rows[i][0]}";
                EjecutarAccion(query3);

            }

        }

        //LOGICA AUXILIAR

        public DataTable ObtenerRegistros(string query)
        {
            var Comando = new SqlCommand(query, this.Conector);

            DataTable result = new DataTable();

            this.Conector.Open();

            result.Load(Comando.ExecuteReader());

            this.Conector.Close();

            return result;
        }

        public object ObtenerRegistroUnico(string query)
        {
            var Comando = new SqlCommand(query, this.Conector);
            this.Conector.Open();
            object result = Comando.ExecuteScalar();
            this.Conector.Close();
            return result;
        }
        public int EjecutarAccion(string query)
        {
            try
            {
                var Comando = new SqlCommand(query, this.Conector);

                this.Conector.Open();

                int result = Comando.ExecuteNonQuery();

                this.Conector.Close();
                return result;

            }
            catch (SqlException e)
            {
                string error = query + e.Message;
            }
            return 0;

        }
        //METODO PARA AUTOCOMPLETAR CON CONSULTA LIKE: NO FUNCIONA(CRASH)
        public DataTable AutoCompletarCmbLike(string query)
        {
            DataTable sugerencias = new DataTable();
            using (var Comando = new SqlCommand(query, this.Conector))
            {
                this.Conector.Open();
                using (SqlDataReader reader = Comando.ExecuteReader())
                {
                    sugerencias.Load(reader);
                }
                this.Conector.Close();
            }
            return sugerencias;
        }


    }
}
