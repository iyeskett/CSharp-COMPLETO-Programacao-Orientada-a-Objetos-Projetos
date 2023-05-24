using System;
using System.Globalization;

namespace _03Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];

            for (int i = 0; i < n; i++)
            {
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            
            Console.WriteLine("Altura média: " +AlturaMedia.Media(n, alturas).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
