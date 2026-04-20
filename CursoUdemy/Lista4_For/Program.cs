using System;

namespace Lista4;

class Program
{
    
    static void Main (string[] args)
    {
        
        //Exec1();
        Exec2();

    }

    public static void Exec1()
    {
        
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (i%2 != 0)
            {
                System.Console.WriteLine(i);
            }
        }
        
    }


    public static void Exec2()
    {
        
        int dentro = 0, fora = 0;
        int n = int.Parse(Console.ReadLine());
        int num;

        for (int i = 1; i <= n; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (num >= 10 && num <= 20)
            {
                dentro++;
            } else
            {
                fora++;
            }
        }

        System.Console.WriteLine($"{dentro} in");
        System.Console.WriteLine($"{fora} out");

    }
    
}