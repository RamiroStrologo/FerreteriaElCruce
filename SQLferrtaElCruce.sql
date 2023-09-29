create database ferrta_elcruce_db


create table Proveedor(
proveedor_id int identity primary key,
nombre_proveedor varchar(100) not null
)

create table Nicho(
nicho_id int identity primary key,
nombre_nicho varchar(100) not null
)

create table Marca(
marca_id int identity primary key,
nombre_marca varchar(100) not null
)

create table Producto(
producto_id int identity primary key,
producto_codigo char(5) not null,
nombre_producto varchar(100) not null,
precio_compra float not null,
porc_ganancia int not null,
precio_final float not null,
stock_minimo int not null,
cantidad_producto int default 0,
proveedor_id int foreign key references Proveedor(proveedor_id),
nicho_id int foreign key references Nicho(nicho_id),
marca_id int foreign key references Marca(marca_id)
)
ALTER TABLE Producto ADD cantidad_producto int default 0
ALTER TABLE Producto ALTER COLUMN cantidad_producto float 
EXEC sp_rename 'Producto.descripcion', 'nombre_producto', 'COLUMN'

create table Compra(
compra_id int identity primary key,
fecha_compra date not null,
producto_id int foreign key references Producto(producto_id),
cantidad_prod_comprada int not null,
total_comprado float not null,
facturar_compra bit
)
ALTER TABLE Compra ADD usr_id int FOREIGN KEY (usr_id) REFERENCES usuario
alter table Compra add facturar_compra bit
ALTER TABLE Compra ALTER COLUMN cantidad_prod_comprada float

create table Venta(
venta_id int identity primary key,
fecha_venta date not null,
producto_id int foreign key references Producto(producto_id),
cantidad_prod_vendida int not null,
total_vendido float not null,
facturar_venta bit
)
ALTER TABLE Venta ADD venta_nro int
ALTER TABLE Venta ADD usr_id int FOREIGN KEY (usr_id) REFERENCES usuario

create table usuario(
usr_id int identity primary key,
rol varchar(10),
nombre_usuario varchar(15),
contrasenia varchar(max),
activo bit
)
alter table usuario ADD activo bit
insert into usuario VALUES ('Admin', 'admin', '1234', 1)
update usuario SET contrasenia = '1234' where activo = 1
select * from usuario
delete from usuario


ALTER TABLE Venta ALTER COLUMN cantidad_prod_vendida float
drop table Producto
insert into Proveedor VALUES ('Proveedor1')
insert into Nicho VALUES ('Nicho1')
insert into Marca VALUES ('Marca1')
update Producto SET precio_compra = 100, precio_final = 150, porc_ganancia = 50 WHERE marca_id = 1
update Producto SET precio_compra = 101, precio_final = 151.5 WHERE marca_id = 1
insert into Producto VALUES ('Producto1', 10.00, 50, 15.00, 100, 1, 1, 1)
DBCC CHECKIDENT('Producto', RESEED, 0)
DBCC CHECKIDENT('Proveedor', RESEED, 0)
DBCC CHECKIDENT('Marca', RESEED, 0)
DBCC CHECKIDENT('Nicho', RESEED, 0)

select * from Producto 
UPDATE Producto SET cantidad_producto = 100 where producto_id = 2
select * from Proveedor
select * from Nicho
select * from Marca
select * from Compra ORDER BY total_comprado
select * from Venta
select * from COmpra
delete from Nicho
delete from Marca
delete from Proveedor
delete from Producto WHERE producto_id  = 'D0001'
delete from Compra
delete from Venta
truncate table Proveedor
SELECT prod.descripcion, prov.nombre_proveedor, m.nombre_marca, n.nombre_nicho FROM Producto prod INNER JOIN Proveedor prov ON prod.proveedor_id = prov.proveedor_id INNER JOIN Marca m ON m.marca_id = prod.marca_id INNER JOIN Nicho n ON n.nicho_id = prod.nicho_id WHERE prod.descripcion LIKE 'P%' OR prov.nombre_proveedor LIKE 'P%' OR m.nombre_marca LIKE 'M%' OR n.nombre_nicho LIKE 'H%'
--Consulta para filtrar por mas de un criterior
SELECT * FROM Producto prod INNER JOIN Proveedor prov ON prod.proveedor_id = prov.proveedor_id INNER JOIN Marca m ON m.marca_id = prod.marca_id INNER JOIN Nicho n ON n.nicho_id = prod.nicho_id WHERE prod.descripcion LIKE '%" + Text + "%' OR prov.nombre_proveedor LIKE '%" + Text + "%' OR m.marca_id LIKE '%" + Text + "%' OR n.nicho_id LIKE '%" + Text + "%'
SELECT nombre_proveedor FROM Proveedor WHERE nombre_proveedor LIKE 'Proveedor8%'

SELECT CONCAT(proveedor_id, ',' ,nombre_proveedor) FROM Proveedor WHERE nombre_proveedor LIKE 'P%'

SELECT CONCAT(proveedor_id, ',' ,nombre_proveedor) AS nombreId FROM Proveedor WHERE nombre_proveedor LIKE 'pRoV%'

INSERT INTO Producto VALUES ('Producto5', 21312, 23, '26213.76', 213, 3, 3, 4)

UPDATE Producto SET nombre_producto = 'Prodcuto2', precio_compra = 100, porc_ganancia = 0, precio_final = 100, stock_minimo = 100, proveedor_id = 1, nicho_id = 1, marca_id = 1 WHERE producto_id = 1001

SELECT p.producto_Id, p.nombre_producto, p.stock_minimo, p.cantidad_producto ,p.precio_compra, p.porc_ganancia, p.precio_final, n.nombre_nicho AS Nicho, pr.nombre_proveedor AS Proveedor, m.nombre_marca AS Marca
FROM Producto p
INNER JOIN Nicho n ON p.nicho_id = n.nicho_id
INNER JOIN Proveedor pr ON p.proveedor_id = pr.proveedor_id
INNER JOIN Marca m ON p.marca_id = m.marca_id
WHERE n.nombre_nicho LIKE ''
OR pr.nombre_proveedor LIKE ''
OR m.nombre_marca LIKE 'Marca1%'
OR p.nombre_producto LIKE ''

SELECT p.producto_Id, p.nombre_producto, p.stock_minimo, p.cantidad_producto ,p.precio_compra, p.porc_ganancia, p.precio_final, n.nombre_nicho AS Nicho, pr.nombre_proveedor AS Proveedor, m.nombre_marca AS Marca FROM Producto p INNER JOIN Nicho n ON p.nicho_id = n.nicho_id INNER JOIN Proveedor pr ON p.proveedor_id = pr.proveedor_id INNER JOIN Marca m ON p.marca_id = m.marca_id WHERE n.nombre_nicho LIKE 'M%' OR pr.nombre_proveedor LIKE 'M%' OR m.nombre_marca LIKE 'M%' OR p.nombre_producto LIKE 'M%'

SELECT * FROM Producto prod INNER JOIN Proveedor prov ON prod.proveedor_id = prov.proveedor_id INNER JOIN Nicho n ON n.nicho_id = prod.nicho_id INNER JOIN Marca m ON m.marca_id = prod.marca_id  WHERE producto_id = 2

INSERT INTO Producto VALUES ('Tornillo1', 100, 50, 150, 100, 200 ,1001, 1002, 1001, 0)

SELECT p.nombre_producto, p.precio_compra FROM Producto p INNER JOIN Marca m ON p.marca_id = m.marca_id WHERE m.marca_id = 1006

ALTER PROCEDURE ActualizarPrecioCompra @marcaId int, @preciocompra float, @preciofinal float
AS
BEGIN
UPDATE Producto SET precio_compra = @preciocompra, precio_final = @preciofinal WHERE marca_id = @marcaId
END

SELECT proveedor_id, nombre_proveedor FROM Proveedor

SELECT p.producto_id, p.nombre_producto, p.precio_compra FROM Producto p INNER JOIN Proveedor pr ON p.proveedor_id = pr.proveedor_id WHERE p.proveedor_id = 1001

INSERT INTO Compra VALUES (CONVERT(DATE, GETDATE(), 103), 2, 1, 113,33)

INSERT INTO Producto VALUES ('A0001', 'PRODUCTO 1', 100, 50, 150, 100 ,1, 1, 1, 200)

SELECT producto_codigo FROM Producto WHERE producto_codigo LIKE 'A%2'

SELECT TOP 10 p.nombre_producto, c.total_comprado, c.cantidad_prod_comprada
FROM Compra c INNER JOIN Producto p ON c.producto_id = p.producto_id WHERE c.fecha_compra BETWEEN '2023-05-18' AND '2023-05-18' 
ORDER BY c.total_comprado DESC

select * from Compra ORDER BY producto_id


SELECT p.producto_codigo AS Código, p.nombre_producto, 
       (SELECT SUM(cantidad_prod_comprada) 
        FROM Compra 
        WHERE producto_id = p.producto_id) AS total_cantidad,
       (SELECT SUM(total_comprado) FROM Compra  WHERE producto_id = p.producto_id) AS total_pagado
       FROM Compra c INNER JOIN Producto p ON c.producto_id = p.producto_id
       WHERE c.fecha_compra BETWEEN '2023-05-12' AND '2023-05-16' GROUP BY p.producto_id, p.nombre_producto, p.producto_codigo ORDER BY total_pagado DESC

	   SELECT SUM(total_comprado) FROM Compra WHERE fecha_compra BETWEEN '2023-05-11' AND '2023-05-16' AND  facturar_compra = 0

	    SELECT p.producto_codigo AS Código, p.nombre_producto AS Descripción, (SELECT SUM(cantidad_prod_comprada) FROM Compra  WHERE producto_id = p.producto_id) AS 'Cant. comprada', (SELECT SUM(total_comprado) FROM Compra  WHERE producto_id = p.producto_id) AS 'Total pagado' FROM Compra c INNER JOIN Producto p ON c.producto_id = p.producto_id WHERE c.fecha_compra BETWEEN '2023/05/15' AND '2023/05/17' GROUP BY p.producto_id, p.nombre_producto, p.producto_codigo ORDER BY 'Total pagado' DESC 

		 SELECT TOP 10 p.nombre_producto, (SELECT SUM(cantidad_prod_comprada) FROM Compra  WHERE producto_id = p.producto_id AND fecha_compra BETWEEN '2023/05/18' AND '2023/05/18') AS total_cantidad, (SELECT SUM(total_comprado) FROM Compra  WHERE producto_id = p.producto_id AND fecha_compra BETWEEN '2023/05/18' AND '2023/05/18') AS total_pagado FROM Compra c INNER JOIN Producto p ON c.producto_id = p.producto_id WHERE c.fecha_compra BETWEEN '2023/05/18' AND '2023/05/18' GROUP BY p.producto_id, p.nombre_producto ORDER BY total_pagado DESC 

		 SELECT TOP 10 p.nombre_producto, (SELECT SUM(cantidad_prod_comprada) FROM Compra  WHERE producto_id = p.producto_id AND c.fecha_compra BETWEEN '2023/05/18' AND '2023/05/18') AS total_cantidad, (SELECT SUM(total_comprado) FROM Compra  WHERE producto_id = p.producto_id AND c.fecha_compra BETWEEN '{fechaIni}' AND '{fechaFin}') AS total_pagado FROM Compra c INNER JOIN Producto p ON c.producto_id = p.producto_id WHERE c.fecha_compra BETWEEN '2023/05/18' AND '2023/05/18' GROUP BY p.producto_id, p.nombre_producto ORDER BY total_pagado DESC

		 SELECT producto_id, producto_codigo, nombre_producto, CONCAT(producto_codigo, '-', nombre_producto) AS 'codesc' ,precio_compra, cantidad_producto FROM Producto WHERE CONCAT(producto_codigo, '-', nombre_producto) LIKE 'A%'

		 SELECT proveedor_id, nombre_proveedor FROM Proveedor WHERE nombre_proveedor LIKE 'a%'

		 SELECT COUNT(*) FROM sys.databases WHERE name = 'ferrta_elcruce_db'



		 /* UPDATE BD CLIENTE ////////////////// */
		 create table usuario(
usr_id int identity primary key,
rol varchar(10),
nombre_usuario varchar(15),
contrasenia varchar(max),
activo bit
)

INSERT INTO usuario VALUES ('Admin', 'admin', '$2a$11$ZcnNSZVG.t2JwN/yjaFhGuxXI33QsTfMwBmstazCBd9NdNGZ.2MfK', 1)
ALTER TABLE Venta ADD venta_nro int
ALTER TABLE Venta ADD usr_id int FOREIGN KEY (usr_id) REFERENCES usuario
ALTER TABLE Compra ADD usr_id int FOREIGN KEY (usr_id) REFERENCES usuario

SELECT v.fecha_venta, p.nombre_producto, v.cantidad_prod_vendida, v.total_vendido, v.venta_nro, u.nombre_usuario FROM Venta v INNER JOIN Producto p ON v.producto_id = p.producto_id INNER JOIN usuario u ON u.usr_id = v.usr_id Order BY v.venta_nro DESC 


SELECT * FROM Producto
SELECT * FROM Venta

SELECT p.producto_id, p.producto_codigo, p.nombre_producto, p.precio_compra, v.cantidad_prod_vendida, v.total_vendido, v.facturar_venta, (SELECT SUM(total_vendido) FROM Venta WHERE venta_nro = 9), p.cantidad_producto FROM Producto p INNER JOIN Venta v ON v.producto_id = p.producto_id WHERE v.venta_nro = 9

UPDATE Producto SET cantidad_producto = cantidad_producto + 1