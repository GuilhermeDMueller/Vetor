using FluentAssertions;
using OrientacaoObjetosExercicios.Exercicio03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrientacaoObjetosExerciciosTest.ExercicioTest03
{
    public class Ascii03Test
    {
        [Theory]
        [InlineData("j", 106)]

        public void ValidarCodigoAscii(string character, int valorCodigoEsperado)
        {
            // Arrange
            var ascii = new Ascii();
            ascii.Character = character;

            // Act
            var codigoAscii = ascii.ConverterCharacterEmAscii();

            // Assert
            codigoAscii.Should().Be(valorCodigoEsperado);
        }
    }
}
