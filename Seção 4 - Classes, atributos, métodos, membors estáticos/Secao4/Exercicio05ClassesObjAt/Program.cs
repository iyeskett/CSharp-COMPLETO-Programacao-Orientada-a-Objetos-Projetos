using System;
using System.Globalization;

namespace Exercicio05ClassesObjAt
{
    class Program
    {
        static void Main(string[] args)
        {
            // objeto
            Aluno aluno = new Aluno();


            // atributos
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(aluno);
            



        }
    }
}
