--SCRIPT DE INSERÇÃO DE PAIS 
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[pais](nome) 
	SELECT [Descricao] 
	FROM [Academia].[Geral].[Pais]
GO

