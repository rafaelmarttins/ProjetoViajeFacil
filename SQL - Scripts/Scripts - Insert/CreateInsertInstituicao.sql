--SCRIPT DE INSER플O DE INSTITUI플O
--FOI REALIZADO A CRIA플O DE CSV E DEPOIS A IMPORTA플O PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[instituicao](nome, telefone, id_endereco) 
SELECT [NOME]
      ,[TELEFONE]
      ,[ID_ENDERECO]
  FROM [ViajeFacilDB].[dbo].[insert_instituicao]
GO

