--SCRIPT DE INSERÇÃO DE EVENTO
--FOI REALIZADO A CRIAÇÃO DE CSV E DEPOIS A IMPORTAÇÃO PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[evento](titulo, descricao, data_ida, data_volta, id_instituicao, id_endereco, id_rota_ida, id_rota_volta, id_usuario_responsavel) 
  SELECT [TITULO]
      ,[DESCRICAO]
      ,[DATA_IDA]
      ,[DATA_VOLTA]
      ,[ID_INSTITUICAO]
      ,[ID_ENDERECO]
      ,[ID_ROTA_IDA]
      ,[ID_ROTA_VOLTA]
      ,[ID_USUARIO_RESPONSAVEL]
  FROM [ViajeFacilDB].[dbo].[insert_evento]
GO

