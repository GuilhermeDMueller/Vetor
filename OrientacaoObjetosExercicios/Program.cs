using OrientacaoObjetosExercicios.Exercicio01;

Console.Write(@"Infome a Ação: 
1 | ExercicioLivro

");

int numeroFuncao = Convert.ToInt32(Console.ReadLine());

if (numeroFuncao == 1)
{
    ExemploLivro newExercicio = new ExemploLivro();
    newExercicio.Executar();
}
