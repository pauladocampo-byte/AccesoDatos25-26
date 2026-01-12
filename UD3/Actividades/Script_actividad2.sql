-- Crear la base de datos
CREATE DATABASE CentroEducativo;
GO

-- Usar la base de datos
USE CentroEducativo;
GO

-- Crear la tabla Alumnos
CREATE TABLE Alumnos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    DNI VARCHAR(9) NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Apellidos VARCHAR(100) NOT NULL
);