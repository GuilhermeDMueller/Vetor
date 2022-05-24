using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21___IfElse
{
    internal class IfElseExercicie01
    {
        public void Executar()
        {
            Console.WriteLine("Informe o Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero % 2 != 0)
            {
                Console.WriteLine("O número não é par.");
                Console.WriteLine("Informe novamente o número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
            }
        }
    }
}