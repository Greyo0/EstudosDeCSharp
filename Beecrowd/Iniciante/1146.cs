/* using System;

public class Program
{
    public static void Main(string[] args)
    {
        string linha;

        while ((linha = Console.ReadLine()) != null)
        {
            int x = int.Parse(linha);

            if (x == 0)
                break;

            int[] numeros = new int[x];

            for (int i = 0; i < x; i++)
            {
                numeros[i] = i + 1;
            }

            Console.WriteLine(string.Join(" ", numeros));
        }
    }
} */