using System;

public class Program
{

    public static void Main(string[] args)
    {
        string[] entradaMatriz = Console.ReadLine().Split(' ');
        int linha = entradaMatriz[0];

        int coluna = entradaMatriz[1];

        int[,] matriz = new int[linha, coluna];

        for (int i = 0; i < linha; i++)
        {
            string[] entradaLinha = Console.ReadLine().Split(' ');
            for (int j = 0; j < coluna; j++)
            {
                matriz[i, j] = entradaLinha[j];
            }
        }

        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                if (matriz [i, j] == x)
                {
                    Console.WriteLine($"Position {i+1}, {j+1}: ");
                    if (matriz [i, j-1])
                    {
                        Console.WriteLine($"Left: {matriz[i, j-1]}");
                    }
                    if (matriz [i, j+1])
                    {
                        Console.WriteLine($"Right: {matriz[i, j+1]}");
                    }
                    if (matriz [i-1, j])
                    {
                        Console.WriteLine($"Down: {matriz[i-1, j]}");
                    }
                    if (matriz [i+1, j])
                    {
                        Console.WriteLine($"Up: {matriz[i+1, j]}");
                    }
                    
                }
            }
        }

    }


}