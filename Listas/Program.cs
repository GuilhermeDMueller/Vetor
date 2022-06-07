using Entra21___Listas.ListasExercicio;
using Listas.ListasExercicio;

Console.WriteLine(@"Informe a Ação Desejada: 
1 | ListaExercicio01
2 | ListaExercicio02
3 | ListaExercicio03");

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