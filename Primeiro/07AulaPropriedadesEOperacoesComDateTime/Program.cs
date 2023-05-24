using System;

namespace _07AulaPropriedadesEOperacoesComDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2002,03,12);

            DateTime d2 = new DateTime(2022,05,05);

            TimeSpan t = d2.Subtract(d);

            Console.WriteLine(t);

        }
    }
}
