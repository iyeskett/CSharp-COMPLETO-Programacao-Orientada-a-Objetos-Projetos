using Action.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.0));
list.Add(new Product("Mouse", 50.0));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

//Func<Product, string> func = NameUpper;
Func<Product, string> func = p => p.Name.ToUpper();

//List<string> result = list.Select(NameUpper).ToList();
//List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
List<string> result = list.Select(func).ToList();

result.ForEach(p => { Console.WriteLine(p); });

static string NameUpper(Product p)
{
    return p.Name.ToUpper();
}