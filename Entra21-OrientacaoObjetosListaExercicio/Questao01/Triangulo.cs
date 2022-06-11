using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_OrientacaoObjetosListaExercicio
{
    public class Triangulo
    {
        public double Lado01, Lado02, Lado03;
        public int Codigo;
        
        public bool ValidarTriangulos()
        {

            var reta01 = Lado02 - Lado03;
            var reta001 = Lado02 + Lado03;
            var reta02 = Lado01 - Lado03;
            var reta002 = Lado01 + Lado03;
            var reta03 = Lado01 - Lado02;
            var reta003 = Lado01 + Lado02;

            if ((Lado02 - Lado03 < Lado01 && Lado01< Lado02 + Lado03) || (reta02 < Lado02 && Lado02 < reta002) || (reta03 < Lado03 && Lado03< reta003))
            {
                Console.WriteLine("Esta forma é um triangulo.");
                
                return true;
            }
            return true;
        }
        public void ValidarEhEquilatero()
        {
            if ((Lado01 == Lado02) && (Lado02 == Lado03) && (Lado01 == Lado03))
            {

            }
        }
    }
}