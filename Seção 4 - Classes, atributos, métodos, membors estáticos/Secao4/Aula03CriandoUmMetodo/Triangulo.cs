using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _02CriandoClasseTresAtri
{
    class Triangulo
    {
        // Atributos
        public double A { get; set; } 
        public double B { get; set; }
        public double C { get; set; }

        // Métodos
        
        public double Area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override string ToString()
        {
            return Area().ToString("F4", CultureInfo.InvariantCulture);
        }



    }
}
