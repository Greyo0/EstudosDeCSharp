using System;

namespace Lista3;

class Program
{

    static void Main(string[] args)
    {
        //Exec1();
        Exec2();
        //Exec3();
    }

    public static void Exec1()
    {

        int senha = int.Parse(Console.ReadLine());

        while (senha != 2002)
        {
            System.Console.WriteLine("Senha Inválida");
            senha = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Acesso Permitido");

    }

    public static void Exec2()
    {

        string[] valores = Console.ReadLine().Split(' ');  
        int x = int.Parse(valores[0]);
        int y = int.Parse(valores[1]);

        while (x != 0 && y != 0)
        {
            if (x > 0 && y > 0)
            {
                System.Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                System.Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                System.Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                System.Console.WriteLine("Q3");
            }

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        }

    }

    public static void Exec3 ()
    {
        
        int codigo = int.Parse(Console.ReadLine());
        int alcool = 0, gasolina = 0, diesel = 0;

        while (codigo != 4)
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
        }

        System.Console.WriteLine("MUITO OBRIGADO");
        System.Console.WriteLine($"Alcool: {alcool}");
        System.Console.WriteLine($"Gasolina: {gasolina}");
        System.Console.WriteLine($"Diesel: {diesel}");


    }


}