using System;

namespace ExercicioDeFixacaoVetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente[] clientes = new Cliente[10];

            Console.Write("Quantos carros serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n ; i++)
            {
                Console.WriteLine("Cliente #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("ID do carro escolhido: ");
                int id = int.Parse(Console.ReadLine());
                clientes[id] = new Cliente { Nome = nome, Idade = idade, Email = email, CPF = cpf };
                Console.WriteLine();
            }

            Console.WriteLine("Carros escolhidos:");
            for (int i = 0; i <= 9; i++)
            {
                if (clientes[i] != null)
                {
                    Console.WriteLine(i + ": " + clientes[i]);
                }
            }
        }
    }
}
