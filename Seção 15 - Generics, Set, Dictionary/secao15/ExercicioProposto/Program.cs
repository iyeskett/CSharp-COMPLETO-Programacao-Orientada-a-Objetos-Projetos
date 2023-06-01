using ExercicioProposto.Models;

Course courseA = new Course();
Course courseB = new Course();
Course courseC = new Course();

for (int i = 0; i < 3; i++)
{
    string course = string.Empty;
    switch (i)
    {
        case 0:
            course = "A";
            break;

        case 1:
            course = "B";
            break;

        case 2:
            course = "C";
            break;

        default:
            break;
    }

    Console.Write($"how many students for course {course}? ");
    int students = int.Parse(Console.ReadLine());
    for (int j = 0; j < students; j++)
    {
        int idStudent = int.Parse(Console.ReadLine());

        if (i == 0)
            courseA.students.Add(new Student() { Id = idStudent });
        if (i == 1)
            courseB.students.Add(new Student() { Id = idStudent });
        if (i == 2)
            courseC.students.Add(new Student() { Id = idStudent });
    }
}

HashSet<Student> total = new HashSet<Student>(courseA.students);
total.UnionWith(courseB.students);
total.UnionWith(courseC.students);

Console.WriteLine($"Total students: {total.Count}");