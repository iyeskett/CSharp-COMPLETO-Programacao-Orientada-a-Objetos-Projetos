﻿using System;
using System.Globalization;

namespace _03AulaSintaxeAltExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? desconto = preco * 0.1 : desconto = preco * 0.05;

            Console.WriteLine(desconto);

            
        }
    }
}