CREATE DATABASE Financias;

USE Financias;

CREATE TABLE Admins(
	IDAdministrador INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(255) NOT NULL,
	Correo VARCHAR(255) UNIQUE NOT NULL,
	Telefono VARCHAR(15) UNIQUE NOT NULL,
	Direccion VARCHAR(255) NOT NULL,
);

CREATE TABLE Clientes(
    IDCliente INT IDENTITY(1,1) PRIMARY KEY, 
    Nombre VARCHAR(255) NOT NULL,
    Correo VARCHAR(255) UNIQUE NOT NULL,
    Telefono VARCHAR(15) UNIQUE NOT NULL,
    Direccion VARCHAR(255) NOT NULL,
    Sueldo DECIMAL(10,2) NOT NULL,
    Garantia VARCHAR(255) NOT NULL,
    Moras INT DEFAULT 0
);

CREATE TABLE Prestamos(
    IDPrestamo INT IDENTITY(1,1) PRIMARY KEY,  
    IDCliente INT NOT NULL,
    Monto DECIMAL(10,2) NOT NULL,
    Meses INT DEFAULT 0,
    Interes DECIMAL(10,2) DEFAULT 0,
    FechaPrestamo DATE NOT NULL,
    Garantia BIT NOT NULL, 
	Estado VARCHAR(20) NOT NULL,
    CONSTRAINT FK_Prestamos_Clientes FOREIGN KEY (IDCliente) REFERENCES Clientes(IDCliente)
);

CREATE TABLE Amortizaciones(
    IDAmortizacion INT IDENTITY(1,1) PRIMARY KEY, 
    IDPrestamo INT NOT NULL,
	Mes INT NOT NULL,
    MontoAnterior DECIMAL(10,2) NOT NULL,
    MontoAbonado DECIMAL(10,2) NOT NULL,
    NuevoMonto DECIMAL(10,2) NOT NULL,
	InteresMora DECIMAL(10,2) NOT NULL,
    Mora INT NOT NULL,
    CONSTRAINT FK_Amortizaciones_Prestamos FOREIGN KEY (IDPrestamo) REFERENCES Prestamos(IDPrestamo)
);

INSERT INTO Admins (Nombre, Correo, Telefono, Direccion) VALUES (
'Pedro Perez', 'pedro.perez@email.com', '555-8657', 'Calle Falsa 567')

INSERT INTO Clientes (Nombre, Correo, Telefono, Direccion, Sueldo, Garantia, Moras)
VALUES 
('Juan Perez', 'juan.perez@email.com', '555-1234', 'Calle Falsa 123', 5000.00, 'Casa', 1),
('Maria Lopez', 'maria.lopez@email.com', '555-5678', 'Avenida Siempre Viva 456', 4000.00, 'Auto', 0),
('Carlos Ruiz', 'carlos.ruiz@email.com', '555-9876', 'Calle Real 789', 6000.00, 'Casa', 3);


INSERT INTO Prestamos (IDCliente, Monto, Meses, Interes, FechaPrestamo, Garantia, Estado)
VALUES 
(4, 15000.00, 12, 0.10, '2025-01-10', 1, 'En Proceso'),  
(5, 12000.00, 6, 0.08, '2025-01-12', 1, 'En Proceso'),   
(6, 18000.00, 24, 0.05, '2025-01-14', 1, 'En Proceso');  


INSERT INTO Amortizaciones (IDPrestamo, Mes, MontoAnterior, MontoAbonado, NuevoMonto, Mora, InteresMora)
VALUES 
(1, 1, 15000.00, 1500.00, 13500.00, 0, 0),  
(1, 2, 13500.00, 1500.00, 12000.00, 1, 1650),  
(2, 1, 12000.00, 1200.00, 10800.00, 3, 1597.2),  
(3, 1, 18000.00, 1800.00, 16200.00, 0, 0);  

SELECT Clientes.Moras
FROM Clientes
JOIN Prestamos ON Clientes.IDCliente = Prestamos.IDCliente
WHERE Clientes.IDCliente = 4;

SELECT * FROM Prestamos;
SELECT * FROM Amortizaciones WHERE IDPrestamo=4;
SELECT * FROM Admins;
SELECT * FROM Clientes;
