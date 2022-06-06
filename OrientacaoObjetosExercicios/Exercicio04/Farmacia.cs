using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExercicios.Exercicio04
{
    public class Farmacia
    {
        public string RazaoSocial, NomeProduto01, NomeProduto02, NomeProduto03, CategoriaProduto01, CategoriaProduto02, CategoriaProduto03, Cnpj;
        public double PrecoProduto01, PrecoProduto02, PrecoProduto03;
        public int QuantidadeProduto01, QuantidadeProduto02, QuantidadeProduto03;

        public string ApresentarTotalPedido()
        {
            var totalPedido = (NomeProduto01 + " Total: " + PrecoProduto01) + (NomeProduto02 + " Total: " + PrecoProduto02) + (NomeProduto03 + " Total: " + PrecoProduto03);

            return totalPedido;
        }
        public string ApresentarTotalPedidoCategoria01()
        {
            var totalPedido = NomeProduto01 + " Total: " + PrecoProduto01;

            return totalPedido;
        }
        public string ApresentarTotalPedidoCategoria02()
        {
            var totalPedido = NomeProduto02 + " Total: " + PrecoProduto02;

            return totalPedido;
        }
        public string ApresentarTotalPedidoCategoria03()
        {
            var totalPedido = NomeProduto03 + " Total: " + PrecoProduto03;

            return totalPedido;
        }
        public int ApresentarQuantidadeCategoria01()
        {
            var totalQuantidade = QuantidadeProduto01;

            return totalQuantidade;
        }
        public int ApresentarQuantidadeCategoria02()
        {
            var totalQuantidade = QuantidadeProduto02;

            return totalQuantidade;
        }
        public int ApresentarQuantidadeCategoria03()
        {
            var totalQuantidade = QuantidadeProduto03;

            return totalQuantidade;
        }
        public string ApresentarNomeProdutoMaisCaro()
        {
            var nomeProdutoCaro = NomeProduto02;

            return nomeProdutoCaro;
        }
        public string ApresentarNomeCategoriaProdutoMaisBarato()
        {
            var nomeProdutoCategoriaMaisBarato = NomeProduto03 + CategoriaProduto03;

            return nomeProdutoCategoriaMaisBarato;
        }
    }
}
