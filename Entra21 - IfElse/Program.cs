using Entra21___IfElse;

Console.WriteLine(@"Informe a ação: 
1 | Atividade01
2 | Atividade02
3 | Atividade03

");
int numeroAcao = Convert.ToInt32(Console.ReadLine());

Console.Clear();
if (numeroAcao == 1)
{
    IfElseExercicie01 newExercicio = new IfElseExercicie01();
    newExercicio.Executar();
}
else if (numeroAcao == 2)
{
    IfElseExercicie02 wenExercicio = new IfElseExercicie02();
    wenExercicio.Executar();
}
else if (numeroAcao == 3)
{
    IfElseExercicie03 oldExercicio = new IfElseExercicie03();
    oldExercicio.Executar();
}