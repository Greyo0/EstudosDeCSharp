using System;

namespace FixacaoConstrutores;

class Program
{

    static public void Main(string[] args)
    {

        double deposito, saque;

        System.Console.WriteLine("Digite o nome do titular");
        string nome = Console.ReadLine();
        System.Console.WriteLine("Qual será o número de identificação do títular?");
        int numero = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Haverá depósito inicial? (s/n)");
        string ver = Console.ReadLine();
        double valor;
        if (ver == "s")
        {
            System.Console.WriteLine("Digite o valor do depósito inicial");
            valor = double.Parse(Console.ReadLine());
        }
        else
        {
            valor = 0;
        }

        Banco b = new Banco(numero, valor, nome);
        System.Console.WriteLine($"{b.ToString()}");

        System.Console.WriteLine("Entre um valor para depósito");
        b.Deposito(deposito = double.Parse(Console.ReadLine()));
        System.Console.WriteLine($"{b.ToString()}");

        System.Console.WriteLine("Entre um valor para saque");
        b.Saque(saque = double.Parse(Console.ReadLine()));
        System.Console.WriteLine($"{b.ToString()}");


    }




}