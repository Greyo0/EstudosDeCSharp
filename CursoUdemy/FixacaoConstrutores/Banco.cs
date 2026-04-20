using System;
using System.Globalization;

namespace FixacaoConstrutores;

public class Banco
{
    
    public string Titular {get; set;}
    public double Valor {get; private set;}
    public int Numero {get; private set;}

    public Banco (int numero, double valor, string titular)
    {
        Valor = valor;
        Numero = numero;
        Titular = titular;
    }

    public override string ToString ()
    {
        return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $" + Valor;
    }

    public void Deposito (double deposito)
    {
        Valor += deposito;
    }

    public void Saque (double saque)
    {
        Valor -= saque + 5;
    }


}