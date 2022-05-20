using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Vetor
{
    internal class VetorExercicio01
    {
        public void Executar()
        {
            string[] nomes = new string[3];
            string[] sobreNomes = new string[3];

            Console.WriteLine("Digite o nome: ");
            nomes[0] = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome: ");
            sobreNomes[0] = Console.ReadLine();

            Console.WriteLine("Digite o nome: ");
            nomes[1] = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome: ");
            sobreNomes[1] = Console.ReadLine();

            Console.WriteLine("Digite o nome: ");
            nomes[2] = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome: ");
            sobreNomes[2] = Console.ReadLine();

            Console.WriteLine("Nomes: " + nomes[0] + sobreNomes[0]);
            Console.WriteLine("Nomes: " + nomes[1] + sobreNomes[1]);
            Console.WriteLine("Nomes: " + nomes[2] + sobreNomes[2]);
        }
    }
}
