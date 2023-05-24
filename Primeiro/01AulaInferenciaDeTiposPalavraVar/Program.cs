using System;

namespace _01AulaInferenciaDeTiposPalavraVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10; //var int
            var y = 20.0; // var double
            var z = "Maria"; // var string

            var w = z;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);
        }
    }
}
