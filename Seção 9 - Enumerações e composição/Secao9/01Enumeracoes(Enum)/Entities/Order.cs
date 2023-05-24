using System;
using _01Enumeracoes_Enum_.Entities.Enums;
using _01Enumeracoes_Enum_.Entities;
using System.Collections.Generic;
using System.Text;

namespace _01Enumeracoes_Enum_.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }



        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
