using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioDeFixacaoConstrutoresThisSobrecargaEncap
{
    class Contas
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        double Taxa = 5.00;

        public Contas(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Contas(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Depositar(depositoInicial);
        }


        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + Taxa;
        }

        public override string ToString()
        {
            return "Conta " + Numero 
                + ", Titular: " + Titular 
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
