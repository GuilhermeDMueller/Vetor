CREATE TABLE pecas(
	id INTEGER PRIMARY KEY IDENTITY (1, 1),
	nome VARCHAR(50),
	tipo INT,
	preco_unitario DECIMAL(6, 2));

CREATE TABLE clientes(
	id INTEGER PRIMARY KEY IDENTITY (1, 1),
	nome VARCHAR(40),
	cpf VARCHAR(14));

SELECT * FROM pecas;
SELECT * FROM clientes;
CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1, 1), -- PK
	id_cliente INTEGER NOT NULL, -- FK
	cep VARCHAR(9) NOT NULL,
	estado VARCHAR(2) NOT NULL,
	cidade VARCHAR (30) NOT NULL,
	bairro VARCHAR (30) NOT NULL,
	logradouro VARCHAR(40) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	descricao TEXT,
	-- FOREIGN KEY nome_coluna_tabela_atual REFERENCES nome_tabela_pai(nome_coluna_pai_pk)
	FOREIGN KEY (id_cliente) REFERENCES clientes(id)
	);

CREATE TABLE pedidos(
		id INTEGER PRIMARY KEY IDENTITY(1, 1),
		id_cliente INTEGER NOT NULL,
		status TINYINT NOT NULL, -- 0..255,
		data_efetivacao_compra DATETIME2,
		
		data_criacao DATETIME2 NOT NULL,
	);

CREATE TABLE pedidos_pecas(
	id INTEGER PRIMARY KEY IDENTITY(1, 1), -- PK,
	id_peca INTEGER, -- FK tabela peças
	id_pedido INTEGER, -- FK tabela pedido

	quantidade SMALLINT,

	FOREIGN KEY(id_pedido) REFERENCES pedidos(id),
	FOREIGN KEY(id_peca) REFERENCES pecas(id)
);

-- Tipos de peças
-- 1 - SSD
-- 2 - Placa Vídeo
-- 3 - Placa Mãe
-- 4 - Font
-- 5 - Memória Ram

INSERT INTO pecas(nome, tipo, preco_unitario) VALUES
('SSD 240 GB', 1, 200),
('SSD 240 M2', 1, 420.39),
('RTX 3090 TI', 2, 9999.90),
('GTX 1060', 2, 1500),
('16GB DDR5 4800GHZ', 5, 800),
('16GB DDR4 3200Ghz', 5, 350);

INSERT INTO clientes(nome, cpf) VALUES
('Claudío', '070.334.489-73'),
('Cry', '032.599.384-69'),
('Júliana', '123.495.392-02');

INSERT INTO enderecos(id_cliente, estado, cidade, bairro, cep, logradouro, numero) VALUES
(1, 'SC', 'Blumenau', 'Velha', '08070-301', 'Rua Divinópolis', 777),
(1, 'SC', 'Blumenau', 'Velha Grande', '89070-472', 'Morro da Edith', 36),
(3, 'SC', 'Blumenau', 'Judity', 'Sem cep', 'Rua da Kellen', 23);

SELECT * FROM pecas;
SELECT * FROM clientes;
SELECT * FROM enderecos;