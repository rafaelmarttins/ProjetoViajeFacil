--SCRIPT DE INSER��O DE PARTICIPANTE EVENTO
--FOI REALIZADO A CRIA��O DE CSV E DEPOIS A IMPORTA��O PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[participante_evento](pagamento, sugestao, id_evento, id_usuario) 
SELECT [PAGAMENTO]
      ,[SUGESTAO]
      ,[ID_EVENTO]
      ,[ID_USUARIO]
  FROM [ViajeFacilDB].[dbo].[Insert_participante_evento]
GO

