using Entra21_OrientacaoObjetosListaExercicio.Questao01;
using Entra21_OrientacaoObjetosListaExercicio.Questao02;

Console.WriteLine(@"Menu: 
1 - Questão01
2 - Questão02
Informe o código desejado: ");
var codigoDesejado = Convert.ToInt32(Console.ReadLine());

if (codigoDesejado == 1)
{
    TrianguloControlador newExercicio = new TrianguloControlador();
    newExercicio.GerenciarMenu();
}
else if (codigoDesejado == 2)
{
    ControladorDeAlunos wenExercicio = new ControladorDeAlunos();
    wenExercicio.GerenciarCodigo();
}