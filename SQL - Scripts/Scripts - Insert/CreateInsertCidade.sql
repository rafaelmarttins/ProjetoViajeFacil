--SCRIPT DE INSER��O DE CIDADE
--FOI REALIZADO A CRIA��O DE CSV E DEPOIS A IMPORTA��O PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[cidade](nome, codigo_ibge7, uf, id_estado) 
SELECT [NomeMunicipio]
      ,[CodigoIBGE7]
      ,[SiglaUF]
      ,[Id_Cidade]
  FROM [ViajeFacilDB].[dbo].[insert_cidade]
GO

