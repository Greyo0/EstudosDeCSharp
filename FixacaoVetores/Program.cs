using CursoUdemy;
using FixacaoVetores;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Udemy;

class Program
{
    static void Main(string[] args)
    {
        FixacaoVetores();
    }

    static void FixacaoVetores()
    {

        Estudantes[] quartos = new Estudantes[10];
        int busy = 0;

        System.Console.Write("How many rooms will be rented?: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            System.Console.Write("Name: ");
            string nome = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Room: ");
            int quarto = int.Parse(Console.ReadLine());

            if (quartos[quarto - 1] == null)
            {
                quartos[quarto - 1] = new Estudantes(nome, email);
                busy++;
            }
            else
            {
                System.Console.WriteLine("Error: This room is already in use");
            }
        }

        System.Console.WriteLine($"Busy rooms: {busy}");

        for (int i = 0; i < 10; i++)
        {
            if (quartos[i] != null)
            {
                System.Console.WriteLine($"{i + 1}: {quartos[i].ToString()}");
            }
        }



    }

}