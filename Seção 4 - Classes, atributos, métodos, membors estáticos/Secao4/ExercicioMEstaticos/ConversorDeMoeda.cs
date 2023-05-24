using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMEstaticos
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double Conversor(double cotacao, double valor)
        {
            double valorTotal = cotacao * valor;
            return valorTotal += valorTotal * IOF;
        }
    }
}
