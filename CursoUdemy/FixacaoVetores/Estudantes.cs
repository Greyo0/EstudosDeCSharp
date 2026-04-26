using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{

    // Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N
    // representando o numero de estudantes que vão alugar quartos (N pode ser de 1 a 10).
    // Em seguida, registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e
    // email do estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido
    // um quarto vago. Ao final, seu programa deve imprimir um relatório de todas ocupações de pensionato
    // por ordem de quarto, conforme exemplo.

    /* 
    
    Rent #1:
    Name: 
    Email:
    Room:

    Busy rooms:
    NumeroDoQuarto: Nome, Email
    
    */

    public class Estudantes
    {

        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudantes(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $" {Nome}, {Email}";
        }


    }
}
