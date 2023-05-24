using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _03Vetores
{
    class AlturaMedia
    {
        public static double Media(int n, double[] alturas)
        {
            double altura = 0;
            for (int i = 0; i < n; i++)
            {
                altura += alturas[i];
            }
            double media = altura / n;
            return media;
        }
    }
}
