CREATE TABLE pessoas(
	id INTEGER PRIMARY KEY IDENTITY(1, 1),
	nome VARCHAR(100),
	cpf VARCHAR(14),
	rg VARCHAR(12),
	data_de_nascimento datetime2,
	idade datetime2
);

INSERT INTO pessoas(id, nome)
	VALUES(1, 'Erick Bryan Enrico Vieira');

INSERT INTO pessoas(id, nome)
	VALUES (2, 'Samuel Ruan Dias');

INSERT INTO pessoas(id, nome)
	VALUES (3, 'Fábio Benjamin Souza');

SELECT id, nome
	FROM pessoas;