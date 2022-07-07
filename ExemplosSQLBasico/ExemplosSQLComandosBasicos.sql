CREATE TABLE trabalhos(
	id INTEGER PRIMARY KEY IDENTITY(1, 1),
	titulo VARCHAR(100),
	subtitulo VARCHAR(50),
	descricao TEXT,
	data_publicacao DATETIME2,
	tipo VARCHAR(15)
);
INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('A melhor pizza do mundo', 'Como degustar uma pizza de calabresa', 'Grande descrição aki', '1994-06-04', 'Receita');
	
	INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Clean code', 'Como trabalhar melhor no seu dia a dia', 'Utilizar var no lugar de tipo primitivos, Identar seu código, utilizar constantes', '2000-03-02', 'Leitura técnica');
	
	INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Pudim com ovo', 'Aprenda o que a não fazer na sua vida', 'Jogue o pudim no lixo e faça um ovo', '2022-07-06', 'Receita');
	
	INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Estrutura de dados', 'como sofrer sem saber, porém é necessário', 'Importante para aprender fifo, fefo, lifo, listas encadeadas', '1980-06-11', 'Leitura técnica');

	INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Strogonoff de frango', 'a vitória da batata palha', 'Compre frango e batata palha, jogue na panela, acenda o fogão, espera 5 minutinhos e ta plonto o  sorvetinho', '2000-09-10', 'Receita');

	SELECT id, titulo, subtitulo, descricao, data_publicacao, tipo
		FROM trabalhos;

-- 
SELECT CONCAT(titulo, ' - ', subtitulo) AS	'Título completo'
FROM trabalhos;


-- Consultar a descrição limitando a quantidade de caracteres
SELECT
titulo AS 'Título',
CONCAT(SUBSTRING(descricao, 0, 30), '...') AS 'Descrição'
FROM trabalhos;

-- Consultar os trabalhos filtrando o ano da publicação entre 1990 até 2010
SELECT id, titulo, data_publicacao FROM trabalhos
WHERE
YEAR(data_publicacao) >= 1990 AND
YEAR(data_Publicacao) <= 2010;

-- Consultar data publicação formato BR huehue
-- BR: dia/mes/anos
SELECT id, titulo, CONCAT(DAY(data_publicacao), '/', 
MONTH(data_publicacao), '/',
YEAR(data_publicacao))
FROM trabalhos;

-- Consultar a data de publicação formantando no padrão BR, utilizando função para isso
SELECT id, titulo, FORMAT(data_publicacao, 'dd/MM/yyyy')
FROM trabalhos;

-- Limitar a consulta para dois registros
SELECT TOP(2) id,titulo FROM trabalhos;

-- Apresentar o código, nome, preço, se está favoritado
-- Filtrando por Placa Mãe ou Placa de Video do maior preço para o menor
-- SELECT TOP(20) id, nome, preco, favoritado
-- FROM produtos
-- WHERE categoria = 'Placa mãe' OR categoria = 'Placa de Video'
-- ORDER BY preco DESC

-- Consulta paginação apresentando 2 registros da página 1
SELECT id, titulo
FROM trabalhos
ORDER BY id
OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros da página 2
SELECT id, titulo
FROM trabalhos
ORDER BY id
OFFSET 2 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros da página 3
SELECT id, titulo
FROM trabalhos
ORDER BY id
OFFSET 4 ROWS FETCH NEXT 2 ROWS ONLY;