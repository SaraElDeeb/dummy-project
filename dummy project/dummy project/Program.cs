using System;

namespace dummy_project
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] dummy_list = { 100, 23, 45, 12, 8, 2, 1000, 23, 14 };

			InsertionSort insertion_sort = new InsertionSort ();
			int[] sorted_list = insertion_sort.Sort (dummy_list);
			
			foreach (int num in sorted_list)
			{
				Console.WriteLine (num);
			}
        }
    }
}
