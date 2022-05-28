using FluentAssertions;
using OrientacaoObjetosExercicios.Exercicio02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrientacaoObjetosExerciciosTest.TemperaturaTest02
{
    public class Temperatura02Tests
    {
        [Fact]

        public void Validar_Calculo_Celsius_Para_Kelvin()
        {
            // Arrenge
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 32;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaKelvin();

            // Assert
            temperaturaConvertida.Should().Be(32 + 273.15);
        }

        [Fact]

        public void Validar_Calculo_Celsius_Para_Fahrenheit()
        {
            // Arrenge
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 32;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be(32 * 9 / 5 + 32);


        }

        [Fact]

        public void Validar_Calculo_Kelvin_Para_Celsius()
        {
            // Arreng
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 32;

            // Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be(32 - 273.15);
        }

        [Fact]

        public void Validar_Calculo_Kelvin_Para_Fahrenheit()
        {
            // Arreng
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 32;

            // Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be(32  * 9 / 5 - 459.67);
        }

        [Fact]

        public void Validar_Calculo_Fahrenheit_Para_Celsius()
        {
            // Arrent
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 32;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be((32 - 32) * 5 / 9);
        }

        [Fact]

        public void Validar_Calculo_Fahrenheit_Para_Kelvin()
        {
            // Arrent
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 32;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaKelvin();

            // Assert
            temperaturaConvertida.Should().Be((32 + 459.67) * 5 / 9);
        }
    }
}
