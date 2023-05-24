using System;
using System.Globalization;

namespace ExercicioDeFixacaoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares voicê vai comprar? ");
            double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " +ConversorDeMoeda.Converter(Dolar, Valor).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
