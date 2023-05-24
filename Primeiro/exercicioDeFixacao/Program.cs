using System;
using System.Globalization;

namespace exercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine();

            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine();

            Console.WriteLine("Medida com oito casa decimais: {0:F8}",medida);
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador de decimal invariant culture: "+ medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
