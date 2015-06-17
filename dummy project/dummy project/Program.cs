using System;

namespace dummy_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");

            int[] Digits = { -2, 45, 0, 11, -9 };

            Sort s = new Sort();

            Digits = s.bubble_sort(Digits);
            for (int k = 0; k < Digits.Length; k++)
            {
                Console.WriteLine(Digits[k]);
            }
        }
    }
}
