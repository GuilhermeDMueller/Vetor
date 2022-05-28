using OrientacaoObjetosExercicios.Exercicio01;
using OrientacaoObjetosExercicios.Exercicio02;

Console.Write(@"Infome a Ação: 
1 | ExercicioLivro
2 | ExercícioTemperatura

");

int numeroFuncao = Convert.ToInt32(Console.ReadLine());

if (numeroFuncao == 1)
{
    ExemploLivro newExercicio = new ExemploLivro();
    newExercicio.Executar();
}
else if (numeroFuncao == 2)
{
    ExemploTemperatura wenExercicio = new ExemploTemperatura();
    wenExercicio.Executar();
}