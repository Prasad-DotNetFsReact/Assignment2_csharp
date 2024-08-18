using System;

namespace Assignment
{
    class Question
    {
         public static void Main(string[] args)
        {
            int[] number = { 12, 33, 87, 89, 34 };

            int max = number[0];

            for(int i=1; i<number.Length; i++)
            {
                if(number[i] > max)
                {
                    max = number[i];
                }
            }
            Console.WriteLine("the max number is: " + max);
        }
    }
}