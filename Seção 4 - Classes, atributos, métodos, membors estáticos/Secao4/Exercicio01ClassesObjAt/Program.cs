using System;

namespace Exercicio01ClassesObjAt
{
    class Program
    {
        static void Main(string[] args)
        {
            // objetos
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            // atributos
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            // atributos
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }



        }
    }
}
