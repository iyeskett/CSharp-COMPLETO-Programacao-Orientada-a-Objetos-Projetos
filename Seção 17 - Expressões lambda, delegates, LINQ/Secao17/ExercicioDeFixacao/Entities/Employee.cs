namespace ExercicioDeFixacao.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public void Deconstruct(out string name, out string email, out double salary)
        {
            name = Name;
            email = Email;
            salary = Salary;
        }
    }
}