--SCRIPT DE INSER��O DE INSTITUI��O
--FOI REALIZADO A CRIA��O DE CSV E DEPOIS A IMPORTA��O PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[instituicao](nome, telefone, id_endereco) 
SELECT [NOME]
      ,[TELEFONE]
      ,[ID_ENDERECO]
  FROM [ViajeFacilDB].[dbo].[insert_instituicao]
GO

