using OrientacaoObjetosExercicios.Exercicio01;
using OrientacaoObjetosExercicios.Exercicio02;
using OrientacaoObjetosExercicios.Exercicio03;

Console.Write(@"Infome a Ação: 
1 | ExercicioLivro
2 | ExercícioTemperatura
3 | ExercícioAscii

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
else if (numeroFuncao == 3)
{
   ExemploCodigoAscii noeExercicio = new ExemploCodigoAscii();
    noeExercicio.Executar();
}