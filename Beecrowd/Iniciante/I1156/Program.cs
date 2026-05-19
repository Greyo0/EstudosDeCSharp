using System;
using System.Globalization; 

public class Program
{

    public static void Main(string[] args)
    {

        int num = 1;
        double sum = 0;

        for (int i = 1; i <=39; i += 2)
        {
            sum += (double)i / num; 
            num *= 2;
        }

        Console.WriteLine(sum.ToString("F2"), CultureInfo.InvariantCulture);

    } 

}