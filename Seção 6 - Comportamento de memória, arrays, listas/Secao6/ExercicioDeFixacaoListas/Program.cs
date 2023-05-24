﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #"+i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id,name,salary));
                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have a salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            Employee employee = employees.Find(x => x.Id == idIncrease);
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
