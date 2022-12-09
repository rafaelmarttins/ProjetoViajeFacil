--SCRIPT DE INSERÇÃO DE USUARIO
--FOI REALIZADO A CRIAÇÃO DE CSV E DEPOIS A IMPORTAÇÃO PARA O BANCO
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[usuario](nome, email, cpf, telefone, [login], senha, id_endereco, id_tipo_usuario, id_instituicao) 
SELECT [NOME]
      ,[EMAIL]
      ,[CPF]
      ,[TELEFONE]
      ,[LOGIN]
      ,[SENHA]
      ,[ID_ENDERECO]
      ,[ID_TIPO_USUARIO]
      ,[ID_INSTITUICAO]
  FROM [ViajeFacilDB].[dbo].[insert_usuario]
GO
