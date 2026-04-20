using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosFixacao_Classes
{
    internal class Aluno
    {

        public string nome;
        public double n1, n2, n3;
        public double nota_final;

        public double NotaFinal()
        {
            nota_final = (n1 + n2 + n3)/3;
            return nota_final;

        }

        public void Aprovado()
        {
            
            if (nota_final >= 6.0)
            {
                System.Console.WriteLine("APROVADO");
            } else
            {
                System.Console.WriteLine("REPROVADO");
                System.Console.WriteLine($"Faltam {(6 - nota_final).ToString("F2")} pontos");
            }

        }

    }
}
