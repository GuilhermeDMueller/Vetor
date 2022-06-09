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

        // Atribuir valor para as Prorpiedades com os dados passados como parâmetro
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade) 
        {
            Produto produto = new Produto();
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }
        public void Editar() { }
        public void Apagar() { }
        
        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        
        public Produto ObterPorCodigo()
        {
            return null;
        }
    }
}