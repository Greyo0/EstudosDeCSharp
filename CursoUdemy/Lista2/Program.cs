using System;

namespace Lista2;
class Program
{

    static void Main(string[] args)
    {

        //Exec1();
        //Exec2();
        //Exec3();
        //Exec4();
        //Exec5();
        //Exec6();
        //Exec7();
        Exec8();

    }

    public static void Exec1()
    {

        int num = int.Parse(Console.ReadLine());

        if (num >= 0)
        {
            Console.WriteLine("POSITIVO");
        } else
        {
            Console.WriteLine("NEGATIVO");
        }

    }

    public static void Exec2()
    {

        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("PAR");
        } else
        {
            Console.WriteLine("ÍMPAR");
        }

    }

    public static void Exec3() {

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("MÚLTIPLOS");
        } else
        {
            Console.WriteLine("NÃO SÃO MÚLTIPLOS");
        }

    }

    public static void Exec4() {


        int horaA = int.Parse(Console.ReadLine());
        int horaB = int.Parse(Console.ReadLine());
        int duracao;

        if (horaA < horaB)
        {

            duracao = horaB - horaA;

        }
        else if (horaA > horaB) {

            duracao = 24 - horaA + horaB;

        } else
        {
            duracao = 24;
        }

        Console.WriteLine($"O JOGO DUROU {duracao} HORAS");

    }


    public static void Exec5() {

        int codigo, qtd;
        double valor;
   
        codigo = int.Parse(Console.ReadLine());
        qtd = int.Parse(Console.ReadLine());

        if (codigo == 1)
        {
            valor = 4.00;
        } else if (codigo == 2)
        {
            valor = 4.50;
        } else if (codigo == 3)
        {
            valor = 5.00;
        } else if (codigo == 4)
        {
            valor = 2.00;
        } else
        {
            valor = 1.50;
        }

        Console.WriteLine($"Total: R$ {valor * qtd}");

    }

    public static void Exec6() {
    
    int num = int.Parse(Console.ReadLine());

    if (num <= 25 && num > 0)
        {
            Console.WriteLine("Intervalo [0,25]");
        } else if (num > 25 && num <= 50)
        {
            System.Console.WriteLine("Intervalo (25,50]");
        } else if (num > 50 && num <= 75)
        {
            System.Console.WriteLine("Intervalo (50,75]");
        } else if (num > 75 && num <= 100)
        {
            System.Console.WriteLine("Intervalo (75,100]");
        } else
        {
            System.Console.WriteLine("Fora de Intervalo");
        }

    } 

    public static void Exec7()
    {

        double x, y;

        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            System.Console.WriteLine("Q1");
        } else if (x > 0 && y < 0)
        {
            System.Console.WriteLine("Q4");
        } else if (x == 0 && y != 0)
        {
            System.Console.WriteLine("Eixo X");
        } else if (x != 0 && y == 0)
        {
            System.Console.WriteLine("Eixo Y");
        } else if (x < 0 && y > 0)
        {
            System.Console.WriteLine("Q2");
        } else if (x < 0 && y < 0)
        {
            System.Console.WriteLine("Q3");
        } else
        {
            System.Console.WriteLine("Origem");
        }

    }

    public static void Exec8()
    {

        /* 
         
         4750

        2000 nao tem imposto (sobra 2750)
        1000 tem imposto de 8% (sobra 1750)
        1500 tem imposto de 18% (sobra 250)
        250 tem imposto de 28% 

        if (renda <= 2000.00)
            imposto = 0;
        else if (renda <= 3000)
            imposto = (renda - 2000) * 0.08;
        else if (renda <= 4500)
            imposto = (1000) * 0.08 + (renda - 3000) * 0.18
        else 
            imposto = (1000) * 0.08 + (1500) * 0.18 + (renda - 4500) * 0.28
         */

        double salario = double.Parse(Console.ReadLine());

        double imposto;

        if (salario <= 2000)
        {
            imposto = 0;
        } else if (salario <= 3000)
        {
            imposto = (salario - 2000) * 0.08;
        } else if (salario <= 4500)
        {
            imposto = (1000) * 0.08 + (salario - 3000) * 0.18;
        } else
        {
            imposto = (1000) * 0.08 + (1500) * 0.18 + (salario - 4500) * 0.28;
        }

        Console.WriteLine($"R$ {imposto}");

    }

}