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
            Console.Clear();
            List<double> notas = new List<double>();
            Console.WriteLine("Informe a primeira nota do Semestre: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Informe a segunda nota do Semestre: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Informe a terceira nota do Semestre: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            var media = ((notas[0] + notas[1] + notas[2]) / 3);
            Console.WriteLine("Média: " + media);
            
            if (media <= 4.9)
                Console.WriteLine("A média está baixa.");
            else if ((media > 5.0) && (media < 7.0))
                Console.WriteLine("A média está boa mas tem que ser melhorada.");
            else if ((media > 7.1) && (media <= 10.0))
                Console.WriteLine("O aluno com a Média: " + media + " pode tirar dois dias de descanso(na aula).");
        }
    }
}
