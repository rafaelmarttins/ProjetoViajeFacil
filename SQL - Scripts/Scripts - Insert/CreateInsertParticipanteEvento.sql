--SCRIPT DE INSERÇÃO DE PARTICIPANTE EVENTO
--FOI REALIZADO A CRIAÇÃO DE CSV E DEPOIS A IMPORTAÇÃO PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[participante_evento](pagamento, sugestao, id_evento, id_usuario) 
SELECT [PAGAMENTO]
      ,[SUGESTAO]
      ,[ID_EVENTO]
      ,[ID_USUARIO]
  FROM [ViajeFacilDB].[dbo].[Insert_participante_evento]
GO

