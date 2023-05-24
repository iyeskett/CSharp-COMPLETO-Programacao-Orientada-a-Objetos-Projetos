using System;
using System.Globalization;

namespace Exercicio03ClassesObjAt
{
    class Program
    {
        static void Main(string[] args)
        {
            // objeto
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            //Atributos
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(retangulo);
        }
    }
}
