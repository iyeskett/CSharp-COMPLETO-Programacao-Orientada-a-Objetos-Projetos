using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacaoVetores2
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Idade + " anos, email: "
                + Email + " CPF: " + CPF;
        }
    }
}
