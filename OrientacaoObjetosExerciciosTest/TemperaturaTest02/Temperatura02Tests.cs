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
        [Theory]
        [InlineData(32, 305.15)]
        public void Validar_Calculo_Celsius_Para_Kelvin(double valorTemperatura, double temperaturaConvertidaEsperada)
        {
            // Arrenge
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = valorTemperatura;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaKelvin();

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Theory]
        [InlineData(32, 89.6)]
        
        public void Validar_Calculo_Celsius_Para_Fahrenheit(double valorTemperatura, double temperaturaConvertidaEsperada)
        {
            // Arrenge
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = valorTemperatura;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Theory]
        [InlineData(32, -241.14999999999998)]

        public void Validar_Calculo_Kelvin_Para_Celsius(double valorTemperatura, double temperaturaConvertidaEsperada)
        {
            // Arreng
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = valorTemperatura;

            // Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Theory]
        [InlineData(32, -402.07)]

        public void Validar_Calculo_Kelvin_Para_Fahrenheit(double valorTemperatura, double temperaturaConvertidaEsperada)
        {
            // Arreng
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = valorTemperatura;

            // Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Theory]
        [InlineData(32, 0)]

        public void Validar_Calculo_Fahrenheit_Para_Celsius(double valorTemperatura, double temperaturaConvertidaEsperada)
        {
            // Arrent
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = valorTemperatura;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Theory]
        [InlineData(32, 273.15)]

        public void Validar_Calculo_Fahrenheit_Para_Kelvin(double valorTemperatura, double temperaturaConvertidaEsperada)
        {
            // Arrent
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = valorTemperatura;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaKelvin();

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }
    }
}