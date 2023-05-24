using System;
using System.Globalization;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.0, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

        }
    }
}
