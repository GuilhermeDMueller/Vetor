using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21___IfElse
{
    internal class IfElseExercicie02
    {
        public void Executar()
        {
            Console.WriteLine("Informe o número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero %2 == 0)
            {
                Console.WriteLine(@"O numero não é ímpar.
Informe novamente o numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero %2 != 0)
                {
                    Console.WriteLine("O número é ímpar.");
                }
            }
        }
    }
}
