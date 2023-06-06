namespace ExercicioResolvido.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void Deconstruct(out string name, out double price)
        {
            name = Name; 
            price = Price;
        }
    }
}