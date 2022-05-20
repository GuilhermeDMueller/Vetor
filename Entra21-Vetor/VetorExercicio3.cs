using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Vetor
{
    internal class VetorExercicio3
    {
        public void Executar()
        {
            string[] nomes = new string[7];
            double[] preços = new double[7];

            Console.WriteLine("Informe o nome do Produto: ");
            nomes[0] = Console.ReadLine();

            Console.WriteLine("Informe o preço do Produto: ");
            preços[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o nome do Produto: ");
            nomes[1] = Console.ReadLine();

            Console.WriteLine("Informe o preço do Produto: ");
            preços[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o nome do Produto: ");
            nomes[2] = Console.ReadLine();

            Console.WriteLine("Informe o preço do Produto: ");
            preços[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o nome do Produto: ");
            nomes[3] = Console.ReadLine();

            Console.WriteLine("Informe o preço do Produto: ");
            preços[3] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o nome do Produto: ");
            nomes[4] = Console.ReadLine();

            Console.WriteLine("Informe o preço do Produto: ");
            preços[4] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o nome do Produto: ");
            nomes[5] = Console.ReadLine();

            Console.WriteLine("Informe o preço do Produto: ");
            preços[5] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o nome do Produto: ");
            nomes[6] = Console.ReadLine();

            Console.WriteLine("Informe o preço do Produto: ");
            preços[6] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Nome: " + nomes[0] + "Preço: " + preços[0]);
            Console.WriteLine("Nome: " + nomes[1] + "Preço: " + preços[1]);
            Console.WriteLine("Nome: " + nomes[2] + "Preço: " + preços[2]);
            Console.WriteLine("Nome: " + nomes[3] + "Preço: " + preços[3]);
            Console.WriteLine("Nome: " + nomes[4] + "Preço: " + preços[4]);
            Console.WriteLine("Nome: " + nomes[5] + "Preço: " + preços[5]);
            Console.WriteLine("Nome: " + nomes[6] + "Preço: " + preços[6]);
        }
    }
}
