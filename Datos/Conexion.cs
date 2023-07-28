using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Diagnostics;

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
            string strConexion = @"Data Source=" + server + ";Initial Catalog=ferrta_elcruce_db;Integrated Security=True";
            //string strConexion = @"data source=localhost\sqlexpress;initial catalog=ferrta_elcruce_db;integrated security=true";
            this.Conector = new SqlConnection(strConexion);
        }
        //public void UpdateBD()
        //{
        //    string script = @"
        //            create table usuario(
        //            usr_id int identity primary key,
        //            rol varchar(10),
        //            nombre_usuario varchar(15),
        //            contrasenia varchar(max),
        //            activo bit
        //            )
        //            GO
        //            INSERT INTO usuario VALUES ('Admin', 'admin', '$2a$11$ZcnNSZVG.t2JwN/yjaFhGuxXI33QsTfMwBmstazCBd9NdNGZ.2MfK', 1)
        //            GO
        //            ALTER TABLE Venta ADD venta_nro int
        //            GO
        //            ALTER TABLE Venta ADD usr_id int FOREIGN KEY (usr_id) REFERENCES usuario
        //            GO
        //            ALTER TABLE Compra ADD usr_id int FOREIGN KEY (usr_id) REFERENCES usuario";
        //    string strConexion = @"data source=localhost\sqlexpress;initial catalog=ferrta_elcruce_db;integrated security=true";
        //    using (SqlConnection connection = new SqlConnection(strConexion))
        //    {
        //        try
        //        {
        //            string[] commands = script.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
        //            connection.Open();
        //            foreach (string commandText in commands)
        //            {
        //                using (SqlCommand command = new SqlCommand(commandText, connection))
        //                {
        //                    command.ExecuteNonQuery();
        //                }
        //            }
        //            Console.WriteLine("Base de datos creada exitosamente.");
        //            connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error al crear la base de datos: " + ex.Message);
        //        }
        //    }
        //}
        //public int ComprobarBDExiste()
        //{
        //    string strConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        //    using (SqlConnection connection = new SqlConnection(strConexion))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM sys.databases WHERE name = 'ferrta_elcruce_db'", connection);
        //        int res = Convert.ToInt32(command.ExecuteScalar());
        //        connection.Close();
        //        return res;
        //    }

        //}
        //public void CreateDataBase()
        //{
        //            string script = @"USE [master]
        ////GO
        /////****** Object:  Database [ferrta_elcruce_db]    Script Date: 03/06/2023 19:22:32 ******/
        ////CREATE DATABASE [ferrta_elcruce_db]
        //// CONTAINMENT = NONE
        //// ON  PRIMARY 
        ////( NAME = N'ferrta_elcruce_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ferrta_elcruce_db.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
        //// LOG ON 
        ////( NAME = N'ferrta_elcruce_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ferrta_elcruce_db_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET COMPATIBILITY_LEVEL = 110
        ////GO
        ////IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
        ////begin
        ////EXEC [ferrta_elcruce_db].[dbo].[sp_fulltext_database] @action = 'enable'
        ////end
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET ANSI_NULL_DEFAULT OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET ANSI_NULLS OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET ANSI_PADDING OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET ANSI_WARNINGS OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET ARITHABORT OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET AUTO_CLOSE OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET AUTO_SHRINK OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET AUTO_UPDATE_STATISTICS ON 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET CURSOR_DEFAULT  GLOBAL 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET CONCAT_NULL_YIELDS_NULL OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET NUMERIC_ROUNDABORT OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET QUOTED_IDENTIFIER OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET RECURSIVE_TRIGGERS OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET  ENABLE_BROKER 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET TRUSTWORTHY OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET PARAMETERIZATION SIMPLE 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET READ_COMMITTED_SNAPSHOT OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET HONOR_BROKER_PRIORITY OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET RECOVERY FULL 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET  MULTI_USER 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET PAGE_VERIFY CHECKSUM  
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET DB_CHAINING OFF 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
        ////GO
        ////EXEC sys.sp_db_vardecimal_storage_format N'ferrta_elcruce_db', N'ON'
        ////GO
        ////USE [ferrta_elcruce_db]
        ////GO
        /////****** Object:  Table [dbo].[Compra]    Script Date: 03/06/2023 19:22:32 ******/
        ////SET ANSI_NULLS ON
        ////GO
        ////SET QUOTED_IDENTIFIER ON
        ////GO
        ////CREATE TABLE [dbo].[Compra](
        ////	[compra_id] [int] IDENTITY(1,1) NOT NULL,
        ////	[fecha_compra] [date] NOT NULL,
        ////	[producto_id] [int] NULL,
        ////	[cantidad_prod_comprada] [float] NULL,
        ////	[total_comprado] [float] NOT NULL,
        ////	[facturar_compra] [bit] NULL,
        ////PRIMARY KEY CLUSTERED 
        ////(
        ////	[compra_id] ASC
        ////)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
        ////) ON [PRIMARY]
        ////GO
        /////****** Object:  Table [dbo].[Marca]    Script Date: 03/06/2023 19:22:33 ******/
        ////SET ANSI_NULLS ON
        ////GO
        ////SET QUOTED_IDENTIFIER ON
        ////GO
        ////CREATE TABLE [dbo].[Marca](
        ////	[marca_id] [int] IDENTITY(1,1) NOT NULL,
        ////	[nombre_marca] [varchar](100) NOT NULL,
        ////PRIMARY KEY CLUSTERED 
        ////(
        ////	[marca_id] ASC
        ////)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
        ////) ON [PRIMARY]
        ////GO
        /////****** Object:  Table [dbo].[Nicho]    Script Date: 03/06/2023 19:22:33 ******/
        ////SET ANSI_NULLS ON
        ////GO
        ////SET QUOTED_IDENTIFIER ON
        ////GO
        ////CREATE TABLE [dbo].[Nicho](
        ////	[nicho_id] [int] IDENTITY(1,1) NOT NULL,
        ////	[nombre_nicho] [varchar](100) NOT NULL,
        ////PRIMARY KEY CLUSTERED 
        ////(
        ////	[nicho_id] ASC
        ////)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
        ////) ON [PRIMARY]
        ////GO
        /////****** Object:  Table [dbo].[Producto]    Script Date: 03/06/2023 19:22:33 ******/
        ////SET ANSI_NULLS ON
        ////GO
        ////SET QUOTED_IDENTIFIER ON
        ////GO
        ////CREATE TABLE [dbo].[Producto](
        ////	[producto_id] [int] IDENTITY(1,1) NOT NULL,
        ////	[producto_codigo] [char](5) NOT NULL,
        ////	[nombre_producto] [varchar](100) NOT NULL,
        ////	[precio_compra] [float] NOT NULL,
        ////	[porc_ganancia] [int] NOT NULL,
        ////	[precio_final] [float] NOT NULL,
        ////	[stock_minimo] [int] NOT NULL,
        ////	[cantidad_producto] [int] NULL,
        ////	[proveedor_id] [int] NULL,
        ////	[nicho_id] [int] NULL,
        ////	[marca_id] [int] NULL,
        ////PRIMARY KEY CLUSTERED 
        ////(
        ////	[producto_id] ASC
        ////)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
        ////) ON [PRIMARY]
        ////GO
        /////****** Object:  Table [dbo].[Proveedor]    Script Date: 03/06/2023 19:22:33 ******/
        ////SET ANSI_NULLS ON
        ////GO
        ////SET QUOTED_IDENTIFIER ON
        ////GO
        ////CREATE TABLE [dbo].[Proveedor](
        ////	[proveedor_id] [int] IDENTITY(1,1) NOT NULL,
        ////	[nombre_proveedor] [varchar](100) NOT NULL,
        ////PRIMARY KEY CLUSTERED 
        ////(
        ////	[proveedor_id] ASC
        ////)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
        ////) ON [PRIMARY]
        ////GO
        /////****** Object:  Table [dbo].[Venta]    Script Date: 03/06/2023 19:22:33 ******/
        ////SET ANSI_NULLS ON
        ////GO
        ////SET QUOTED_IDENTIFIER ON
        ////GO
        ////CREATE TABLE [dbo].[Venta](
        ////	[venta_id] [int] IDENTITY(1,1) NOT NULL,
        ////	[fecha_venta] [date] NOT NULL,
        ////	[producto_id] [int] NULL,
        ////	[cantidad_prod_vendida] [float] NULL,
        ////	[total_vendido] [float] NOT NULL,
        ////	[facturar_venta] [bit] NULL,
        ////PRIMARY KEY CLUSTERED 
        ////(
        ////	[venta_id] ASC
        ////)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
        ////) ON [PRIMARY]
        ////GO
        ////SET IDENTITY_INSERT [dbo].[Proveedor] ON 

        ////INSERT [dbo].[Proveedor] ([proveedor_id], [nombre_proveedor]) VALUES (3003, N'Prov1')
        ////SET IDENTITY_INSERT [dbo].[Proveedor] OFF
        ////ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [cantidad_producto]
        ////GO
        ////ALTER TABLE [dbo].[Compra]  WITH CHECK ADD FOREIGN KEY([producto_id])
        ////REFERENCES [dbo].[Producto] ([producto_id])
        ////GO
        ////ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([marca_id])
        ////REFERENCES [dbo].[Marca] ([marca_id])
        ////GO
        ////ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([nicho_id])
        ////REFERENCES [dbo].[Nicho] ([nicho_id])
        ////GO
        ////ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([proveedor_id])
        ////REFERENCES [dbo].[Proveedor] ([proveedor_id])
        ////GO
        ////ALTER TABLE [dbo].[Venta]  WITH CHECK ADD FOREIGN KEY([producto_id])
        ////REFERENCES [dbo].[Producto] ([producto_id])
        ////GO
        /////****** Object:  StoredProcedure [dbo].[ActualizarPrecioCompra]    Script Date: 03/06/2023 19:22:33 ******/
        ////SET ANSI_NULLS ON
        ////GO
        ////SET QUOTED_IDENTIFIER ON
        ////GO
        ////CREATE PROCEDURE [dbo].[ActualizarPrecioCompra] @marcaId int, @preciocompra float, @preciofinal float
        ////AS
        ////BEGIN
        ////UPDATE Producto SET precio_compra = @preciocompra, precio_final = @preciofinal WHERE marca_id = @marcaId
        ////END
        ////GO
        ////USE [master]
        ////GO
        ////ALTER DATABASE [ferrta_elcruce_db] SET  READ_WRITE 
        ////GO


        ////";
        //Servidor SQL Server - Base de Datos
        //    string strConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        //    using (SqlConnection connection = new SqlConnection(strConexion))
        //    {
        //        try
        //        {
        //            string[] commands = script.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
        //            connection.Open();
        //            foreach (string commandText in commands)
        //            {
        //                using (SqlCommand command = new SqlCommand(commandText, connection))
        //                {
        //                    command.ExecuteNonQuery();
        //                }
        //            }
        //            Console.WriteLine("Base de datos creada exitosamente.");
        //            connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error al crear la base de datos: " + ex.Message);
        //        }
        //    }
        //}

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
