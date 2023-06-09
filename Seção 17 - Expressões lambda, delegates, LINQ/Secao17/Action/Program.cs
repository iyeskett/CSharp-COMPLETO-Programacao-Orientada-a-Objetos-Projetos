﻿using Action.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.0));
list.Add(new Product("Mouse", 50.0));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

//Action<Product> act = UpdatePrice;
Action<Product> act = p => { p.Price += p.Price * 0.1; };

//list.ForEach(act);
//list.ForEach(UpdatePrice);
list.ForEach(p => { p.Price += p.Price * 0.1; });

foreach (Product p in list)
{
    Console.WriteLine(p);
}

static void UpdatePrice(Product product)
{
    product.Price += product.Price * 0.1;
}