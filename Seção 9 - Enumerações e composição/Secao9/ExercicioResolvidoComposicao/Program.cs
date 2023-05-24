using ExercicioResolvidoComposicao.Entities;
using ExercicioResolvidoComposicao.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioResolvidoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department´s name: ");
            Department department = new Department(Console.ReadLine());
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker worker = new Worker(name, level, salary, department);

            Console.Write("How may contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter the {n}# contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Durations (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract hourContract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(hourContract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine(worker);
            Console.WriteLine("Income for "+monthAndYear+": "+ worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            
        }
    }
}
