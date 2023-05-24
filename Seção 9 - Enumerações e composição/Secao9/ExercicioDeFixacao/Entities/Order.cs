using ExercicioDeFixacao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioDeFixacao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ORDER SUMMARY:");
            stringBuilder.AppendLine("Order moment: "+ Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine("Order status: " + Status.ToString());
            stringBuilder.AppendLine("Client: "+ Client);
            stringBuilder.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            stringBuilder.Append("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return stringBuilder.ToString();

        }
    }
}
