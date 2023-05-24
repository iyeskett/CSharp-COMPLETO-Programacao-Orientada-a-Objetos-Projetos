using System;
using _01Enumeracoes_Enum_.Entities;
using _01Enumeracoes_Enum_.Entities.Enums;



namespace _01Enumeracoes_Enum_
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order() { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
