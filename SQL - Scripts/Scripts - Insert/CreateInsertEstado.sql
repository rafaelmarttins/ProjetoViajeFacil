--SCRIPT DE INSER��O DE REGI�O 
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[estado](nome, uf, id_regiao) 
VALUES
('ROND�NIA', 'RO', 3),
('ACRE', 'AC', 3),
('AMAZONAS', 'AM', 3),
('RORAIMA', 'RR', 3),
('PAR�', 'PA', 3),
('AMAP�', 'AP', 3),
('TOCANTINS', 'TO', 3),
('MARANH�O', 'MA', 5),
('PIAU�', 'PI', 5),
('CEAR�', 'CE', 5),
('RIO GRANDE DO NORTE', 'RN', 5),
('PARA�BA', 'PB', 5),
('PERNAMBUCO', 'PE', 5),
('ALAGOAS', 'AL', 5),
('SERGIPE', 'SE', 5),
('BAHIA', 'BA', 5),
('MINAS GERAIS', 'MG', 2),
('ESP�RITO SANTOS', 'ES', 2),
('RIO DE JANEIRO', 'RJ', 2),
('S�O PAULO', 'SP', 2),
('PARAN�', 'PR', 1),
('SANTA CATARINA', 'SC', 1),
('RIO GRANDE DO SUL', 'RS', 1),
('MATO GROSSO DO SUL', 'MS', 4),
('MATO GROSSO', 'MT', 4),
('GOI�S', 'GO', 4),
('DISTRITO FEDERAL', 'DF', 4)
GO