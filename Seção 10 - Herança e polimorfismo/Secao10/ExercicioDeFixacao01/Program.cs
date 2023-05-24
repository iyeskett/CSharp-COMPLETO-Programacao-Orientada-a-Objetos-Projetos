﻿using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioDeFixacao01.Entities;

namespace ExercicioDeFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'c' || ch == 'C' )
                {
                    products.Add(new Product(name, price));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (ch == 'i'|| ch=='I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    Console.WriteLine("Category not find!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }
    }
}
