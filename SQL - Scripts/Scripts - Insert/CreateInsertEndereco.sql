--SCRIPT DE INSERÇÃO DE ENDEREÇO
--FOI REALIZADO A CRIAÇÃO DE CSV E DEPOIS A IMPORTAÇÃO PARA O BANCO
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
