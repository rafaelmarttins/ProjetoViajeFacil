USE ViajeFacilDB
GO
CREATE TABLE pais(
	id_pais BIGINT NOT NULL IDENTITY(1,1),
	nome varchar(100) NOT NULL,
	CONSTRAINT PK_Pais PRIMARY KEY (id_pais)
)
GO
