using System;

public class Program
{

    public static void Main(string[] args)
    {
        
        int n = int.Parse(Console.ReadLine());
        int[] vet = new int[n];

        vet[0] = 0;
        vet[1] = 1;

        for (int i = 2; i < n; i++)
        {

            vet[i] = vet[i-1] + vet[i-2]; 

        }

        for (int i = 0; i < n; i++)
        {
            
            if (i == n - 1)
            {
                Console.WriteLine(vet[i]);
            } else
            {
                Console.Write($"{vet[i]} ");
            }

        }
        

    }
}
