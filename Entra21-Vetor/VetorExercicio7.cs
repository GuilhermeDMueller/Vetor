using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Vetor
{
    internal class VetorExercicio7
    {
        public void Executar()
        {
            double menorAltura = double.MaxValue;
            double[] alturas = new double[4];
            
            for (int indice = 0; indice < alturas.Length; indice = indice + 1)
            {
                Console.WriteLine("Informe a altura do Animal1: ");
                alturas[0] = Convert.ToDouble(Console.ReadLine());

                if (alturas[indice] > menorAltura)
                {
                    menorAltura = alturas[indice];
                }
            }
            Console.WriteLine("A menor altura é: " + menorAltura);
        }
    }
}
