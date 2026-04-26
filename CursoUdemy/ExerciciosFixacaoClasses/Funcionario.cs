using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosFixacao_Classes
{
    internal class Funcionario
    {

        public string nome;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto += (salarioBruto / porcentagem);
        }

    }
}
