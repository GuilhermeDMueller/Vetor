using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_OrientacaoObjetosListaExercicio.Questao01
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;

            while (codigo != 5)
            {
                Console.Clear();

                codigo = ApresentarSolicitarMenu();
                Console.Clear();

                if (codigo == 1)
                {
                    ApresentarTriangulo();
                }
                else if (codigo == 2)
                {
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    Editar();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                Thread.Sleep(2000);
            }
        }
        private void ApresentarTriangulo()
        {
            ApresentarTriangulos();
            Console.WriteLine("Digite o código do triangulo desejado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);
            if (triangulo == null)
            {
                Console.WriteLine("Triagulo não cadastrado");

                return;
            }
            Console.Clear();
            Console.WriteLine($@"Código: {triangulo.Codigo}
Tamanho lado01: {triangulo.Lado01}
Tamanho lado02: {triangulo.Lado02}
Tamanho Lado03: {triangulo.Lado03}");
        }
        private void Apagar()
        {
            ApresentarTriangulo();
            Console.WriteLine("Informe o código do triangulo a ser apagado :");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = trianguloServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro apagado com sucesso."
                : "Nenhum triangulo cadastrado com o código informado.");
        }
        private void Cadastrar()
        {
            Console.WriteLine("Informe o tamanho do 1º Lado: ");
            var lado01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do 2º Lado: ");
            var lado02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do 3º Lado: ");
            var lado03 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Questões Página 21: 
1 - TrianguloRetângulo
2 - Cateto e Hipotenusa do TrianguloRetângulo");
            Console.WriteLine("Questão: ");
            var questao = Convert.ToInt32(Console.ReadLine());

            trianguloServico.Adicionar(lado01, lado02, lado03);
        }
        private void Editar()
        {
            ApresentarTriangulo();

            Console.WriteLine("Informe o código do triangulo desejado: ");
            var codigoEditar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lado01: ");
            var lado01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lado02: ");
            var lado02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lado03: ");
            var lado03 = Convert.ToDouble(Console.ReadLine());

            var alterou = trianguloServico.Editar(codigoEditar,lado01, lado02, lado03);

            if (alterou == false)
                Console.WriteLine("Código Digitado não Existe.");
            else
                Console.WriteLine("Triangulo alterado com sucesso.");
        }
        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"Menu
1 - Apresentar Triangulo
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Sair");
            int codigo = SolicitarCodigo();

            return codigo;
        }
        private int SolicitarCodigo()
        {
            int codigo = 0;

            while (codigo < 1 || codigo > 5)
            {
                try
                {
                    Console.WriteLine("Digite o Código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um Código Válido: ");
                }
            }
            return codigo;
        }
        private void ApresentarTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine("Triangulo não cadastrado");

                return;
            }
            Console.WriteLine("Lista dos Triangulos");
            for (var indice = 0; indice < triangulos.Count; indice++)
            {
                var trianguloAtual = triangulos[indice];
                Console.WriteLine("\nCódigo: " + trianguloAtual.Codigo);
            }
        }
    }
}