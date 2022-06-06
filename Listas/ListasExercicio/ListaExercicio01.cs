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
            filmes[1] = "Titanic2";
            filmes.Remove("Lanterna Verde");

            var indiceFilme = filmes.Contains("Lanterna Verde");
            indiceFilme = filmes.Contains("A Lagoa Azul");

            Console.Clear();
            Console.WriteLine("[0]: " + filmes[0] + "\n[1]: " + filmes[1]+ "\n[2]: " + filmes[2] + "\n[3]: " + filmes[3]);

            if (filmes.Contains("Lanterna Verde") == true)
                Console.WriteLine("O filme Lanterna Verde está Cadastrado e pronto para assistir.");

            else
                Console.WriteLine("O filme Lanterna Verde não está Cadastrado.");

            if (filmes.Contains("A Lagoa Azul") == true)
                Console.WriteLine("O filme A Lagoa Azul está Cadastrado e pronto para assistir.");
            else
                Console.WriteLine("O filme A Lagoa Azul não está Cadastrado.");
        }
    }
}
