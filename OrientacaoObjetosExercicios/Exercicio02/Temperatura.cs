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
        }
        public double CalcularCelsiusParaFahrenheit()
        {
            var temperaturaConvertida = ValorTemperatura * 9 / 5 + 32;
        }
        public double CalcularKelvinParaCelsius()
        {
            var temperaturaConvertida = ValorTemperatura - 273.15;
        }
        public double CalcularKelvinParaFahrenheit()
        {
            var temperaturaConvertida = ValorTemperatura * 9 / 5 - 459.67;
        }
        public double CalcularFahrenheitParaCelsius()
        {
            var temperaturaConvertida = (ValorTemperatura - 32) * 5 / 9;
        }
        public double CalcularFahrenheitParaKelvin()
        {
            var temperaturaConvertida = (ValorTemperatura + 459.67) * 5 / 9;
        }
        public void ApresentarOrigemGraus()
        {
            if ((Origem == "Celsius") && (Destino == "Kelvin"))
            {

            }
        }
    }
}
