CREATE DATABASE Tienda;

USE Tienda;

CREATE TABLE Categoria (
    Codigo INT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);

CREATE TABLE Producto (
    Codigo INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Cantidad INT NOT NULL,
    CodigoCategoria INT NOT NULL,
    FOREIGN KEY (CodigoCategoria) REFERENCES Categoria(Codigo)
);

INSERT INTO Categoria (Codigo, Nombre) VALUES
(1, 'Bebidas'),
(2, 'Snacks');

INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, CodigoCategoria) VALUES
(101, 'Jugo de naranja', 1.50, 40, 1),
(102, 'Coca Cola', 1.60, 60, 1),
(103, 'Papas', 0.90, 80, 2);

DELETE FROM Producto WHERE Codigo = 102;

DROP DATABASE Tienda;