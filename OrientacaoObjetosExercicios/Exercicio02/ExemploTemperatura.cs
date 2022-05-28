using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExercicios.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 38;
            temperatura.Origem = " ";
            temperatura.Destino = " ";


            temperatura.ApresentarOrigemGraus();
            temperatura.;

            Console.WriteLine("Informe a Temperatura de Origem: ");
            temperatura.Origem = Console.ReadLine();

            Console.WriteLine("Informe a Temperatura de Destino: ");
            temperatura.Destino = Console.ReadLine();
        }
    }
}
