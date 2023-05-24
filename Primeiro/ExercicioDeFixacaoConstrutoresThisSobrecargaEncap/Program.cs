using System;
using System.Globalization;

namespace ExercicioDeFixacaoConstrutoresThisSobrecargaEncap
{
    class Program
    {
        static void Main(string[] args)
        {
            Contas conta;
            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s/n)? ");
            string saldoInicial = Console.ReadLine();


            double valorDeposito;
            if (saldoInicial == "s" || saldoInicial == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Contas(numero, titular, valorDeposito);


            }
            else
            {
                conta = new Contas(numero, titular);

            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
