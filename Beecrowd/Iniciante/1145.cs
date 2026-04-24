/* using System;

public class Program
{
    
    public static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');

        int x = int.Parse(entrada[0]);
        int y = int.Parse(entrada[1]);
        int i = 1;
        int j;

        do
        {
            for (j = 1; j<=x; j++)
            {
                if (j != x){
                    System.Console.Write($"{i} ");
                } else
                {
                    Console.Write(i);
                }
                i++;
            }
            Console.WriteLine();
        } while(i < y);
    }

} */