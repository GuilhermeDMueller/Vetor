using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21___Listas.ListasExercicio
{
    internal class ListaExercicio03
    {
        public void Executar()
        {
            List<double> notas = new List<double>();
            Console.Clear();
            Console.WriteLine("Informe a Nota01: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Informe a Nota02: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Informe a Nota03: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            double media = (notas[0] + notas[1] + notas[2]) / 3;

            Console.Clear();
            Console.WriteLine("[0]: " + notas[0] + "\n[1]: " + notas[1] + "\n[2]: " + notas[2]);
            Console.WriteLine("A média das Notas é: " + media.ToString("F"));
            if (media <= 3.9)
                Console.WriteLine("A média é Baixa.");
            else if ((media > 3.9) && (media < 6.9))
                Console.WriteLine("A média é ruim e tem que ser melhorada.");
            else if (media > 7.0)
                Console.WriteLine("A média está Boa e pode ser melhorada.");
        }
    }
}
