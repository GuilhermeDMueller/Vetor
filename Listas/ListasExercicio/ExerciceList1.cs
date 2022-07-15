using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_Listas.ListasExercicio
{
    internal class ExerciceList1
    {
        public void Executar()
        {
            List<string> filmes = new List<string>();
            filmes.Add("Dragon Ball: Evollution");
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
                Console.WriteLine("O filme Lanterna Verde está cadastrado e pronto para assistir");
            else
                Console.WriteLine("O filme Lanterna Verde não está cadastrado");
            
            if (filmes.Contains("A Lagoa Azul") == true)
                Console.WriteLine("O filme 'A Lagoa Azul' está cadastrado e pronto para assistir");
            else
                Console.WriteLine("O filme 'A Lagoa Azul' não está cadastrado");

        }
    }
}
