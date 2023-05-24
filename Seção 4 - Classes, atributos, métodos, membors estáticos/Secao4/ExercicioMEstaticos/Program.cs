using System;
using System.Globalization;

namespace ExercicioMEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("QUantos dólares você vai comprar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Conversor(cotacao, valor).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
