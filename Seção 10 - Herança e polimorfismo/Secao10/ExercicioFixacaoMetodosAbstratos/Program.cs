using ExercicioFixacaoMetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Individual or company (i/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));

                }
                else if (ch == 'c' || ch =='C')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));

                }
            }

            Console.WriteLine();
            double sum = 0;
            Console.WriteLine("TAXES PAYER:");
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer.Name + ": $ "+ taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ "+sum.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
