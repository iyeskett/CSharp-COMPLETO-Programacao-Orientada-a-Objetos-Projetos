using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio05ClassesObjAt
{
    class Aluno
    {
        public string Nome { get; set; }
        public double N1 { get; set; }
        public double N2 { get; set; }
        public double N3 { get; set; }

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public override string ToString()
        {
            if (NotaFinal() >= 60)
            {
                return "NOTA FINAL = " + NotaFinal()
                    + "\nAPROVADO";
            }
            else
            {
                double Diferenca = 60.00 - NotaFinal();
                return "NOTA FINAL = " + NotaFinal()
                    + "\nREPROVADO"
                    + "\nFALTARAM " + Diferenca.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }

        }
    }
}
