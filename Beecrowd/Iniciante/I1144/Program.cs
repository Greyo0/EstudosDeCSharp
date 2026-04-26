using System;

public class Program
{

    public static void Main(string[] args)
    {

        int i;
        int n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            System.Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            System.Console.WriteLine($"{i} {(Math.Pow(i, 2))+1} {(Math.Pow(i, 3))+1}");
        }

    }

} 