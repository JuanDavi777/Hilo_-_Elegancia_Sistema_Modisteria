CREATE TABLE Usuario (
    IdUsuario INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Rol NVARCHAR(50),
    Contrasena NVARCHAR(100)
);

CREATE TABLE Pedido (
    IdPedido INT PRIMARY KEY IDENTITY,
    Cliente NVARCHAR(100),
    Fecha DATETIME,
    Estado NVARCHAR(50)
);

CREATE TABLE OrdenTrabajo (
    IdOrden INT PRIMARY KEY IDENTITY,
    IdPedido INT,
    AsignadoA INT,
    EstadoProduccion NVARCHAR(50),
    FOREIGN KEY (IdPedido) REFERENCES Pedido(IdPedido),
    FOREIGN KEY (AsignadoA) REFERENCES Usuario(IdUsuario)
);

CREATE TABLE EtapaProduccion (
    IdEtapa INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50)
);

CREATE TABLE SeguimientoProduccion (
    Id INT PRIMARY KEY IDENTITY,
    IdPedido INT,
    IdEtapa INT,
    Estado NVARCHAR(50),
    FOREIGN KEY (IdPedido) REFERENCES Pedido(IdPedido),
    FOREIGN KEY (IdEtapa) REFERENCES EtapaProduccion(IdEtapa)
);

CREATE TABLE Proveedor (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Contacto NVARCHAR(100)
);

CREATE TABLE Gasto (
    Id INT PRIMARY KEY IDENTITY,
    Tipo NVARCHAR(50),
    Monto FLOAT,
    Fecha DATETIME
);