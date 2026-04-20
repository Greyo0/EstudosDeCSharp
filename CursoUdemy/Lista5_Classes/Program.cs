using System;

namespace Lista5_Classes;

class Program
{
    public static void Main (string[] args)
    {
        //Exec1();
        Exec2();
    }

    public static void Exec1()
    {
        Console.WriteLine("Digite o nome e então a idade da primeira pessoa");
        Pessoas p1 = new Pessoas();

        Console.WriteLine("");
        Console.WriteLine("Agora faça o mesmo para a segunda");
        Pessoas p2 = new Pessoas();

        if (p1.idade > p2.idade)
        {
            Console.WriteLine($"Pessoa mais velha: {p1.nome}");
        } else if (p2.idade > p1.idade)
        {
            Console.WriteLine($"Pessoa mais velha: {p2.nome}");
        } else
        {
            Console.WriteLine("Os dois possuem a mesma idade");
        }
    }

    public static void Exec2() 
    {

        Console.WriteLine("Digite o nome e então o salário do trabalhador");
        Trabalhador t1 = new Trabalhador();

        Console.WriteLine("");
        Console.WriteLine("Agora faça o mesmo para o segundo");
        Trabalhador t2 = new Trabalhador();

        double media = ((t1.salario + t2.salario) / 2);

        Console.WriteLine($"Salário médio: {media}");
    
    }
}