using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExercicios.Exercicio01
{
    public class Livro
    {
        public string Titulo, Autor, IdiomaOriginal;
        public int CodigoIsbn, DataDeLancamento, QuantidadePaginas, QuantidadePaginasLidas, QuantidadeDeReleituras, AnosAposPubliacao;
        public string Nome = " ";

        public void ApresentarTitulo()
        {
            Console.WriteLine("O nome do Livro é: " + Titulo);

        }

        public void ApresentarAutor()
        {
            Console.WriteLine("O nome do Autor do Livro é: " + Autor);

        }
        
        public void ApresentarQuantidadePaginasLer()
        {
            Console.WriteLine("A quantidade de Paginas para ler é de: " + QuantidadePaginas + " pág.");

        }

        public void ApresentarQuantidadePaginasLidas()
        {
            Console.WriteLine("A quantidade de Páginas lidas é de: " + QuantidadePaginasLidas + " pág.");

        }

        public void ApresentarQuantidadeAnoAposPublicacao()
        {
            Console.WriteLine("A quantidade de Anos Apos a publicação do livro é de: " + (2022 - DataDeLancamento) + " anos.");
        }
    }
}
