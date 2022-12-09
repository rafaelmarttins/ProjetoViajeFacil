--SCRIPT DE INSERÇÃO DE CIDADE
--FOI REALIZADO A CRIAÇÃO DE CSV E DEPOIS A IMPORTAÇÃO PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[cidade](nome, codigo_ibge7, uf, id_estado) 
SELECT [NomeMunicipio]
      ,[CodigoIBGE7]
      ,[SiglaUF]
      ,[Id_Cidade]
  FROM [ViajeFacilDB].[dbo].[insert_cidade]
GO

