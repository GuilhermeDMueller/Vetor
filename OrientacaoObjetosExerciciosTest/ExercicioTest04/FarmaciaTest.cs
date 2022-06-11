using OrientacaoObjetosExercicios.Exercicio04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrientacaoObjetosExerciciosTest.ExercicioTest04
{
    public class FarmaciaTest
    {
        [Theory]
        [InlineData(17.89, 8)]

        public void Validar_Apresentar_Total_Pedido_Categoria_01(string NomeProduto01, double PrecoProduto01)
        {
            // Arrange
            var farmacia = new Farmacia();
            farmacia.NomeProduto01 = NomeProduto01;

            // Act
            var fara = NomeProduto01; 
        }

    }
}
