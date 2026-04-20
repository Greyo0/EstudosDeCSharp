using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosFixacao_Classes
{
    public class Retangulo
    {
        
        public double ladoA;
        public double ladoB;

        public double Area()
        {
            return ladoA * ladoB;            
        }

        public double Perimetro()
        {
            return (ladoA * 2) + (ladoB * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt((ladoA * ladoA) + (ladoB * ladoB));
        }

    }
}
