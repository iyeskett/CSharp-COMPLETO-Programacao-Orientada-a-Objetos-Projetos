using System;
using System.Collections.Generic;
using System.Text;

namespace _05MembrosEstaticos2
{
    class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
