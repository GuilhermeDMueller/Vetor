using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Vetor
{
    internal class VetorExercicio4
    {
        public void Executar()
        {
            string[] nomes = new string[1];
            double[] notas = new double[4];

            Console.WriteLine("Informe o nome do aluno: ");
            nomes[0] = Console.ReadLine();

            Console.WriteLine("Informe a nota01 desse aluno:");
            notas[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota02 desse aluno:");
            notas[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota03 desse aluno:");
            notas[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota04 desse aluno:");
            notas[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("A média do aluno " + nomes[0] + " é: " + (notas[0] + notas[1] + notas[2] + notas[3]) / 4);
        }
    }
}
