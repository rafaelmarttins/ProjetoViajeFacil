--SCRIPT DE INSER��O DE PONTO PARADA
--FOI REALIZADO A CRIA��O DE CSV E DEPOIS A IMPORTA��O PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[ponto_parada](descricao, latitude, longitude, id_rota) 
SELECT [DESCRICAO]
      ,[LATITUDE]
      ,[LONGITUDE]
      ,[ID_ROTA]
  FROM [ViajeFacilDB].[dbo].[insert_ponto_parada]
GO
