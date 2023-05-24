using System;
using System.IO;
namespace _03UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt"; // @ para não precisar usar '\\' só '\'

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }



        }
    }
}
