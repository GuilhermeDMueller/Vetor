using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Vetor
{
    internal class VetorExercicio6
    {
        public void Executar()
        {
            int maiorIdade = int.MinValue;
            int[] idades = new int[9];
            
            for (int indice = 0; indice < idades.Length; indice = indice + 1)
            {
                Console.WriteLine("Informe a sua Idade: ");
                idades[indice] = Convert.ToInt32(Console.ReadLine());

                if (idades[indice] == maiorIdade)
                {
                    maiorIdade = idades[indice];
                }
            }
            Console.WriteLine("A maior idade é: " + maiorIdade);
            
        }
    }
}
