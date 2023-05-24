using System;
using System.Globalization;

namespace _03Resolvendo2ProblemaEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetos
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            // Atributo
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine(produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine(produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine(produto);


        }
    }
}
