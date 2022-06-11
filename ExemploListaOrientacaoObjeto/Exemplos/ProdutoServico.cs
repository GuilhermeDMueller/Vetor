using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListaOrientacaoObjeto.Exemplos
{
    internal class ProdutoServico
    {
        // Instanciar um objeto da Classe Prouto
        private List<Produto> produtos = new List<Produto>();
        // Armazenar o código do proximo produto
        private int codigoAtual = 1;

        // Atribuir valor para as Prorpiedades com os dados passados como parâmetro
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            Produto produto = new Produto();
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Adicionar 
            produto.Codigo = codigoAtual;

            // Adicionar 1 no codigo atual para quando s
            codigoAtual++;

            // Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }
        // Assinatura
        // encapsulamento + tipoRetorno + NomeMetodo(Parametros)
        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade) 
        {
            // Obtém o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            // Verificar senão foi possivel encontrar o produto
            if (produtoParaAlterar == null)
            {
                // Retorna falso pq não exsite produto com o código dos parâmetros
                return false;
            }

            // Atualizar as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            // Retorna verdadeiro pq foi possivel alterar o produto
            return true;
        }
        public bool Apagar(int codigo)
        {
            // corpo do Metodo
            for (int indice = 0; indice < produtos.Count; indice++)
            {
                // Resgantando de uma lista de tipos primitivos
                // int numero = numeros[indice];
                // Resgatando de uma lista de objetos
                Produto produto = produtos[1];
                if (produto.Codigo == codigo)
                {
                    // Posso removet com o indice do objeto desejado
                    // produtos.RemoveAt(indice);

                    // Posso remover com o objeto desejado
                    produtos.Remove(produto);
                    // Retorna verdadeira porque o produto com o codigo desejado foi removido da lista
                    return true;
                }
            }
            // Retornar falso
            return false;
        }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        public Produto ObterPorCodigo(int codigo)
        {
            // Percorrer todos os elementos para encontrar o produto
            // filtrando por código
            for (int indice = 0; indice < produtos.Count; indice++)
            {
                // Obter o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[indice];

                // Verificar se o produtos atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    // Retorna o produto encontrado
                    return produtoAtual;
                }
                // 
            }
            return null;
        }

        // Novo modo: 
        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;

            Produto produtoMenorPrecoUnitario = null;

            //Percorre a lista de produtos para obter o produto com o menor preço Unitátio
            // Obtém o produto atual da lista que está sendo percorrida
            for (int indice = 0; indice < produtos.Count; indice++)
            {
                Produto produto = produtos[indice];

            // Verificar se o produto atual possui o menor preço unitário
                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    // armazena o preço unitário, pois é o menor preço unitárioaté o momento
                    menorPrecoUnitario = produto.PrecoUnitario;

                    // armazena o produto para posteriormente saber qual é o produto com o menor preçi unitário
                    produtoMenorPrecoUnitario = produto;
                }
            }
            return produtoMenorPrecoUnitario;
        }
        public List<double> ObterTodosPrecos()
        {
            // Criar uma lista de preço
            var precos = new List<double>();

            // Percorre todos os produtos
            for (int indice = 0; indice < produtos.Count; indice++)
            {
                // Obtém o preço total na lista de preços
                var produto = produtos[indice];

                // Adiciona o preço total na lista de preços
                precos.Add(produto.CalcularPrecoTotal());
            }
            return precos;
        }
        public List<double> ObterPrecosTotaisFiltradosPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            // Criar uma lista de preços totais
            var precos = new List<double>();

            // Percorre todos os produtos
            for (int indice = 0; indice < produtos.Count; indice++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[indice];

                // Verfifica se a localização do produto atual é a localização passada no parâmetro
                if (produto.Localizacao == localizacao)
                {
                    // adiciona o preço total do produto atual que foi filtrado por localização
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;
        }
        public List<double> ObterPrecosTotaisDoArmazen()
        {
            // Criar uma lista de preços totais
            var precos = new List<double>();

            // Percorre todos os produtos
            for (int indice = 0; indice < produtos.Count; indice++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[indice];

                // Verificar se a localização do produto atual é armazem
                if (produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    // Adiciona o preço total do produto atual que foi filtrado por armazén
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;
        }
        public double ObterMediaPrecosTotais()
        {
            var somaPrecosTotais = 0.0;

            // Percorre todos os produtos
            for (int indice = 0; indice < produtos.Count; indice++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[indice];

                // Adiciona o preço total do produto na variável soma de preços totais
                somaPrecosTotais += produto.CalcularPrecoTotal();
            }

            // Calcular a média de acordo com a quantidade de produtos
            var media = somaPrecosTotais / produtos.Count;

            return media;
        }
    }
}