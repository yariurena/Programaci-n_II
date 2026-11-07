CREATE DATABASE Tienda;
USE Tienda;

CREATE TABLE Clientes(
  IdCliente INT AUTO_INCREMENT PRIMARY KEY,
  Nombre VARCHAR(100) NOT NULL,
  Correo VARCHAR(100) NOT NULL
);

INSERT INTO Clientes (Nombre, Correo)
VALUES ('Juan Peréz', 'juan@mail.com');

INSERT INTO Clientes (Nombre, Correo)
VALUES ('Ana López', 'ana@mail.com');

SELECT * FROM Clientes;

DELETE FROM Clientes WHERE Nombre = 'Ana López';

DROP DATABASE Tienda;