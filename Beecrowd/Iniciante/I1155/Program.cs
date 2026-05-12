using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        double soma = 1;

        for (int i = 2; i<=100; i++)
        {
            soma += (double)1/i;
        }

        Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

    }
}