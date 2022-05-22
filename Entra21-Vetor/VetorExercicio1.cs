using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Vetor
{
    internal class VetorExercicio1
    {
        public void Executar()
        {
            int numero = 0;
            int[] numeros = new int[16];
            for (int indice = 0; indice < numeros.Length; indice = indice + 1)
            {
                Console.WriteLine("Informe o Número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                numeros[indice] = numero;
            }
        }
    }
}
