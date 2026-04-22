/* using System; 
using System.Globalization; 
public class Program { 
    public static void Main(string[] args){ 
        int codigo = 1; 
        while (codigo == 1) { 
            double n1 = -1.0; 
            double n2 = -1.0; 
            while (n1 < 0 || n1 > 10){ 
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                if (n1 < 0 || n1 > 10) { 
                    System.Console.WriteLine("nota invalida"); 
                } 
            } 
            while (n2 < 0 || n2 > 10){ 
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                if (n2 < 0 || n2 > 10) { 
                    System.Console.WriteLine("nota invalida"); 
                } 
            } 
            double media = (n1 + n2)/2; 
            System.Console.WriteLine($"media = {media.ToString("F2")}"); 
            System.Console.WriteLine("novo calculo (1-sim 2-nao)"); 
            codigo = int.Parse(Console.ReadLine()); 
            if (codigo != 1 && codigo != 2) { 
                while(codigo != 1 && codigo != 2){ 
                    System.Console.WriteLine("novo calculo (1-sim 2-nao)"); 
                    codigo = int.Parse(Console.ReadLine()); 
                } 
            } 
        } 
    } 
} */