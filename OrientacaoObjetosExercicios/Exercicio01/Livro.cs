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
        public int CodigoIsbn, DataDeLancamento, QuantidadePaginas, QuantidadePaginasLidas, QuantidadeDeReleituras;
        public string Nome = " ";

        public string ApresentarTituloAutor()
        {
            Console.Write("O nome do Livro é: " + Titulo);
            Console.Write("O nome do Autor do Livro é: " + Autor);

            return 
        }

        public void ApresentarQuantidadePaginasLer()
        {
            Console.Write("A quantidade de Paginas para ler é de: " + QuantidadePaginas);
        }

        public void ApresentarQuantidadePaginasLidas()
        {
            Console.Write("A quantidade de Páginas lidas é de: " + QuantidadePaginasLidas);
        }
    }
}
