using System;

namespace Assignment
{
    class Question1
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 23, 27, 38, 28, 87 };
            int sum = 0;

            foreach (int i in numbers)
            {
                sum += i;
            }
            double avg=(sum/numbers.Length);

            Console.WriteLine($"the avg of numbers : {avg}");
        }
    }
}