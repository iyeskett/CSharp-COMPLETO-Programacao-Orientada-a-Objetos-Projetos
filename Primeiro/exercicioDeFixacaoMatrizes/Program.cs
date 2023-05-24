using System;

namespace exercicioDeFixacaoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine()); 
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == num)
                    {
                        Console.WriteLine("Position "+i+","+j);
                        if (j > 0)
                        {
                            if (j > 0)
                            {
                                Console.WriteLine("Left: " + mat[i, j - 1]);
                            }
                            if (i > 0)
                            {
                                Console.WriteLine("Up: " + mat[i - 1, j]);
                            }
                            if (j < n - 1)
                            {
                                Console.WriteLine("Right: " + mat[i, j + 1]);
                            }
                            if (i < m - 1)
                            {
                                Console.WriteLine("Down: " + mat[i + 1, j]);
                            }
                        }
                    }
                }
            }
        }
    }
}
