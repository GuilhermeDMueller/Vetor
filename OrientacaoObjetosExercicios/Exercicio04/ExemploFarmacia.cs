using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExercicios.Exercicio04
{
    public class ExemploFarmacia
    {
        public void Executar()
        {
            var farmacia = new Farmacia();
            farmacia.RazaoSocial = "Farmacia do Zé.";
            farmacia.NomeProduto01 = "Torsilax.";
            farmacia.PrecoProduto01 = 17.89;
            farmacia.CategoriaProduto01 = "Medicamento para dor.";
            farmacia.NomeProduto02 = "Ibuprofeno.";
            farmacia.PrecoProduto02 = 25.65;
            farmacia.CategoriaProduto02 = "Medicamento Anti-inflamatório.";
            farmacia.NomeProduto03 = "Escova de Dentes infantil.";
            farmacia.PrecoProduto03 = 12.41;
            farmacia.CategoriaProduto03 = "Iten de Higiene Pessoal.";
            farmacia.Cnpj = "165-8 | Empresário Comercial.";

            farmacia.ApresentarTotalPedido();
            farmacia.ApresentarTotalPedidoCategoria01();
            farmacia.ApresentarTotalPedidoCategoria02();
            farmacia.ApresentarTotalPedidoCategoria03();
            farmacia.ApresentarQuantidadeCategoria01();
            farmacia.ApresentarQuantidadeCategoria02();
            farmacia.ApresentarQuantidadeCategoria03();
            farmacia.ApresentarNomeProdutoMaisCaro();
            farmacia.ApresentarNomeCategoriaProdutoMaisBarato();

        }
    }
}
