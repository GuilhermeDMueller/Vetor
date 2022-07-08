CREATE TABLE endereco (
	id INTEGER PRIMARY KEY IDENTITY(1, 1),
	estado VARCHAR(2),
	cidade VARCHAR(140),
	bairro VARCHAR(120),
	cep VARCHAR(10),
	logradouro VARCHAR(250),
	numero int,
	complemento TEXT
);
INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('AC', 'Rio Branco', 'Ayrton Senna', '69.911-866', 'Estrada Deputado José Rui Silveira Lino', 282, 'Casa');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('SC', 'Biguaçu', 'Fundos', '88.161-400', '', 995,'');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('MG', 'Santa Luzia', 'Padre Miguel', 33.082-050, 'Rua Buenos Aires', 371, 'apartemento');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('BA', '', 'São Tomé de Paripe', '40.800-361', 'Travessa Luís Hage', 685, '');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('MG', 'Ipatinga', 'Vila Celeste', '', 'Rua Antônio Boaventura Batista', 645, '');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('RS', 'Passo Fundo', 'Nenê Graeff', '99.030-250', '', 154, '');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('AM', 'Manaus', 'Petrópolis', '69.079-300', 'Rua Coronel Ferreira Sobrinho', 264, 'Fundos');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('TO', 'Gurupi', 'Muniz Santana', '77.402-130', 'Rua Aldemo Aires Nigri', 794, '');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('AC', '', 'Prevetório', '', 'Beco da Ligação II', 212, 'Bloco B');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('AP', 'Santana', 'Comercial', '68.925-073', 'Rua Calçoene', 648, '');

INSERT INTO endereco (estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES ('PB', 'Cabedelo', 'Camalaú', '58.103-052', 'Rua Siqueira Campos', 249, '');

-- Apresentar todos os registros do 'endereco"
SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
FROM endereco;

-- Filtramento para apresentar registros completos.
-- Descobrir a quantidade de caracters do registro 'complemento'
SELECT complemento, DATALENGTH(complemento)
	FROM endereco;

SELECT MIN(DATALENGTH(complemento))
	FROM endereco;

-- Filtrar Registros que possuem todas as informações;
SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
	FROM endereco
	WHERE estado != '' AND
	cidade != '' AND
	bairro != '' AND
	cep != '' AND
	logradouro != '' AND
	numero != -1 AND
	DATALENGTH(complemento) != 0;

-- Filtramento para apresentar registros que não contenham a informação 'cidade'
SELECT id, estado, bairro, cep, logradouro, numero, complemento
	FROM endereco
	WHERE cidade = '';

-- Filtramento para apresentar registros que contenham a informação 'bairro'
SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
	FROM endereco
	WHERE bairro != '';

-- Filtramento para apresentar registros que não contenham a informação 'cep'
SELECT id, estado, cidade, bairro, logradouro, numero, complemento
	FROM endereco
	WHERE cep = '';

-- Filtramento para apresentar registros que não contenham a informação 'logradouro'
SELECT id, estado, cidade, bairro, cep, numero, complemento
	FROM endereco
	WHERE logradouro = '';

-- Filtramento para apresentar registros que contenham a informação 'numero'
SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
	FROM endereco
	WHERE numero != -1;

-- Filtramento para apresentar registros que não contenham a informação 'complemento'
SELECT id, estado, cidade, bairro, cep, logradouro, numero
	FROM endereco
	WHERE DATALENGTH(complemento) = 0;