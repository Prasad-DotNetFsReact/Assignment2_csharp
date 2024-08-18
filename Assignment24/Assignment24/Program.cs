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

            int[] columnSum = new int[cols];

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                { sum = sum + array[row, col]; }
                columnSum[col] = sum;
                Console.WriteLine($"{columnSum[col]}");
            }
           
        }
    }
}