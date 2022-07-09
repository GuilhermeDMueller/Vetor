CREATE TABLE champions(
	id INTEGER PRIMARY KEY IDENTITY(1, 1),
	nome VARCHAR(30),
	descrição VARCHAR(50),
	habilidade1 VARCHAR(75),
	habilidade2 VARCHAR(75),
	habilidade3 VARCHAR(75),
	habilidade4 VARCHAR(75),
	habilidade5 VARCHAR(75)
);

INSERT INTO champions(nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Katarina', 'a Lâmina Sinistra', 'Voracidade', 'Lâmina Saltitante', 'Preparação', 'Shunpo', 'Lótus da Morte');

INSERT INTO champions(nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Yasuo', '', 'Estilo do Errante', 'Tempestate de Aço', 'Parede de Vento', 'Espada Ágil', 'Último Suspiro');

INSERT INTO champions(nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Master Yi', 'o Espadachim Wuju', 'Ataque Duplo', '', '', '', '');

INSERT INTO champions(nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Vayne', 'a Caçadora Noturna', 'Caçadora Noturna', 'Rolamento', 'Dardos de Prata', 'Condenar', 'Hora Final');

INSERT INTO champions(nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Lee Sin', 'o Monge Cego', 'Agitação', 'Onda Sônica/Ataque Ressoante', 'Proteger/Vontade de Ferro', 'Tempestade/Mutilar', '');

INSERT INTO champions(nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Vi', 'a Defensora de Piltover', 'Blindagem', '', 'Pancadaria Certeira', 'Força Excessiva', 'Saque e Enterrada');

INSERT INTO champions(nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Diana', 'o Escárnio da Lua', 'Espada de Prata Lunar', 'Golpe Crescente', 'Cascata Lívida', 'Colapso Minguante', 'Zêniter Lunar');

INSERT INTO champions(nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Annie', 'a Criança Sombria', 'Piromania', 'Desintegrar', 'Incinerar', 'Escudo Fundido', 'Invocar: Tibbers');

INSERT INTO champions(nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Aatrox', '', 'Poço de Sangue', 'Voo Sombrio', 'Sede de Sangue/Preço em Sangue', 'Lâminas da Aflição', 'Massacre');

-- Filtramento para apresentar todos os registros
SELECT id, nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5
	FROM champions;

-- Filtramento para apresentar os registros que não contenham a informação 'descrição'
SELECT id, nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5
	FROM champions
	WHERE descrição = '';

-- Filtramento para apresentar os registros que não contenham a informação 'habilidade2'
SELECT id, nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5
	FROM champions
	WHERE habilidade2 = '';

-- Filtramento para apresentar os registros que não contenham a informação 'habilidade4'
SELECT id, nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5
	FROM champions
	WHERE habilidade4 = '';

-- Filtramento para apresentar os registros que não contenham a informação 'habilidade5'
SELECT id, nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5
	FROM champions
	WHERE habilidade5 = '';

-- Filtramento para apresentar os registros que contenham a informação 'habilidade1'
SELECT id, nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5
	FROM champions
	WHERE habilidade1 != '';

-- Filtramento para apresentar os registros que contenham a informação 'habilidade4'
SELECT id, nome, descrição, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5
	FROM champions
	WHERE habilidade4 != '';
