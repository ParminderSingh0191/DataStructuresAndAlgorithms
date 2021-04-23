using System;

namespace ArrayIsSortedOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = IsArraySortedOrNot(new int[] { 1, 2, 3, 4, 5, 6, 8, 7 }, 8);

            if(result == 1)
            {
                Console.WriteLine("Array of items is sorted.");
            }
            else
            {
                Console.WriteLine("Array of items is not sorted.");
            }
        }

        private static int IsArraySortedOrNot(int[] items, int n)
        {
            // Time complexity: O(n)
            // Space Complexity: O(n)
            if(n==1)
            {
                return 1;
            }

            return (items[n - 1] < items[n - 2]) ? 0 : IsArraySortedOrNot(items, n - 1);
        }
    }
}
