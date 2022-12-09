--SCRIPT DE INSERÇÃO DE REGIÃO 
USE ViajeFacilDB
GO
INSERT INTO [ViajeFacilDB].[dbo].[estado](nome, uf, id_regiao) 
VALUES
('RONDÔNIA', 'RO', 3),
('ACRE', 'AC', 3),
('AMAZONAS', 'AM', 3),
('RORAIMA', 'RR', 3),
('PARÁ', 'PA', 3),
('AMAPÁ', 'AP', 3),
('TOCANTINS', 'TO', 3),
('MARANHÃO', 'MA', 5),
('PIAUÍ', 'PI', 5),
('CEARÁ', 'CE', 5),
('RIO GRANDE DO NORTE', 'RN', 5),
('PARAÍBA', 'PB', 5),
('PERNAMBUCO', 'PE', 5),
('ALAGOAS', 'AL', 5),
('SERGIPE', 'SE', 5),
('BAHIA', 'BA', 5),
('MINAS GERAIS', 'MG', 2),
('ESPÍRITO SANTOS', 'ES', 2),
('RIO DE JANEIRO', 'RJ', 2),
('SÃO PAULO', 'SP', 2),
('PARANÁ', 'PR', 1),
('SANTA CATARINA', 'SC', 1),
('RIO GRANDE DO SUL', 'RS', 1),
('MATO GROSSO DO SUL', 'MS', 4),
('MATO GROSSO', 'MT', 4),
('GOIÁS', 'GO', 4),
('DISTRITO FEDERAL', 'DF', 4)
GO