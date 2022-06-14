using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_OrientacaoObjetosListaExercicio.Questao02
{
    internal class ControladorDeAlunos
    {
        private ServicoDosAlunos servicoDosAlunos = new ServicoDosAlunos();

        public void GerenciarCodigo()
        {
            int codigo = 0;

            //while (codigo != 6)
            //{
            //    Console.Clear();

            //    codigo = ApresentarSolicitarMenu();
            //    Console.Clear();

            //    if (codigo == 1)
            //    {
            //        ApresentarAlunos();
            //    }
            //    else if (codigo == 2)
            //    {
            //        CadastrarAlunos();
            //    }
            //}
        }

        private void ApresentarAlunos()
        {
            ApresentarAlunos();
            Console.WriteLine("Informe qual Aluno deseja ser apresentado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var aluno = servicoDosAlunos.ObterPorCodigo(codigo);

            if (aluno == null)
            {
                Console.WriteLine("Aluno não cadastrado: ");

                return;
            }
            Console.Clear();
            Console.WriteLine(@$"Código: {aluno.Codigo}
Nome: {aluno.Nome}
Idade: {aluno.Idade}
Matéria Favorita: {aluno.MateriaFavorita}
Codigo de Matrícula: {aluno.CodigoMatricula}
Nota 1: {aluno.Nota01}
Nota 2: {aluno.Nota02}
Nota 3: {aluno.Nota03}");
        }
        private void CadastrarAlunos()
        {
            Console.WriteLine("Nome do Aluno(a): ");
            var nome = Console.ReadLine();

            Console.WriteLine("Idade do Aluno: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Matéria Favorita do Aluno: ");
            var materiaFavorita = Console.ReadLine();

            Console.WriteLine("Código de Matrícula do Aluno:");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a Nota 1 desse aluno: ");
            var nota01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Nota 2 desse aluno: ");
            var nota02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Nota 3 desse aluno: ");
            var nota03 = Convert.ToDouble(Console.ReadLine());

            servicoDosAlunos.AdicionarAluno(nome, idade, materiaFavorita, codigoMatricula, nota01, nota02, nota03);
        }
        private void EditarNotasAlunos()
        {
            ApresentarAlunos();

            Console.WriteLine("Código do aluno desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nota 1: ");
            var nota01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            var nota02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
            var nota03 = Convert.ToDouble(Console.ReadLine());

            var alterado = servicoDosAlunos.EditarNotasAluno(codigo, nota01, nota02, nota03);

            if (alterado == false)
            {
                Console.WriteLine("O aluno digitado não existe.");
            }
            else if (alterado == true)
            {
                Console.WriteLine("Notas do aluno alterado com sucesso.");
            }
        }
        private void ApagarAluno()
        {
            ApresentarAlunos();

            Console.WriteLine("Digite o código do aluno a ser apagado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var alunoApagado = servicoDosAlunos.Apagar(codigo);

            Console.WriteLine(alunoApagado == true
                ? "Aluno apagado com sucesso."
                : "Nenhum aluno cadastrado com esse código.");
        }
        private void AlunosAprovados()
        {
            
            //var media = (nota01 + nota02 + nota03) / 3;
        }
        private void ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"Menu
1 - Apresentar Alunos
2 - Cadastrar Alunos
3 - Editar Notas dos Alunos
4 - Apagar Alunos
5 - Apresentar Alunos Aprovados
Informe a ação desejada: ");
            //int acaoDesejada = SolicitarCodigo();
        }
    }
}
// CTRL + SHIFT + ESPAÇO