using System;

namespace Assignment
{
    class Question4
    {
        public static void Main(string[] args)
        {
            int[,] array = {
            { 23,45,45},
            {63,67,87 },
            { 7,9,87} };

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int[] rowSum = new int[rows];

            for (int row = 0; row < rows; row++)
            {
                int sum = 0;
                for (int col = 0; col < rows; col++)
                { sum = sum + array[row, col]; }
                rowSum[row] = sum;
                Console.WriteLine($"{rowSum[row]}");
            }

        }
    }
}