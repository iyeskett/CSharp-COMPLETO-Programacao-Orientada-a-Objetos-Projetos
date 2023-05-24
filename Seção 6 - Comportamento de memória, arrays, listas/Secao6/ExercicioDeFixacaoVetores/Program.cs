using System;

namespace ExercicioDeFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] estudantes = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Alugeul #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                estudantes[quarto] = new Estudante { Nome = nome, Email = email };
                Console.WriteLine();
            }


            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i <= 9; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine(i + ": " + estudantes[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
