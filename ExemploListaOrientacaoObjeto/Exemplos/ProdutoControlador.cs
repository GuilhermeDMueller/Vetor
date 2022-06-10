﻿namespace ExemploListaOrientacaoObjeto.Exemplos
{ 
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            int codigo = 0;
            // Repete enquanto o código não for o menu sair(6)
            while(codigo != 6)
            {
                Console.Clear();
                // Apresentar o menu e solicitar o código
                codigo = ApresentarSolicitarMenu();
                Console.Clear();
                if (codigo == 1)
                {
                    // Menu escolhido para listar produtos
                    ApresentarProdutos();
                }
                else if (codigo == 2)
                {
                    // Menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    // Menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                else if (codigo == 5)
                {
                    ApresentarProduto();
                }
                Thread.Sleep(1000);
            }
        }

        private void ApresentarProduto()
        {
            ApresentarProdutos();
            Console.WriteLine("Digite o código do produto a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);

            // Verificar se o produto não está cadastrado na lista de produtos
            if (produto == null)
            {
                Console.WriteLine("Produto não Cadastrado");

                return;
            }

            Console.Clear();
            Console.WriteLine(@$"Código: {produto.Codigo}
Nome: {produto.Nome}
Preço Unitário: {produto.PrecoUnitario}
Quantidade: {produto.Quantidade}
Total: {produto.CalcularPrecoTotal()}");
        }

        private void Apagar()
        {
            ApresentarProdutos();

            Console.WriteLine("Digite o código do produto para apagar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = produtoServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro removido com sucesso" 
                : "Nenhum produto cadastrado com o código informado");
        }

        private void Editar()
        {
            ApresentarProdutos();

            Console.WriteLine("Código do produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço Unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizaçõe Disponiveis: 
- Armazen
- Area Venda
- Loja");
            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == false)
            {
                Console.WriteLine("Código digitado não existe");
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso");
            }
        }

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@" Menu:
1 - Listar todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar produto desejado
6 Sair");
            int codigo = SolicitarCodigo();

            return codigo;
        }
        
        private int SolicitarCodigo()
        {
            int codigo = 0;
            // Continua solicitando o código até que seja um código entre 1 e 6
            while (codigo < 1 || codigo >= 6)
            {
                try
                {
                    Console.WriteLine("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Digite um menu válido");
                }

            }
            return codigo;
        }

        private void Cadastrar()
        {
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço Unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizações disponiveis: 
- Armazen
- Area Venda
- Loja");
            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }

        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazen")
            {
                return ProdutoLocalizacao.Armazen;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }

        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado :( ");
                // Para a execução deste método
                return;
            }

            Console.WriteLine("Lista de Produtos");

            for (var indice = 0; indice < produtos.Count; indice++)
            {
                var produtoAtual = produtos[indice];

                Console.WriteLine(
                    "\nCódigo: " + produtoAtual.Codigo + "\nNome: " + produtoAtual.Nome + "\n");
            }
        }
    }
}