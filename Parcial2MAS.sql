CREATE DATABASE Parcial2MAS;
GO
USE [master]
GO
CREATE LOGIN [usrparcial2] WITH PASSWORD = N'12345678',
	DEFAULT_DATABASE = [Parcial2MAS],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [Parcial2MAS]
GO
CREATE USER [usrparcial2] FOR LOGIN [usrparcial2]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrparcial2]
GO

DROP TABLE IF EXISTS Programa;
DROP TABLE IF EXISTS Canal;
DROP PROC IF EXISTS paProgramaListar;

CREATE TABLE Canal(
id INT IDENTITY(1,1) PRIMARY KEY,
nombre VARCHAR(50) NOT NULL,
frecuencia VARCHAR(20) NOT NULL,
estado SMALLINT NOT NULL DEFAULT 1 -- 1: Activo, 0: Inactivo
);

CREATE TABLE Programa(
id INT IDENTITY(1,1) PRIMARY KEY,
idCanal INT NOT NULL,
titulo VARCHAR(100) NOT NULL,
descripcion VARCHAR(250) NOT NULL,
duracion INT NOT NULL,
productor VARCHAR(100) NOT NULL,
fechaEstreno DATE NOT NULL,
estado SMALLINT NOT NULL DEFAULT 1, -- 1: Activo, 0: Inactivo, -1: Eliminado
FOREIGN KEY (idCanal) REFERENCES Canal(id)
);

GO
CREATE PROC paProgramaListar @parametro VARCHAR(100)
AS
  SELECT p.*, c.nombre AS nombreCanal
  FROM Programa p
  INNER JOIN Canal c ON p.idCanal = c.id
  WHERE p.estado <> -1 AND (p.titulo + p.productor + c.nombre LIKE '%' + REPLACE(@parametro,' ','%') + '%')
  ORDER BY p.titulo ASC;

-- Insertar datos de ejemplo
INSERT INTO Canal(nombre, frecuencia, estado) VALUES ('Canal 1', '525 MHz', 1);
INSERT INTO Canal(nombre, frecuencia, estado) VALUES ('Canal 2', '550 MHz', 1);

INSERT INTO Programa(idCanal, titulo, descripcion, duracion, productor, fechaEstreno, estado)
VALUES (1, 'Noticiero Matutino', 'Programa informativo de la mañana con las noticias más importantes del día.', 60, 'Juan Pérez', '2020-01-01', 1);

INSERT INTO Programa(idCanal, titulo, descripcion, duracion, productor, fechaEstreno, estado)
VALUES (2, 'Serie Dramática', 'Una serie llena de emoción y drama familiar.', 45, 'María García', '2021-05-15', 1);

EXEC paProgramaListar '';
