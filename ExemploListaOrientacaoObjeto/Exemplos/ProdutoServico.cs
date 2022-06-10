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
    }
}