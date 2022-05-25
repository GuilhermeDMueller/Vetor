using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21___IfElse
{
    internal class IfElseExercicie04
    {
        public void Executar()
        {
            double media = 0;
            Console.WriteLine("Informe a Nota01: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Nota02: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Nota03: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Nota04: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A média do Aluno é: " + ((nota1 + nota2 + nota3 + nota4) / 4));
            if ((media >= 0) && (media <= 5.99))
            {
                Console.WriteLine("O Aluno está Reprovado.");
            }
            else if ((media >= 6.00) && (media < 7.99))
            {
                Console.WriteLine("O Aluno está em Recuperação.");
            }
            else if (media >= 7.99)
            {
                Console.WriteLine("O Aluno está Aprovado.");
            }
        }

    }
}
