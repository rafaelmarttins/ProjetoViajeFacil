--SCRIPT DE INSER��O DE ROTA
--FOI REALIZADO A CRIA��O DE CSV E DEPOIS A IMPORTA��O PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[rota](ponto_inicial, ponto_final) 
SELECT [ORIGEM]
      ,[DESTINO]
  FROM [ViajeFacilDB].[dbo].[insert_rota]
GO
