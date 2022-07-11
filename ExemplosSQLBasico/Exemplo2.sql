CREATE TABLE marcas(
	id INTEGER PRIMARY KEY IDENTITY (1, 1),
	nome VARCHAR(50)
);

INSERT INTO marcas (nome) VALUES
('Adidas'),
('Ninha'),
('Alfa'),
('Happy');

SELECT id, nome 
	FROM marcas;

CREATE TABLE camisetas (
	id INTEGER PRIMARY KEY IDENTITY (1, 1), -- PK
	id_marca INTEGER, --FK(s)
	nome VARCHAR (100),
	FOREIGN KEY (id_marca) References marcas(id)
);

INSERT INTO camisetas (id_marcas, nome) VALUES
(1, 'Rosa'),
(2, 'Erva daninha'),
(3, 'Vermelha'),
(4, 'Be'),
(4, 'Not Be'),
(1, 'José');

SELECT id, nome FROM marcas;
SELECT id, id_marca, nome FROM camisetas;

SELECT c.id,m.nome AS 'Marca', c.nome FROM camisetas AS c
INNER JOIN marcas AS m ON (m.id = c.id_marca);