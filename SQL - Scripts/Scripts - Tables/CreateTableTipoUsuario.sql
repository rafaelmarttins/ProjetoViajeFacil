USE ViajeFacilDB
GO
CREATE TABLE tipousuario(
	id_tipousuario BIGINT NOT NULL IDENTITY(1,1),
	descricao VARCHAR(50) NOT NULL,
	CONSTRAINT PK_TipoUsuario PRIMARY KEY (id_tipousuario),
)
GO
