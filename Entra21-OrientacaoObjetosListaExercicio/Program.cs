using Entra21_OrientacaoObjetosListaExercicio.Questao01;

Console.WriteLine(@"Menu: 
1 - Questão01

Informe o código desejado: ");
var codigoDesejado = Convert.ToInt32(Console.ReadLine());

if (codigoDesejado == 1)
{
    TrianguloControlador newExercicio = new TrianguloControlador();
    newExercicio.GerenciarMenu();
}