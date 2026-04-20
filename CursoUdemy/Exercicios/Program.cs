using System;
using System.Security.Cryptography;

namespace execs
{

    class Program
    {

        static void Main(string[] args)
        {

            //Exec1();
            //Exec2();
            //Exec3();
            //Exec4();
            //Exec5();
            Exec6();

        }


        public static void Exec1() {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;


            Console.WriteLine($"SOMA = {soma}");
        }

        public static void Exec2() { 
        
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double area = pi * (Math.Pow(raio, 2));

            Console.WriteLine($"A = {area}");
        }

        public static void Exec4() {

            int funNum = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());

            double salario = horas * valor;


            Console.WriteLine($"NUMBER = {funNum}");
            Console.WriteLine($"SALARY = {salario}");

        }

        public static void Exec3() {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);

            Console.WriteLine($"DIFERENCA = {diferenca}");

        }

        public static void Exec5 ()
        {

            int codigoPeca1 = int.Parse(Console.ReadLine());
            int qtdPeca1 = int.Parse(Console.ReadLine());
            decimal valorPeca1 = decimal.Parse(Console.ReadLine());

            int codigoPeca2 = int.Parse(Console.ReadLine());
            int qtdPeca2 = int.Parse(Console.ReadLine());
            decimal valorPeca2 = decimal.Parse(Console.ReadLine());

            decimal valorAPagar = (qtdPeca1 * valorPeca1) + (qtdPeca2 * valorPeca2);

            Console.WriteLine($"VALOR A PAGAR: {valorAPagar}");

        }

        public static void Exec6 ()
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double trianguloRet = (a * c) / 2;
            double circulo = 3.14159 * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine($"TRIANGULO: {trianguloRet.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");

        }

    }
}