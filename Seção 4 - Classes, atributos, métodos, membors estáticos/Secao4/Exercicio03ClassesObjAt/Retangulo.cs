using System.Globalization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03ClassesObjAt
{
    class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERIMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
