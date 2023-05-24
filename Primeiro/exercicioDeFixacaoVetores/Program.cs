using System;

namespace exercicioDeFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Estudantes[] estudante = new Estudantes[10];
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                
                Console.WriteLine("Aluguel #"+i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                estudante[quarto] = new Estudantes { Nome = nome, Email = email};
                Console.WriteLine();
            }
            

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine(i + ": " + estudante[i]);
                }
            }
        }
    }
}
