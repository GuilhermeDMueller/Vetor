using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Vetor
{
    internal class VetorExercicio5
    {
        public void Executar()
        {
            double[] pesos = new double[5];

            Console.WriteLine("Informe o seu Peso: ");
            pesos[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o seu Peso: ");
            pesos[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o seu Peso: ");
            pesos[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o seu Peso: ");
            pesos[3] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o seu Peso: ");
            pesos[4] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("A soma total dos Pesos é: " + (+ pesos[0] + pesos[1] + pesos[2] + pesos[3] + pesos[4]));
            Console.WriteLine("A média dos Pesos é: " + (+ pesos[0] + pesos[1] + pesos[2] + pesos[3] + pesos[3] + pesos[4]) / 5);
        }
    }
}
