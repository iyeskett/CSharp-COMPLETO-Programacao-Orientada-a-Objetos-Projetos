using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacaoListas2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();
            Console.Write("How many products will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #"+i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products.Add(new Products(id, name, price));
                Console.WriteLine();
            }

            Console.Write("Enter the product id that will have a price increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            Products prod = products.Find(x => x.Id == idIncrease);
            if (prod != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                prod.PriceIncrease(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Update list of products:");
            foreach (Products obj in products)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
