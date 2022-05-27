using Entra21_OrientacaoObjeto2;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21OrientacaoObjeto.Test.Produtos
{
    public class ProdutoTestes
    {
        [Fact]
        public void Validar_EhVencido_Com_Data_Menor_Hoje()
        {
            var produto = new produto();
            produto.DataVencimento = new DateTime(2022, 05, 04);

            var produtoVencido = produto.EhVencido();

            produtoVencido.Should().BeTrue();
        }
        
        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Maior_Hoje()
        {
            //Arrange
            var produto = new produto();
            produto.DataVencimento = DateTime.Today.AddDays(1);

            // Act
            var vencido = produto.EhVencido();

            //Assert
            vencido.Should().BeFalse();
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Hoje()
        {
            // Arrange
            var produto = new produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var vencido = produto.EhVencido();

            // Assert
            vencido.Should().BeTrue();
        }

        [Fact]
        public void Validar_EstaEmPromocao_Verdadeiro()
        {
            // Arrange
            var produto = new produto();
            produto.DataVencimento = DateTime.Today.AddDays(3);

            // Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().BeTrue();
        }

        [Fact]
        public void Validar_EstaEmPromoca_Falso()
        {
            // Arrange
            var produto = new produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().BeFalse();
        }
    }
}
