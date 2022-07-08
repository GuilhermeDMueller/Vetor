CREATE TABLE pessoas(
	id INTEGER PRIMARY KEY IDENTITY(1, 1),
	nome VARCHAR(100),
	cpf VARCHAR(14),
	rg VARCHAR(12),
	data_de_nascimento DATETIME2,
	idadde DATETIME2
);

INSERT INTO pessoas (nome, cpf, rg)
	VALUES('Erick Bryan Enrico Vieira', '699.734.958-70', '90.745.276-0');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Samuel Ruan Dias', '802.790.194-40', '55.318.691-7');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Fábio Benjamin Souza', '522.445.349-60', '54.715.232-2');

SELECT id, nome, cpf, rg
	FROM pessoas;

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Elias Miguel Aparicio', '293.928.821-65', '12.680.444-8');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Alexandre Gustavo Cardoso', '617.408.878-24', '8.888.574-4');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Kauê Lucca Duarte', '943.163.990-47', '46.977.509-9');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Marcos Bryan Guilherme Mendes', '955.192.235-95', '84.050.077-4');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Benedito Pedro Carlos da Mota', '510.505.472-50', '43.588.124-3');

SELECT id, nome, cpf, rg 
	FROM pessoas;

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Luís Igor Barbosa', '370.570.311-06', '40.651.407-0');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('José Heitor Ramos', '675.624.925-81', '83.962.258-2');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Lucca Thiago Galvão', '788.124.508-57', '3.296.335-6');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Thiago Edson Oliveira', '389.969.352-39', '8.198.446-9');

SELECT id, nome, cpf, rg
	FROM pessoas;

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Enrico Julio Fábio Martins', '529.078.166-83', '99.886.242-3');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Oliver Victor Benjamin da Mota', '798.556.805-02', '5.103.578-9');

INSERT INTO pessoas(nome, cpf, rg)
	VALUES ('Bryan Caio Lope', '213.217.201-30', '12.949.454-9');

SELECT id, nome, cpf, rg
	FROM pessoas;

UPDATE pessoas SET data_de_nascimento = '1989-05-28' WHERE id = 4;
UPDATE pessoas SET data_de_nascimento = '1988-02-08' WHERE id = 5;
UPDATE pessoas SET data_de_nascimento = '1970-03-22' WHERE id = 6;
UPDATE pessoas SET data_de_nascimento = '2003-04-15' WHERE id = 7;
UPDATE pessoas SET data_de_nascimento = '1986-06-07' WHERE id = 8;
UPDATE pessoas SET data_de_nascimento = '1965-06-15' WHERE id = 9;
UPDATE pessoas SET data_de_nascimento = '2015-02-06' WHERE id = 10;
UPDATE pessoas SET data_de_nascimento = '1981-04-19' WHERE id = 11;
UPDATE pessoas SET data_de_nascimento = '2013-05-06' WHERE id = 12;
UPDATE pessoas SET data_de_nascimento = '1965-04-11' WHERE id = 13;
UPDATE pessoas SET data_de_nascimento = '1977-06-17' WHERE id = 14;
UPDATE pessoas SET data_de_nascimento = '1977-06-09' WHERE id = 15;
UPDATE pessoas SET data_de_nascimento = '2017-03-11' WHERE id = 16;
UPDATE pessoas SET data_de_nascimento = '1985-03-27' WHERE id = 17;
UPDATE pessoas SET data_de_nascimento = '1970-06-18' WHERE id = 18;

SELECT id, nome, cpf, rg, data_de_nascimento
	FROM pessoas;

ALTER TABLE pessoas Add idade_usuario int;
SELECT nome, idade_usuario
	FROM pessoas;

UPDATE pessoas SET idade_usuario = 29 WHERE id = 4;
UPDATE pessoas SET idade_usuario = 30 WHERE id = 5;
UPDATE pessoas SET idade_usuario = 48 WHERE id = 6;
UPDATE pessoas SET idade_usuario = 32 WHERE id = 7;
UPDATE pessoas SET idade_usuario = 15 WHERE id = 8;
UPDATE pessoas SET idade_usuario = 53 WHERE id = 9;
UPDATE pessoas SET idade_usuario = 3 WHERE id = 10;
UPDATE pessoas SET idade_usuario = 37 WHERE id = 11;
UPDATE pessoas SET idade_usuario = 5 WHERE id = 12;
UPDATE pessoas SET idade_usuario = 53 WHERE id = 13;
UPDATE pessoas SET idade_usuario = 41 WHERE id = 14;
UPDATE pessoas SET idade_usuario = 41 WHERE id = 15;
UPDATE pessoas SET idade_usuario = 1 WHERE id = 16;
UPDATE pessoas SET idade_usuario = 33 WHERE id = 17;
UPDATE pessoas SET idade_usuario = 48 WHERE id = 18;

SELECT id, nome, cpf, rg, data_de_nascimento, idade_usuario
	FROM pessoas;

SELECT id nome, CONCAT(DAY(data_de_nascimento), '/', 
MONTH(data_de_nascimento), '/',
YEAR(data_de_nascimento))
FROM pessoas;

SELECT id, nome, FORMAT(data_de_nascimento, 'dd/MM/yyyy')
FROM pessoas;

SELECT id, nome, cpf, rg, data_de_nascimento, idade_usuario
	FROM pessoas
	ORDER BY id
	OFFSET 3 ROWS FETCH NEXT 5 ROWS ONLY;

SELECT id, nome, cpf, rg, data_de_nascimento, idade_usuario
	FROM pessoas
	ORDER BY id
	OFFSET 8 ROWS FETCH NEXT 5 ROWS ONLY;

SELECT id, nome, cpf, rg, data_de_nascimento, idade_usuario
	FROM pessoas
	ORDER BY id
	OFFSET 13 ROWS FETCH NEXT 5 ROWS ONLY;

DELETE FROM pessoas WHERE id = 1;
DELETE FROM pessoas WHERE id = 2;
DELETE FROM pessoas WHERE id = 3;

SELECT id, nome, cpf, rg, data_de_nascimento, idade_usuario
	FROM pessoas;