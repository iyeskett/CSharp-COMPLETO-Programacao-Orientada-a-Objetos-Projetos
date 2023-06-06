﻿using System.Globalization;

namespace Func.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            Name = nome;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}