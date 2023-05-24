using System;
using System.Globalization;

namespace Exercicio02ClassesObjAt
{
    class Program
    {
        static void Main(string[] args)
        {
            // objetos
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            // atributos
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("dados do segundo funcionário:");
            // atributos
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salário médio = " + salarioMedio);


        }
    }
}
