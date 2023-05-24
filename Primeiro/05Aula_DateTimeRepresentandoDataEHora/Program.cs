using System;
using System.Globalization;

namespace _05Aula_DateTimeRepresentandoDataEHora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d2);

        }
    }
}
