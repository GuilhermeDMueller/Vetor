using OrientacaoObjetosExercicios.Exercicio01;
using OrientacaoObjetosExercicios.Exercicio02;
using OrientacaoObjetosExercicios.Exercicio03;
using OrientacaoObjetosExercicios.Exercicio04;
using OrientacaoObjetosExercicios.Exercicio05;

Console.Write(@"Infome a Ação: 
1 | ExercicioLivro
2 | ExercícioTemperatura
3 | ExercícioAscii
4 | ExercícioFármacia
5 | ExercícioBoletimEscolar");

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
else if (numeroFuncao == 4)
{
    ExemploFarmacia linkExercicio = new ExemploFarmacia();
    linkExercicio.Executar();
}
else if (numeroFuncao == 5)
{
    ExemplosBoletim neoExercicie = new ExemplosBoletim();
    neoExercicie.Executar();
}