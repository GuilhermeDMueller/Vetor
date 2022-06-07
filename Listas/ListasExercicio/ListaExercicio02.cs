using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21___Listas.ListasExercicio
{
    internal class ListaExercicio02
    {
        public void Executar()
        {
            List<string> conteudos = new List<string>();
            conteudos.Add("Como Fazer um Bolo");
            conteudos.Add("Variáveis");
            conteudos.Add("Mais Para Frente");
            conteudos.Add("If com OU");
            conteudos.Add("While");
            conteudos.Add("For");
            conteudos.Add("Vetor");
            conteudos.Add("Vetor");
            conteudos.Add("Vetor");
            conteudos.Add("Classe, Propriedades e Métodos");

            conteudos[0] = "Algoritimos Onde Vivem? Do Que Se Alimentam?";
            conteudos[2] = "If com E";
            conteudos[8] = "Vetor com For, o Amor da minha vida";
            conteudos.Remove("Vetor");
            conteudos.Remove("Vetor");

            Console.Clear();
            Console.WriteLine("[0]: " + conteudos[0] + "\n[1]: " + conteudos[1] + "\n[2]: " + conteudos[2] + "\n[3]: " + conteudos[3] + "\n[4]: " + conteudos[4] + "\n[5]: " + conteudos[5] + "\n[6]: " + conteudos[6] + "\n[7]: " + conteudos[7]);
        }
    }
}
