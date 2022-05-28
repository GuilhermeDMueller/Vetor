using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExercicios.Exercicio02
{
    public class Temperatura
    {
        public double ValorTemperatura;
        public string Origem, Destino;
        public double CalcularCelsiusParaKelvin()
        {
            var temperaturaConvertida = ValorTemperatura + 273.15;

            return temperaturaConvertida;
        }
        public double CalcularCelsiusParaFahrenheit()
        {
            var temperaturaConvertida = ValorTemperatura * 9 / 5 + 32;

            return temperaturaConvertida;
        }
        public double CalcularKelvinParaCelsius()
        {
            var temperaturaConvertida = ValorTemperatura - 273.15;

            return temperaturaConvertida;
        }
        public double CalcularKelvinParaFahrenheit()
        {
            var temperaturaConvertida = ValorTemperatura * 9 / 5 - 459.67;

            return temperaturaConvertida;
        }
        public double CalcularFahrenheitParaCelsius()
        {
            var temperaturaConvertida = (ValorTemperatura - 32) * 5 / 9;

            return temperaturaConvertida;
        }
        public double CalcularFahrenheitParaKelvin()
        {
            var temperaturaConvertida = (ValorTemperatura + 459.67) * 5 / 9;

            return temperaturaConvertida;
        }
        public void ApresentarOrigemGraus()
        {
            if ((Origem == "Celsius") && (Destino == "Kelvin"))
            {
                Console.WriteLine(CalcularCelsiusParaKelvin());
            }
            else if ((Origem == "Celsius") && (Destino == "Fahrenheit"))
            {
                Console.WriteLine(CalcularCelsiusParaFahrenheit());
            }
            else if ((Origem == "Kelvin") && (Destino == "Celsius"))
            {
                Console.WriteLine(CalcularKelvinParaCelsius());
            }
            else if ((Origem == "Kelvin") && (Destino == "Fahrenheit"))
            {
                Console.WriteLine(CalcularKelvinParaFahrenheit());
            }
            else if ((Origem == "Fahrenheit") && (Destino == "Celsius"))
            {
                Console.WriteLine(CalcularFahrenheitParaCelsius());
            }
        }
    }
}