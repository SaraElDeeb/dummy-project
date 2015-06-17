using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dummy_project
{
    class Sort
    {

        public int[] bubble_sort(int[] digits)
        {
            int temp;
            int number_of_digits = digits.Length - 1;
            
            for (int i = number_of_digits; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (digits[j] > digits[j + 1])
                    {
                        temp = digits[j];
                        digits[j] = digits[j + 1];
                        digits[j + 1] = temp;
                    }
                }
            }

            return digits;
        }
    }
}
