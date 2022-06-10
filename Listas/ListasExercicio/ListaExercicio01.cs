using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.ListasExercicio
{
    internal class ListaExercicio01
    {
        public void Executar()
        {
            List<string> filmes = new List<string>();
            filmes.Add("Dragon Ball Evollution");
            filmes.Add("Titanic");
            filmes.Add("Lanterna Verde");
            filmes.Add("");
            filmes.Add("Quarteto Fantástico");

            filmes[0] = "Dragon Ball Super: Broly";
            filmes[1] = "Titanic 2";
            filmes.Remove("Lanterna Verde");

            Console.Clear();
            Console.WriteLine("[1]: " + filmes[0] + "\n[2]: " + filmes[1] + "\n[3]: " + filmes[2] + "\n[4]: " + filmes[3]);
            if (filmes.Contains("Lanterna Verde") == true)
                Console.WriteLine("O Filme Lanterna Verde está Cadastrado e pronto para assistir.");

            else
                Console.WriteLine("O Filme Lanterna Verde não está Cadastrado.");

            if (filmes.Contains("A Lagoa Azul") == true)
                Console.WriteLine("O Filme A Lagoa Azul está Cadastrado e pronto para Assistir.");
            else
                Console.WriteLine("O Filme A Lagoa Azul não está Cadastrado.");
        }
    }
}
