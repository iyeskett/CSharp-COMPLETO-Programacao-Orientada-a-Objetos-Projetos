using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioDeFixacaoListas2
{
    class Products
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; private set; }
        private double IncreasedPrice;
        private bool Increased = false;

        public Products(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public void PriceIncrease(double percentage)
        {
            IncreasedPrice = Price * percentage / 100;
            Price += IncreasedPrice;
            Increased = true;
        }

        public override string ToString()
        {
            if (!Increased)
            {
                return "Id: " + Id + ", Name: " + Name + ", Price: $" + Price.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                return "Id: " + Id + ", Name: " + Name + ", Price: $" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Increased price: $" + IncreasedPrice.ToString("F2", CultureInfo.InvariantCulture);
            }
            
        }
    }
}
