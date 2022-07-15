using Entra21___Listas.ListasExercicio;
using Entra21_Listas.ListasExercicio;
using Listas.ListasExercicio;

Console.WriteLine(@"Informe a Ação Desejada: 
1 | ListaExercicio01
2 | ListaExercicio02
3 | ListaExercicio03
4 | ListaExercicio01-2
5 | ListaExercicio02-2
6 | ListaExercicio03-2");

var acaoDesejada = Convert.ToInt32(Console.ReadLine());
if (acaoDesejada == 1)
{
    ListaExercicio01 newExercicie = new ListaExercicio01();
    newExercicie.Executar();
}
else if (acaoDesejada == 2)
{
    ListaExercicio02 wenExercicie = new ListaExercicio02();
    wenExercicie.Executar();
}
else if (acaoDesejada == 3)
{
    ListaExercicio03 oldExercicie = new ListaExercicio03();
    oldExercicie.Executar();
}
else if (acaoDesejada == 4)
{
    ExerciceList1 dloExercice = new ExerciceList1();
    dloExercice.Executar();
}