using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacaoStatic
{
    class ConversorDeMoeda
    {

        public static double Iof = 6.0;
        public static double Converter(double Cotacao, double Dolares)
        {
            return (Cotacao * Dolares) + (Cotacao * Dolares) * (Iof / 100) ;
        }
    }
}
