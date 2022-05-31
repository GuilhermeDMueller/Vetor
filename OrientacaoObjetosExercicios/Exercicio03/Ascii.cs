using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExercicios.Exercicio03
{
    public class Ascii
    {
        public string Character;
        public int ValorCodigo;

        public int ConverterCharacterEmAscii()
        {
            int valorCodigo = 106;
            if (Character == "j")
            {
                return 106;
            }
            return 0;
        }
    }
}