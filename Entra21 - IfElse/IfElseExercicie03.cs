using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21___IfElse
{
    internal class IfElseExercicie03
    {
        public void Executar()
        {
            Console.WriteLine("Informe o número01: ");
            int numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número02: ");
            int numero02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(@"Menu 
1   |   Somar
2   |   Subtração
3   |   Multiplicação
4   |   Divisão");
            int numeroMenu = Convert.ToInt32(Console.ReadLine());
            if (numeroMenu == 1)
            {
                Console.WriteLine("A soma dos valores é: " + (numero01 + numero02));
            }
            else if (numeroMenu == 2)
            {
                Console.WriteLine("A subtração dos valores é: " + (numero01 - numero02));
            }
            else if (numeroMenu == 3)
            {
                Console.WriteLine("A multiplicação dos valores é: " + (numero01 * numero02));
            }
            else if (numeroMenu == 4)
            {
                Console.WriteLine("");
            }
        }
    }
}
