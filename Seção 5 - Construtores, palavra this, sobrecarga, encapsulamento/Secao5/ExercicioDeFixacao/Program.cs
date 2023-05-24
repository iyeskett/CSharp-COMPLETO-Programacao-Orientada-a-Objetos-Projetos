using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numero, nome, valorInicial);
            }
            else
            {
                contaBancaria = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantia);
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(quantia);
            Console.WriteLine(contaBancaria);

        }
    }
}
