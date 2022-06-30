--Criar um banco de dados
CREATE DATABASE cadastroDePessoas_DB;

--Utilizar o banco criado
USE cadastroDePessoas_DB;

--Criar uma tabela
CREATE TABLE pessoa(
	idPessoa INT NOT NULL IDENTITY, --auto incremento
	nome VARCHAR(50) NOT NULL,
	sexo VARCHAR (50) NOT NULL,
	idade INT NOT NULL,
	altura FLOAT NOT NULL,
	peso FLOAT NOT NULL,
	cpf VARCHAR (20) NOT NULL,
	endereco VARCHAR (100),
	bairro VARCHAR (50) NOT NULL,
	cidade VARCHAR (50) NOT NULL,
	estado VARCHAR (50) NOT NULL,
	cep VARCHAR (50) NOT NULL,
	PRIMARY KEY (idPessoa)
);

-- Inserida dados na tabela
INSERT INTO pessoa VALUES('Maria das Graças', 'feminino', 55, 1.50, 100, '123.456.789-10', 
'Rua Willy Bath, 2364', 'São Gotardo', 'São Miguel do Oeste', 'SC', '89900-000');

SELECT * FROM pessoa;

SELECT * FROM INFORMATION_SCHEMA.TABLES;

SELECT * FROM INFORMATION_SCHEMA.COLUMNS;

SELECT nome, cpf FROM pessoa;

DELETE FROM pessoa 
WHERE idPessoa = 3;