using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExercicios.Exercicio03
{
    public class ExemploCodigoAscii
    {
        public void Executar()
        {
            var ascii = new Ascii();
            ascii.ValorCodigo = 106;

            Console.WriteLine("Informe o Caracter Desejado: ");
            var character = Console.ReadLine();

            if ((character == "j") || (character == "J"))
            {
                Console.WriteLine("106");
            }

            else if ((character != "j") || (character != "J"))
            {
                Console.WriteLine("Character");
            }
        }
    }
}