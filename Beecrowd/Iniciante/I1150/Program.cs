using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        int x = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int vezes = 1;
        int sum = 0;

        while (z <= x)
        {
            z = int.Parse(Console.ReadLine());
        }

        sum = x;

        do
        {
            
            sum += (x + vezes);
            vezes++;
    
        } while(sum <= z);

        Console.WriteLine(vezes);
    }

}