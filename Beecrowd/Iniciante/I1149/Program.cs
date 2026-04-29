using System;

public class Program
{

    public static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(' ');

        int a = int.Parse(entrada[0]);
        int n;
        int sum = 0;

        for (int i = 1; i < entrada.Length(); i++)
        {
            if (entrada[i] > 0)
            {
              n = int.Parse(entrada[i]);
              break;  
            }
        }

        for (int i = 0; i < n; i++)
        {
            sum += a + i;
        }

        Console.WriteLine(sum);

    }

}