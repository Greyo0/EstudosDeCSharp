using System;

public class Program
{
    
    public static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        int i = 0;
        for (i = 1; i < n*4; i += 4){
            System.Console.WriteLine($"{i} {i+1} {i+2} PUM");
        }
    }
}
