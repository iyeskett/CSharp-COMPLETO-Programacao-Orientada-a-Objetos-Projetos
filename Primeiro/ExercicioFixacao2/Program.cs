using System;
using System.Globalization;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: "+func);
            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            func.AumentarSalario(porc);

            Console.WriteLine("Dados atualizados: "+ func);
        }
    }
}
