using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_OrientacaoObjetosListaExercicio.Questao01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulo = new List<Triangulo>();
        private int codigoAtual = 1;

        public void Adicionar(double lado01, double lado02, double lado03)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Lado01 = lado01;
            triangulo.Lado02 = lado02;
            triangulo.Lado03 = lado03;

            triangulo.Codigo = 1;

            triangulo.Codigo = codigoAtual++;
        }

        //public bool Editar()
        //{
            //Triangulo trianguloParaAlterar = ObterPorCodigo();

            //if (trianguloParaAlterar == null)
            //{
            //    return false;
            //}

            //return true;
        //}
        
        public void Apagar()
        {

        }

        public void ObterTodos()
        {

        }

        public void ObterPorCodigo()
        {
            //return;
        }
    }
}
