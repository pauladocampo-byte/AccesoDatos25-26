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
    
    PRINT 'Tabla Asignaturas creada correctamente';
END
ELSE
BEGIN
    PRINT ' La tabla Asignaturas ya existe';
END
GO

-- ============================================================================
-- 2. CREAR TABLA MATRICULAS (Relación Alumno-Asignatura)
-- ============================================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Matriculas')
BEGIN
    CREATE TABLE Matriculas (
        ID_Matricula INT IDENTITY(1,1) PRIMARY KEY,
        ID_Alumno INT NOT NULL,                      
        ID_Asignatura INT NOT NULL,
        FechaMatricula DATETIME2 DEFAULT GETDATE(),
        Nota DECIMAL(4,2) NULL CHECK (Nota >= 0 AND Nota <= 10),
        Estado NVARCHAR(20) DEFAULT 'Matriculado' CHECK (Estado IN ('Matriculado', 'Aprobado', 'Suspendido', 'No Presentado')),
        
        -- CLAVES FORÁNEAS con integridad referencial
        CONSTRAINT FK_Matriculas_Alumno 
            FOREIGN KEY (ID_Alumno) REFERENCES Alumnos(Id)   
            ON DELETE CASCADE ON UPDATE CASCADE,
            
        CONSTRAINT FK_Matriculas_Asignatura 
            FOREIGN KEY (ID_Asignatura) REFERENCES Asignaturas(ID_Asignatura) 
            ON DELETE CASCADE ON UPDATE CASCADE,
            
        -- No se puede matricular dos veces en la misma asignatura
        CONSTRAINT UK_Matricula_Alumno_Asignatura UNIQUE (ID_Alumno, ID_Asignatura) 
    );
    
    PRINT ' Tabla Matriculas creada correctamente con integridad referencial';
END
ELSE
BEGIN
    PRINT ' La tabla Matriculas ya existe';
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
    
    PRINT 'Datos de ejemplo insertados en Asignaturas: 8 asignaturas creadas';
END
ELSE
BEGIN
    PRINT 'La tabla Asignaturas ya contiene datos';
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
        
        PRINT 'Datos de ejemplo insertados en Matriculas para el alumno ID: ' + CAST(@ID_Alumno_Ejemplo AS VARCHAR(10));
    END
END
GO