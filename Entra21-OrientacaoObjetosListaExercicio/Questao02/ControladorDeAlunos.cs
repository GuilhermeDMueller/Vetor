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

            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarSolicitarMenu();
                Console.Clear();

                if (codigo == 1)
                {
                    ApresentarAlunos();
                }
                else if (codigo == 2)
                {
                    CadastrarAluno();
                }
            }
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
        }
    }
}
// CTRL + SHIFT + ESPAÇO