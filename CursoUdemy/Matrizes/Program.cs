using System;

namespace Udemy;

public class Program
{
    
 public static void Main(string[] args)
    {
        /* Fazer um programa para ler um número inteiro N e uma matriz de ordem N 
        contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade
        de valores negativos da matriz */
        
        int n = int.Parse(Console.ReadLine());
        int[,] matriz = new int[n,n];
        int negativos = 0;

        for (int i = 0; i<n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            for (int j = 0; j<n; j++)
            {
                matriz[i,j] = int.Parse(entrada[j]);
            }
        }

        System.Console.Write("Diagonal principal: ");

        for (int i = 0; i<n; i++)
        {
            Console.Write(matriz[i,i] + " ");
        }

        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<n; j++)
            {
                if (matriz[i,j] < 0)
                {
                    negativos++;
                }
            }
        }

        System.Console.WriteLine($"Quantidade de numeros negativos: {negativos}");

    }


}