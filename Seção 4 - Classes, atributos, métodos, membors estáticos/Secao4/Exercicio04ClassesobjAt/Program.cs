using System;
using System.Globalization;

namespace Exercicio04ClassesobjAt
{
    class Program
    {
        static void Main(string[] args)
        {
            // objeto
            Funcionario funcionario = new Funcionario();


            // atributos
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(funcionario);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(funcionario);
        }
    }
}
