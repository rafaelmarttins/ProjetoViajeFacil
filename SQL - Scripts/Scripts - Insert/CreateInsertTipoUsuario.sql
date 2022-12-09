--SCRIPT DE INSERÇÃO DE TIPO USUARIO 
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[tipousuario](descricao) 
	VALUES
	('Cliente'),
	('Organizador'),
	('Moderador '),
	('Administrador')
GO

