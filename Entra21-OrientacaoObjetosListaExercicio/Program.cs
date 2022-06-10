using Entra21_OrientacaoObjetosListaExercicio;

Console.WriteLine(@"Menu: 
1 - Exercicio01

");
var numeroMenu = Convert.ToInt32(Console.ReadLine());

if (numeroMenu == 1)
{
    Triangulo newExercicio = new Triangulo();
    newExercicio.Executar();
}