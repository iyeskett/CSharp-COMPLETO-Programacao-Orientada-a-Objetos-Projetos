using System;
using System.Globalization;

namespace _02CriandoClasseTresAtri
{
    class Program
    {
        static void Main(string[] args)
        {

            // objetos
            Triangulo x, y;
            x = new Triangulo(); 
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            // atributos ou campos
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triângulo Y:");
            // atributos ou campos
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area de X: " + x);
            Console.WriteLine( "Area de Y: " +y);

            if (x.Area() > y.Area())
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
