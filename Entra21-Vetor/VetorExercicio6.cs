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
            int menorIdade = int.MaxValue;
            int[] idades = new int[9];
            
            for (int indice = 0; indice < idades.Length; indice = indice + 1)
            {
                Console.WriteLine("Informe a sua Idade: ");
                idades[indice] = Convert.ToInt32(Console.ReadLine());

                if (idades[indice] == menorIdade)
                {
                    menorIdade = idades[indice];
                }
            }

            
        }
    }
}
