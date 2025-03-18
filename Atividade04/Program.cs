using System;

class Program
{

    static void Main()
    {
        int[,] vetor = {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11,12,13,14,15 },
            { 16,17,18,19,20 },
            { 21,22,23,24,25 }
            };

        Console.WriteLine("Diagolnal Principal");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{vetor[i, i]}");
        }
        Console.WriteLine();
        Console.WriteLine("Diagolnal Secundaria");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{vetor[i, 4 - i]}");
        }

    }
}﻿
