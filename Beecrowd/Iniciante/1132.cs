/* using System;

public class Program
{
    
    public static void Main(string[] args)
    {
        int i = int.Parse(Console.ReadLine()); 
        int j = int.Parse(Console.ReadLine()); 
        int soma = 0;

        if (i < j)
        {
            for (int n = i; n <= j; n++) 
            {
                if ((n%13) != 0)
                {
                    soma = soma + n;
                }
            }
        } else
        {
            for (int n = j; n <= i; n++)
            {
                if (n%13 != 0)
                {
                    soma += n;
                }
            }
        }

        System.Console.WriteLine($"{soma}");
    }

} */ 