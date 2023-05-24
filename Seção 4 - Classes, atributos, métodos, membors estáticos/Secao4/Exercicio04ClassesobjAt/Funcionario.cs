using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio04ClassesobjAt
{
    class Funcionario
    {
        public string Nome { get;  set; }
        public double SalarioBruto { get;  set; }
        public double Imposto  { get; set; }
        private bool Atualizou { get; set; }

        public Funcionario()
        {
            Atualizou = false;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);

        }

        public override string ToString()
        {
            if (!Atualizou)
            {
                return "Funcionário: " + Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
            }
            return "Dados atualizados: " + Nome + ", $ " +  SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
