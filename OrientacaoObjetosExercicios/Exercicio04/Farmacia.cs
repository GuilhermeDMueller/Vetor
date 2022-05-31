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
        public double PrecoProduto01, PrecoProduto02, PrecoProduto03, QuantidadeProduto01, QuantidadeProduto02, QuantidadeProduto03;

        public double ApresentarTotalPedido()
        {
            var totalPedido = (PrecoProduto01 * QuantidadeProduto01) + (PrecoProduto02 * QuantidadeProduto02) + (PrecoProduto03 * QuantidadeProduto03);

            return totalPedido;
        }
        public double ApresentarTotalPedidoCategoria01()
        {
            var totalPedido = PrecoProduto01 * QuantidadeProduto01;

            return totalPedido;
        }
        public double ApresentarTotalPedidoCategoria02()
        {
            var totalPedido = PrecoProduto02 * QuantidadeProduto02;

            return totalPedido;
        }

        public double ApresentarTotalPedidoCategoria03()
        {
            var totalPedido = PrecoProduto03 * QuantidadeProduto03;

            return totalPedido;
        }


    }
}
