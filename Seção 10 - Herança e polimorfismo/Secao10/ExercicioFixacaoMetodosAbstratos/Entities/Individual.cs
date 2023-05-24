using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoMetodosAbstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - (0.5 * HealthExpenditures);
            }
            else
            {
                return AnualIncome * 0.25 - (0.5 * HealthExpenditures);
            }
        }
    }
}
