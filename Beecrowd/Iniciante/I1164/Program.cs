using System;

public class Program
{
    
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = 1; j < num; j++)
            {
                if (num%j == 0)
                {
                    sum += j;
                }
            }
            if (sum == num)
            {
                Console.WriteLine($"{num} eh perfeito");
            } else
            {
                Console.WriteLine($"{num} nao eh perfeito");
            }
        }
    }

    
}