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
            int[] sorted_list = s.bubble_sort(Digits);
			Console.WriteLine ("Sorted by Bubble Sort");
            for (int k = 0; k < Digits.Length; k++)
            {
				Console.WriteLine(sorted_list[k]);
            }

			Console.WriteLine ();

			InsertionSort insertion_sort = new InsertionSort ();
			sorted_list = insertion_sort.Sort(Digits);
			Console.WriteLine ("Sorted by Insertion Sort");
			for (int k = 0; k < Digits.Length; k++)
			{
				Console.WriteLine(sorted_list[k]);
			}
        }
    }
}
