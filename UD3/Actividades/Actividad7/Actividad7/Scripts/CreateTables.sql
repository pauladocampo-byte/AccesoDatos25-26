-- ============================================================================
-- ACTIVIDAD 7: SCRIPT DE CREACIÓN DE TABLAS RELACIONADAS
-- ============================================================================
-- Este script crea las tablas necesarias para demostrar la integridad referencial
-- Incluye: Asignaturas, Matriculas (relación entre Alumnos y Asignaturas)
-- ============================================================================

USE CentroEducativo;
GO

-- ============================================================================
-- 1. CREAR TABLA ASIGNATURAS
-- ============================================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Asignaturas')
BEGIN
    CREATE TABLE Asignaturas (
        ID_Asignatura INT IDENTITY(1,1) PRIMARY KEY,
        Codigo NVARCHAR(10) NOT NULL UNIQUE,
        Nombre NVARCHAR(100) NOT NULL,
        Creditos INT NOT NULL DEFAULT 6,
        Curso INT NOT NULL CHECK (Curso >= 1 AND Curso <= 4),
        FechaCreacion DATETIME2 DEFAULT GETDATE(),
        Activa BIT DEFAULT 1
    );
    
    PRINT '? Tabla Asignaturas creada correctamente';
END
ELSE
BEGIN
    PRINT '?? La tabla Asignaturas ya existe';
END
GO

-- ============================================================================
-- 2. CREAR TABLA MATRICULAS (Relación Alumno-Asignatura)
-- ============================================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Matriculas')
BEGIN
    CREATE TABLE Matriculas (
        ID_Matricula INT IDENTITY(1,1) PRIMARY KEY,
        ID_Alumno INT NOT NULL,                      -- ? CORREGIDO: Usar ID en lugar de DNI
        ID_Asignatura INT NOT NULL,
        FechaMatricula DATETIME2 DEFAULT GETDATE(),
        Nota DECIMAL(4,2) NULL CHECK (Nota >= 0 AND Nota <= 10),
        Estado NVARCHAR(20) DEFAULT 'Matriculado' CHECK (Estado IN ('Matriculado', 'Aprobado', 'Suspendido', 'No Presentado')),
        
        -- CLAVES FORÁNEAS con integridad referencial
        CONSTRAINT FK_Matriculas_Alumno 
            FOREIGN KEY (ID_Alumno) REFERENCES Alumnos(Id)     -- ? CORREGIDO: Id en lugar de DNI
            ON DELETE CASCADE ON UPDATE CASCADE,
            
        CONSTRAINT FK_Matriculas_Asignatura 
            FOREIGN KEY (ID_Asignatura) REFERENCES Asignaturas(ID_Asignatura) 
            ON DELETE CASCADE ON UPDATE CASCADE,
            
        -- No se puede matricular dos veces en la misma asignatura
        CONSTRAINT UK_Matricula_Alumno_Asignatura UNIQUE (ID_Alumno, ID_Asignatura)  -- ? CORREGIDO
    );
    
    PRINT '? Tabla Matriculas creada correctamente con integridad referencial';
END
ELSE
BEGIN
    PRINT '?? La tabla Matriculas ya existe';
END
GO

-- ============================================================================
-- 3. INSERTAR DATOS DE EJEMPLO - ASIGNATURAS
-- ============================================================================
IF NOT EXISTS (SELECT * FROM Asignaturas)
BEGIN
    INSERT INTO Asignaturas (Codigo, Nombre, Creditos, Curso) VALUES
    ('PROG001', 'Fundamentos de Programación', 6, 1),
    ('BD001', 'Bases de Datos', 6, 2),
    ('WEB001', 'Desarrollo Web', 4, 2),
    ('MOVIL001', 'Aplicaciones Móviles', 6, 3),
    ('IA001', 'Inteligencia Artificial', 4, 4),
    ('CYBER001', 'Ciberseguridad', 4, 3),
    ('CLOUD001', 'Computación en la Nube', 4, 4),
    ('DATA001', 'Ciencia de Datos', 6, 4);
    
    PRINT '? Datos de ejemplo insertados en Asignaturas: 8 asignaturas creadas';
END
ELSE
BEGIN
    PRINT '?? La tabla Asignaturas ya contiene datos';
END
GO

-- ============================================================================
-- 4. INSERTAR DATOS DE EJEMPLO - MATRICULAS
-- ============================================================================
-- Solo si existen alumnos en la tabla Alumnos
IF EXISTS (SELECT * FROM Alumnos) AND NOT EXISTS (SELECT * FROM Matriculas)
BEGIN
    -- Matricular algunos alumnos en diferentes asignaturas
    DECLARE @ID_Alumno_Ejemplo INT;
    
    -- Obtener el primer alumno disponible (por ID, no por DNI)
    SELECT TOP 1 @ID_Alumno_Ejemplo = Id FROM Alumnos;
    
    IF @ID_Alumno_Ejemplo IS NOT NULL
    BEGIN
        INSERT INTO Matriculas (ID_Alumno, ID_Asignatura, Nota, Estado) 
        SELECT @ID_Alumno_Ejemplo, ID_Asignatura, 
               CASE 
                   WHEN ID_Asignatura <= 2 THEN 8.5  -- Aprobado
                   WHEN ID_Asignatura <= 4 THEN 6.0  -- Aprobado
                   ELSE NULL                          -- Sin calificar
               END,
               CASE 
                   WHEN ID_Asignatura <= 4 THEN 'Aprobado'
                   ELSE 'Matriculado'
               END
        FROM Asignaturas 
        WHERE ID_Asignatura <= 6; -- Matricular en las primeras 6 asignaturas
        
        PRINT '? Datos de ejemplo insertados en Matriculas para el alumno ID: ' + CAST(@ID_Alumno_Ejemplo AS VARCHAR(10));
    END
END
GO

-- ============================================================================
-- 5. CREAR VISTAS ÚTILES PARA LA APLICACIÓN
-- ============================================================================

-- Vista: Resumen de matriculas con información completa
IF EXISTS (SELECT * FROM sys.views WHERE name = 'VW_MatriculasCompletas')
    DROP VIEW VW_MatriculasCompletas;
GO

CREATE VIEW VW_MatriculasCompletas AS
SELECT 
    m.ID_Matricula,
    a.Id AS ID_Alumno,                              -- ? CORREGIDO: Incluir ID del alumno
    a.DNI,
    a.Nombre + ' ' + a.Apellidos AS NombreCompleto,
    asig.Codigo AS CodigoAsignatura,
    asig.Nombre AS NombreAsignatura,
    asig.Creditos,
    asig.Curso,
    m.FechaMatricula,
    m.Nota,
    m.Estado
FROM Matriculas m
    INNER JOIN Alumnos a ON m.ID_Alumno = a.Id      -- ? CORREGIDO: Join por ID
    INNER JOIN Asignaturas asig ON m.ID_Asignatura = asig.ID_Asignatura
WHERE asig.Activa = 1;
GO

PRINT '? Vista VW_MatriculasCompletas creada correctamente';

-- ============================================================================
-- 6. CREAR PROCEDIMIENTOS ALMACENADOS ÚTILES
-- ============================================================================

-- Procedimiento: Matricular un alumno en una asignatura
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'SP_MatricularAlumno')
    DROP PROCEDURE SP_MatricularAlumno;
GO

CREATE PROCEDURE SP_MatricularAlumno
    @ID_Alumno INT,                                 -- ? CORREGIDO: Usar ID en lugar de DNI
    @ID_Asignatura INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Verificar que el alumno existe
        IF NOT EXISTS (SELECT 1 FROM Alumnos WHERE Id = @ID_Alumno)    -- ? CORREGIDO
        BEGIN
            THROW 50001, 'El alumno con ese ID no existe', 1;
        END
        
        -- Verificar que la asignatura existe y está activa
        IF NOT EXISTS (SELECT 1 FROM Asignaturas WHERE ID_Asignatura = @ID_Asignatura AND Activa = 1)
        BEGIN
            THROW 50002, 'La asignatura no existe o no está activa', 1;
        END
        
        -- Verificar que no esté ya matriculado
        IF EXISTS (SELECT 1 FROM Matriculas WHERE ID_Alumno = @ID_Alumno AND ID_Asignatura = @ID_Asignatura)  -- ? CORREGIDO
        BEGIN
            THROW 50003, 'El alumno ya está matriculado en esta asignatura', 1;
        END
        
        -- Realizar la matrícula
        INSERT INTO Matriculas (ID_Alumno, ID_Asignatura)              -- ? CORREGIDO
        VALUES (@ID_Alumno, @ID_Asignatura);
        
        COMMIT TRANSACTION;
        
        SELECT 'Matrícula realizada correctamente' AS Mensaje;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

PRINT '? Procedimiento SP_MatricularAlumno creado correctamente';

-- ============================================================================
-- 7. MOSTRAR INFORMACIÓN DE LAS TABLAS CREADAS
-- ============================================================================
PRINT '';
PRINT '============================================================================';
PRINT 'RESUMEN DE TABLAS CREADAS PARA ACTIVIDAD 7';
PRINT '============================================================================';

SELECT 
    'Asignaturas' AS Tabla,
    COUNT(*) AS TotalRegistros
FROM Asignaturas
UNION ALL
SELECT 
    'Matriculas' AS Tabla,
    COUNT(*) AS TotalRegistros
FROM Matriculas
UNION ALL
SELECT 
    'Alumnos' AS Tabla,
    COUNT(*) AS TotalRegistros
FROM Alumnos;

PRINT '';
PRINT '? ¡Script ejecutado correctamente!';
PRINT '? Tablas relacionadas creadas con integridad referencial';
PRINT '? Datos de ejemplo insertados';
PRINT '? Vistas y procedimientos creados';
PRINT '';
PRINT '?? PRÓXIMOS PASOS:';
PRINT '   1. Ejecutar la aplicación Actividad7';
PRINT '   2. Probar las operaciones CRUD con integridad referencial';
PRINT '   3. Intentar eliminar un alumno que tenga matrículas (verá el error)';
PRINT '   4. Matricular alumnos en asignaturas y ver las relaciones';
PRINT '';

-- ============================================================================
-- 8. MOSTRAR ESTRUCTURA DE LA TABLA ALUMNOS PARA VERIFICACIÓN
-- ============================================================================
PRINT '============================================================================';
PRINT 'ESTRUCTURA DE LA TABLA ALUMNOS (Para verificación):';
PRINT '============================================================================';

SELECT 
    COLUMN_NAME,
    DATA_TYPE,
    IS_NULLABLE,
    COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Alumnos'
ORDER BY ORDINAL_POSITION;

PRINT '';
PRINT '?? CLAVES DE LA TABLA ALUMNOS:',
'   • Clave Primaria: Id (INT IDENTITY)',
'   • Clave Única: DNI (VARCHAR(9))',
'   • La relación con Matriculas se hace por Id, no por DNI';