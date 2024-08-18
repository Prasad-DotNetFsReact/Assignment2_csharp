using System;

namespace Assignment
{
    class Question2
    {
        public static void Main(string[] args)
        {
            int[,] matrix1 = {
            {1, 2, 3 },
            { 9,7,9},
            {9, 9, 9, }
             };
            int[,] matrix2 = {
            {1, 2, 3 },
            { 9,7,9},
            {9, 9, 9, }
             };
            int[,] result = new int[3, 3];

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    result[i, j] = matrix1[i, j]+matrix2[i, j];

                }
            }
            Console.WriteLine("Sum of two matrixes is:");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                     Console.WriteLine(result[i, j]);   
                }
                Console.WriteLine();
            }
        }
     }
    }