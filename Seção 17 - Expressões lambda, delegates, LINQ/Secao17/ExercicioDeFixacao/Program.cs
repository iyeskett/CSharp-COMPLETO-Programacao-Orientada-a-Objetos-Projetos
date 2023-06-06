using ExercicioDeFixacao.Entities;
using System.Globalization;

Console.Write("Enter full file path: ");
var path = Console.ReadLine();

Console.Write("Enter salary: ");
var baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

List<Employee> employees = new List<Employee>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        var fields = sr.ReadLine().Split(',');
        var name = fields[0];
        var email = fields[1];
        var salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

        employees.Add(new Employee(name, email, salary));
    }
}

var people =
    from emp in employees
    where emp.Salary > baseSalary
    orderby emp.Email
    select emp.Email;

Console.WriteLine($"Email of people whose salary is more than {baseSalary.ToString("F2", CultureInfo.InvariantCulture)}");
foreach (var p in people)
{
    Console.WriteLine(p);
}

var mSalary = 
    (from emp in employees
    where emp.Name[0] == 'M'
    select emp.Salary).Sum();
Console.WriteLine($"Sum of salary of people whose name starts with 'M': {mSalary.ToString("F2", CultureInfo.InvariantCulture)}");