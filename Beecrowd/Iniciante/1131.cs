/* using System;

namespace Beecrowd {
    public class Program {
        
        public static void Main(string[] args)
        {
            int golsInter, golsGremio;
            int inter = 0;
            int empate = 0;
            int gremio = 0;
            int codigo = 1;
            int grenal = 0;

            while (codigo == 1)
            {
                grenal++;

                string entrada = Console.ReadLine();
                string[] partes = entrada.Split(' ');

                golsInter = int.Parse(partes[0]);
                golsGremio = int.Parse(partes[1]);

                if (golsInter > golsGremio)
                {
                    inter++;
                } else if (golsGremio > golsInter)
                {
                    gremio++;
                } else
                {
                    empate++;
                }

                do
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    codigo = int.Parse(Console.ReadLine());
                }
                while (codigo != 1 && codigo != 2);
            }

            System.Console.WriteLine($"{grenal} grenais");
            System.Console.WriteLine($"Inter:{inter}");
            System.Console.WriteLine($"Gremio:{gremio}");
            System.Console.WriteLine($"Empates:{empate}");

            if (inter > gremio)
            {
                System.Console.WriteLine("Inter venceu mais");
            } else if (gremio > inter)
            {
                System.Console.WriteLine("Gremio venceu mais");
            } else
            {
                System.Console.WriteLine("Nao houve vencedor");
            }

        }

    }
} */