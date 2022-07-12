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

SELECT 
	c.nome,
	c.cpf,
	CONCAT(
	e.estado, ' - ',
	e.cidade, ' - ',
	e.bairro, ' - ',
	e.logradouro, ' - ',
	e.numero) AS 'Endereço Completo'
	FROM clientes AS c
	INNER JOIN enderecos AS e ON (e.id_cliente = c.id)

-- Nome Cliente, CPF, Endereço Completo

-- Consultar os endereços apresentando seu cliente filtrando por bairros com nome 'Velha'
-- Consulta partindo da tabela de endereços com outra consulta na tabela de clientes
SELECT
	c.nome,
	e.bairro,
	e.logradouro
	FROM enderecos AS e
	INNER JOIN clientes AS c ON(c.id = e.id_cliente)
	WHERE e.bairro LIKE '%Velha%';

-- Status do pedidos
-- 0 - CARRINHO
-- 1 - Aguardando Pagamento
-- 2 - Pagamento Efetivado
-- 3 - Entrega Realizada
INSERT INTO pedidos(id_cliente, status, data_criacao) VALUES
(1, 0, GETDATE()), -- Pedido para o Claudío
((SELECT id FROM clientes WHERE nome = 'Cry'), 0, GETDATE()); -- Pedido para o Cry
-- Consultar pedidos listando, data da criação formato pt-br, status com texto e nome do cliente
-- Consulta partindo da tabela de pedidos com JOIN em clientes
SELECT  
	FORMAT (p.data_criacao, 'dd/MM/yyyy'),
	CASE
		WHEN [status] = 0 THEN 'Carrinho'
		WHEN [status] = 1 THEN 'Aguardando Pagamento'
		WHEN [status] = 2 THEN 'Pagamento Efetivado'
		ELSE 'Entrega Realizada'
	END AS 'Staus Pedido',
	c.nome
	FROM pedidos AS p
	INNER JOIN clientes AS c ON(p.id_cliente = c.id)
UPDATE pedidos SET status = 1 WHERE id = 2;

