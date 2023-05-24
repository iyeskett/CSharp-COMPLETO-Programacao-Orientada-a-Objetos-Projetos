﻿using System;
using System.Globalization;

namespace exercicioResolvidoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                
                string[] vet = Console.ReadLine().Split(' ');
                

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }


            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i]+" ");
            }
            Console.WriteLine();

            
            int negative = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        negative++;
                    }
                }
            }

            Console.Write("Negative numbers = "+negative);

        }
    }
}
