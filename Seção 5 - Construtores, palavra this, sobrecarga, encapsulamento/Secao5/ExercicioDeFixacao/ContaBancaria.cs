using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioDeFixacao
{
    class ContaBancaria
    {
        private static double Taxa = 5.00;
        private bool Atualizou;
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Atualizou = false;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
            Atualizou = false;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
            Atualizou = true;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + Taxa;
            Atualizou = true;

        }

        public override string ToString()
        {
            if (!Atualizou)
            {
                return "Dados da conta:"
                    + "\nConta " + Numero
                    + ", Titular: " + Titular
                    + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
            }
            return "Dados da conta atualizados:"
                    + "\nConta " + Numero
                    + ", Titular: " + Titular
                    + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
