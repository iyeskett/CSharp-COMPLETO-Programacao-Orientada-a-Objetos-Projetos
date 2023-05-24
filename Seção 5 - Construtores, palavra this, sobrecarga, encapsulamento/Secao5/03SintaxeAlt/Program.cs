using System;
using System.Globalization;

namespace _03sintaxeAlt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

            Console.WriteLine();
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionacdo ao estoque: ");
            p.AdicionarProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            p.RemoverProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine(p);
        }
    }
}
