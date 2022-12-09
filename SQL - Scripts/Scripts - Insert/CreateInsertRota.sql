--SCRIPT DE INSERÇÃO DE ROTA
--FOI REALIZADO A CRIAÇÃO DE CSV E DEPOIS A IMPORTAÇÃO PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[rota](ponto_inicial, ponto_final) 
SELECT [ORIGEM]
      ,[DESTINO]
  FROM [ViajeFacilDB].[dbo].[insert_rota]
GO
