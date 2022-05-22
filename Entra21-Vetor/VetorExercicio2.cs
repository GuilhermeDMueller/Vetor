using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Vetor
{
    internal class VetorExercicio2
    {
        public void Executar()
        {
            string[] nomes = new string[10];

            Console.WriteLine("Informe o nome do cliente: ");
            nomes[0] = Console.ReadLine();

            Console.WriteLine("Informe o nome do cliente: ");
            nomes[1] = Console.ReadLine();
            
            Console.WriteLine("Informe o nome do cliente: ");
            nomes[2] = Console.ReadLine();
            
            Console.WriteLine("Informe o nome do cliente: ");
            nomes[3] = Console.ReadLine();
            
            Console.WriteLine("Informe o nome do cliente: ");
            nomes[4] = Console.ReadLine();
            
            Console.WriteLine("Informe o nome do cliente: ");
            nomes[5] = Console.ReadLine();

            Console.WriteLine("Informe o nome do cliente: ");
            nomes[6] = Console.ReadLine();

            Console.WriteLine("Informe o nome do cliente: ");
            nomes[7] = Console.ReadLine();

            Console.WriteLine("Informe o nome do cliente: ");
            nomes[8] = Console.ReadLine();

            Console.WriteLine("Informe o nome do cliente: ");
            nomes[9] = Console.ReadLine();

            Console.WriteLine(@"Os nomes dos clientes são: " + nomes[0] + ", " + nomes[1] + ", " + nomes[2] + ", " + nomes[3] + ", " + nomes[4] + ", " + nomes[5] + ", " + nomes[6] + ", " + nomes[7] + ", " + nomes[8] + ", " + nomes[9]);
        }
    }
}
