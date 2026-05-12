using System;
using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {

        int idades = 0;
        double media;
        int count = 0;
        int input;

        input = int.Parse(Console.ReadLine());

        while (input >= 0)
        {
            idades += input;
            count++;
            input = int.Parse(Console.ReadLine());

        } 

        media = (double)idades / count;

        System.Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

    }
}