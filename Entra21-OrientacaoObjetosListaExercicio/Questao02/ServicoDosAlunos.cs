using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_OrientacaoObjetosListaExercicio.Questao02
{
    internal class ServicoDosAlunos
    {
        private List<Alunos> alunos = new List<Alunos>();
        private int codigoAtual = 1;

        public void AdicionarAluno(string nome, int idade, string materiaFavorita, int codigoMatricula, double nota01, double nota02, double nota03)
        {
            Alunos aluno = new Alunos();
            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.CodigoMatricula = codigoMatricula;
            aluno.Nota01 = nota01;
            aluno.Nota02 = nota02;
            aluno.Nota03 = nota03;

            aluno.Codigo = codigoAtual;

            codigoAtual++;

            alunos.Add(aluno);

        }
        public bool ApagarAluno(int codigo)
        {
            for (int indice = 0; indice < alunos.Count; indice++)
            {
                Alunos aluno = alunos[1];
                if (aluno.Codigo == codigo)
                {
                    alunos.Remove(aluno);

                    return true;
                }
            }
            return false;
        }
        public bool EditarDadosPessoais(int codigoMatriculaParaAlterar, string nome, int idade, string materiaFavorita)
        {
            Alunos alunoParaAlterar = ObterPorCodigo(codigoMatriculaParaAlterar);
            if (alunoParaAlterar == null)
            {
                return false;
            }
            alunoParaAlterar.Nome = nome;
            alunoParaAlterar.Idade = idade;
            alunoParaAlterar.MateriaFavorita = materiaFavorita;
            alunoParaAlterar.CodigoMatricula = codigoMatriculaParaAlterar;

            return true;
        }
        public bool EditarNotasAluno(int codigo, double nota01, double nota02, double nota03)
        {
            Alunos codigos = ObterPorCodigo(codigo);
            if (codigos == null)
            {
                return false;
            }
            codigos.Nota01 = nota01;
            codigos.Nota02 = nota02;
            codigos.Nota03 = nota03;

            return true;
        }
        public List<Alunos> ObterNomesAlunos()
        {
            return alunos;
        }
        //public List<Alunos> ObterMediasAlunos()
        //{
        //    var media = 0.0;
        //    return media;

        //}
        public double ObterMediaPorCodigoMatricula(int codigo, double nota01, double nota02, double nota03)
        {
            var media = 0.0;
            for (int indice = 0; indice < alunos.Count; indice++)
            {
                var mediaAtual = alunos[indice];
                if (mediaAtual.Codigo == codigo)
                {
                    media = (nota01 + nota02 + nota03) / 3;
                }
            }
            return media;
        }
        public Alunos ObterPorCodigo(int codigo)
        {
            for (int indice = 0; indice < alunos.Count; indice++)
            {
                var dadosAlunos = alunos[indice];
                if (dadosAlunos.Codigo == codigo)
                {

                    return dadosAlunos;
                }
            }
            return null;
        }
        public void ObterStatusPorCodigoMatricula(int codigoMatricula)
        {

        }
        public void ObterMediaDasIdades()
        {

        }
        public bool Apagar(int codigo)
        {
            for (int indice = 0; indice < alunos.Count; indice++) ;
            {
                Alunos aluno = alunos[1];
                if(aluno.Codigo == codigo)
                {
                    alunos.Remove(aluno);

                    return true;
                }
            }
            return false;
        }
        
    }
}