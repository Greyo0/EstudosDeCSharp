/* using System;

public class Program
{
    
    public static void Main(string[] args)
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        int codigo = int.Parse(Console.ReadLine());
        do
        {
            if (codigo == 1)
            {
                alcool++;
            } else if (codigo == 2)
            {
                gasolina++;
            } else if (codigo == 3)
            {
                diesel++;
            }

            codigo = int.Parse(Console.ReadLine());
            
        } while (codigo != 4);

        System.Console.WriteLine("MUITO OBRIGADO");
        System.Console.WriteLine($"Alcool: {alcool}");
        System.Console.WriteLine($"Gasolina: {gasolina}");
        System.Console.WriteLine($"Diesel: {diesel}");

    }


} */