using Predicate.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.0));
list.Add(new Product("Mouse", 50.0));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

list.RemoveAll(ProductTest);

foreach (Product p in list)
{
    Console.WriteLine(p.Name);
}

static bool ProductTest(Product product)
{
    return product.Price >= 100;
}