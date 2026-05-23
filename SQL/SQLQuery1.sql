Create database PuntoVentaDB;
Go
Use PuntoVentaDB
CREATE TABLE Usuarios
(
    Id INT PRIMARY KEY IDENTITY,
    Usuario VARCHAR(50),
    Password VARCHAR(50)
);

select * from Usuarios;

insert into dbo.Usuarios (Id, Usuario, Password)
values(6, 'usuario', 'admin');

DELETE FROM Usuarios WHERE Id = 4;

CREATE TABLE Productos
(
    Id INT PRIMARY KEY IDENTITY,

    Nombre VARCHAR(100),
    CodigoBarras VARCHAR(50),

    PrecioCompra DECIMAL(10,2),
    PrecioVenta DECIMAL(10,2),

    Stock INT,

    Lote VARCHAR(50),

    FechaVencimiento DATE
);

select * from Productos;
delete from Productos where id = 2;