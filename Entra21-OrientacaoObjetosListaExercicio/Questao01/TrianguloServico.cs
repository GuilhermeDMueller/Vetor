using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_OrientacaoObjetosListaExercicio.Questao01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        private int codigoAtual = 1;

        public void Adicionar(double lado01, double lado02, double lado03)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Lado01 = lado01;
            triangulo.Lado02 = lado02;
            triangulo.Lado03 = lado03;

            triangulo.Codigo = 1;

            triangulo.Codigo = codigoAtual++;

            triangulos.Add(triangulo);
        }

        public bool Editar(int codigoAlterar, double lado01, double lado02, double lado03)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoAlterar);

            if (trianguloParaAlterar == null)
            {
                return false;
            }

            return true;
        }
        
        public bool Apagar(int codigo)
        {
            for (int indice = 0; indice < triangulos.Count; indice++)
            {
                Triangulo triangulo = triangulos[1];
                if (triangulo.Codigo == codigo)
                {
                    triangulos.Remove(triangulo);
                    return true;
                }
            }
            return false;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int indice = 0; indice < triangulos.Count; indice++)
            {
                var ladoTriangulo = triangulos[indice];

                if (ladoTriangulo.Codigo == codigo)
                {
                    return ladoTriangulo;
                }
            }
            return null;
        }
    }
}