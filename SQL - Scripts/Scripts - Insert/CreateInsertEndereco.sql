--SCRIPT DE INSER��O DE ENDERE�O
--FOI REALIZADO A CRIA��O DE CSV E DEPOIS A IMPORTA��O PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[endereco](rua, numero, complemento, bairro, cep, id_cidade) 
SELECT [RUA]
      ,[NUMERO]
      ,[COMPLEMENTO]
      ,[BAIRRO]
      ,[CEP]
      ,[ID_CIDADE]
  FROM [ViajeFacilDB].[dbo].[insert_endereco]
GO
