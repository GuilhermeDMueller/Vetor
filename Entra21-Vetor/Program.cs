﻿using Entra21_Vetor;

Console.WriteLine(@" Ação
1 | Atividade01
2 | Atividade02
");
Console.WriteLine("Informe a ação: ");
int numeroAcao = Convert.ToInt32(Console.ReadLine());

if (numeroAcao == 1)
{
    VetorExercicio01 newExercicio = new VetorExercicio01();
    newExercicio.Executar();
}
else if (numeroAcao == 2)
{
    VetorExercicio02 nesExercicio = new VetorExercicio02();
    nesExercicio.Executar();
}

Console.Clear();