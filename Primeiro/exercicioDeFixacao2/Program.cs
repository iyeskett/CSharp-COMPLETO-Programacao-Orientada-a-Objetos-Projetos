using System;
using System.Globalization;

namespace exercicioDeFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o seu último nome, idade e altura(mesma linha)");
            string[] s = Console.ReadLine().Split(' ');
            string ultimoNome = s[0];
            int idade = int.Parse(s[1]);
            double altura = double.Parse(s[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
