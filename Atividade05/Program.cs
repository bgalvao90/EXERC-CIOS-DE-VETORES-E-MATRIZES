﻿string[] vetor = new string[10];

double[,] nota = new double[10, 3];

double[] soma = new double[10];

double[] media = new double[10];

for ( int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Digite o nome do aluno e sua nota: ");
    vetor[i] = Console.ReadLine();
    for (int j = 0; j < 3; j++)
    {
       
        nota[i, j] = double.Parse(Console.ReadLine());
        soma[i] += nota[i, j];
    }
    media[i] = soma[i] / 3;
    
}
for (int i = 0; i < 10; i++)
{
if (media[i] <= 10 && media[i] >=7 )
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Aluno {vetor[i]} está com a média {media[i].ToString("F2")}! Aprovado");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aluno {vetor[i]} está com a média {media[i].ToString("F2")}! Reprovado");
}
Console.ResetColor();
}