--SCRIPT DE INSERÇÃO DE REGIÃO 
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[regiao](nome, id_pais) 
	SELECT [Regiao], 30
    FROM [Academia].[Geral].[Municipio] GROUP BY Regiao
GO
