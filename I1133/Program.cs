using System;

public class Program
{
    
    public static void Main(string[] args)
    {
        int i = int.Parse(Console.ReadLine()); 
        int j = int.Parse(Console.ReadLine()); 

        if (i < j)
        {
            for (int n = i+1; n < j; n++) 
            {
                if (((n%5) == 2) || ((n%5) == 3))
                {
                    System.Console.WriteLine(n);
                }
            }
        } else
        {
            for (int n = j+1; n < i; n++)
            {
                if (((n%5) == 2) || ((n%5) == 3))
                {
                    System.Console.WriteLine(n);
                }
            }
        }
    }

}