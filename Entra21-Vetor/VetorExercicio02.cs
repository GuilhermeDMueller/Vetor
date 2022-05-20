using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Vetor
{
    internal class VetorExercicio02
    {
        public void Executar()
        {
            double[] notas = new double[4];

            Console.WriteLine("Informe a nota01: ");
            notas[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota01: ");
            notas[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota01: ");
            notas[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota01: ");
            notas[3] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Média: " + (+notas[0] + notas[1] + notas[2] + notas[3]) / 4);
        }
    }
}
