using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvido01.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerhour, double additionalCharge) : base(name,hours,valuePerhour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }

    }
}
