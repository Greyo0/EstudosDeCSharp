using System;

public class Program
{

    public static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int fat = n;

        for (int i = n - 1; i > 0; i--)
        {
            fat *= i;
        }

        System.Console.WriteLine(fat);

    }


}