--SCRIPT DE INSER��O DE REGI�O 
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[regiao](nome, id_pais) 
	SELECT [Regiao], 30
    FROM [Academia].[Geral].[Municipio] GROUP BY Regiao
GO
