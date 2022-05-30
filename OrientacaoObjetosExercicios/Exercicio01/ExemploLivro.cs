using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosExercicios.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            var livro = new Livro();
            livro.Titulo = "A Cabana.";
            livro.Autor = "William P. Young.";
            livro.QuantidadePaginas = 272;
            livro.QuantidadePaginasLidas = 146;
            livro.DataDeLancamento = 2007;

            livro.ApresentarTitulo();
            livro.ApresentarAutor();
            livro.ApresentarQuantidadePaginasLer();
            livro.ApresentarQuantidadePaginasLidas();
            livro.ApresentarQuantidadeAnoAposPublicacao();
        }
    }
}
