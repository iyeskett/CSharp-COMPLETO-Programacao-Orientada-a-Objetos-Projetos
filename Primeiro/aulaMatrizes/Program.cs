using System;

namespace aulaMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            double total = 0;
            double[,] mat = new double[n,m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    total += 10;
                    mat[i, j] = total;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mat[i, j]+" ");
                }

                Console.WriteLine();
            }
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
