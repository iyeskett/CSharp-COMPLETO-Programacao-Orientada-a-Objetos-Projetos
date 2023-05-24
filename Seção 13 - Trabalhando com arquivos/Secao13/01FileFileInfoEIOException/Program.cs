using System;
using System.IO;

namespace _01FileFileInfoEIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; // @ para não precisar usar '\\' só '\'
            string targetPath = @"c:\temp\file2.txt"; // @ para não precisar usar '\\' só '\'

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
