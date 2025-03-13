using System;

class Program
{

    static void Main()
    {
        const int linha = 3, coluna = 5;
        int[,] numero = new int[5, 3];
        int soma = 0;
        int i, j;


        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 3; j++)
            {
                telaInicial();
                Console.SetCursorPosition(9, 3);
                numero[i, j] = int.Parse(Console.ReadLine());
            }
        }



        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 3; j++)
            {
                soma = soma + numero[i, j];
            }
            Console.Clear();
            Console.WriteLine($"A soma da linha {i + 1} é {soma}");

        }
    } 

    private static void telaInicial()
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║        Vetor de Números        ║");
        Console.WriteLine("╠════════════════════════════════╣");
        Console.WriteLine("║ Número:                        ║");
        Console.WriteLine("╚════════════════════════════════╝");
    }

    private static void telaNumero()
    {
        Console.Clear();
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.WriteLine("║                  Números              ║ Soma ║");
        Console.WriteLine("╠═══════╦═══════╦═══════╦═══════╦═══════╣══════╣");
        Console.WriteLine("║       ║       ║       ║       ║       ║      ║");
        Console.WriteLine("╠═══════╬═══════╬═══════╬═══════╬═══════╣══════╣");
        Console.WriteLine("║       ║       ║       ║       ║       ║      ║");
        Console.WriteLine("╠═══════╬═══════╬═══════╬═══════╬═══════╣══════╣");
        Console.WriteLine("║       ║       ║       ║       ║       ║      ║");
        Console.WriteLine("╚═══════╩═══════╩═══════╩═══════╩═══════╝══════╝");
    }

}
