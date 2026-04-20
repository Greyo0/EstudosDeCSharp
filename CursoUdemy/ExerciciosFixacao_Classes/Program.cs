using System;
using ExerciciosFixacao_Classes;

namespace ExercicioFixacao_Classes
{

    class Program
    {

        static public void Main (string[] args)
        {
            
            //Exec1();
            //Exec2();
            Exec3();
        }

        static public void Exec1()
        {

            Retangulo r = new Retangulo();
        
            System.Console.WriteLine("Entre a altura e a largura do retângulo: ");
            r.ladoA = double.Parse(Console.ReadLine());
            r.ladoB = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"ÁREA = {r.Area()}");
            System.Console.WriteLine($"PERIMETRO = {r.Perimetro()}");
            System.Console.WriteLine($"DIAGONAL = {r.Diagonal()}");

        }

        static public void Exec2()
        {
            
            Funcionario f = new Funcionario();

            System.Console.WriteLine("Nome:");
            f.nome = Console.ReadLine();
            System.Console.WriteLine("Salário bruto:");
            f.salarioBruto = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Imposto:");
            f.imposto = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"Funcionario: ${f.nome}, $ {f.SalarioLiquido()}");

            System.Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);

            System.Console.WriteLine($"Dados atualizados: {f.nome}, {f.SalarioLiquido()}");

        }

        static public void Exec3()
        {
            
            Aluno a = new Aluno();

            System.Console.WriteLine("Digite o nome do aluno");
            a.nome = Console.ReadLine();

            System.Console.WriteLine("Digite as três notas do aluno:");
            a.n1 = double.Parse(Console.ReadLine());
            a.n2 = double.Parse(Console.ReadLine());
            a.n3 = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"NOTA FINAL = {a.NotaFinal().ToString("F2")}");
            a.Aprovado();

        }

    }


}