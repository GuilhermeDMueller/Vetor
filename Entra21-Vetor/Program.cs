﻿using Entra21_Vetor;

Console.WriteLine(@" Ação
1 | Atividade01
2 | Atividade02
3 | Atividade1
4 | Atividade2
5 | Atividade3
6 | Atividade4
7 | Atividade5
8 | Atividade6
9 | Atividade7

20| ExemploProfessor
");

Console.WriteLine("Informe a ação: ");
int numeroAcao = Convert.ToInt32(Console.ReadLine());

Console.Clear();
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
else if (numeroAcao == 3)
{
    VetorExercicio1 ninExercicio = new VetorExercicio1();
    ninExercicio.Executar();
}
else if (numeroAcao == 4)
{
    VetorExercicio2 nonaExercicio = new VetorExercicio2();
    nonaExercicio.Executar();
}
else if (numeroAcao == 5)
{
    VetorExercicio3 noonExercicio = new VetorExercicio3();
    noonExercicio.Executar();
}
else if (numeroAcao == 6)
{
    VetorExercicio4 moonExercicio = new VetorExercicio4();
    moonExercicio.Executar();
}
else if (numeroAcao == 6)
{
    VetorExercicio5 chinelaCantouExercicio = new VetorExercicio5();
    chinelaCantouExercicio.Executar();
}
else if (numeroAcao == 7)
{
    VetorExercicio5 dialogoExercicio = new VetorExercicio5();
    dialogoExercicio.Executar();
}
else if (numeroAcao == 8)
{
    VetorExercicio6 beisebolExercicio = new VetorExercicio6();
    beisebolExercicio.Executar();
}
else if (numeroAcao == 9)
{
    VetorExercicio7 ultimoExercicio = new VetorExercicio7();
    ultimoExercicio.Executar();
}






else if (numeroAcao == 20)
{
    ExemploProfessor madExemplo = new ExemploProfessor();
    madExemplo.Executar();
}