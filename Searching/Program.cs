using System;

namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array =new int[] { 1,5,7,8, 2, 3 };
            Console.WriteLine(LinearSearch(array,7));

            int[] arr = new int[] {1,3,4,6,7,9 };
            Console.WriteLine(BinarySearch(arr, 2));
            Console.WriteLine(BinarySearch(arr, 3));
            Console.WriteLine(BinarySearch(arr, 6));
        }
        // Complexity  O(n)
        // Better Used for UnSorted Array
        static int LinearSearch(int[] arr, int element)
        {
            for (int pos = 0; pos < arr.Length; pos++)
            {
                if (arr[pos]==element)
                {
                    return pos;
                }
            }
            return -1;
        }
        // Complexity  O(log(n))
        // Array has to be Sorted 
        static int BinarySearch(int[] arr, int element)
        {
            int start = 0;
            int end = arr.Length;
            int mid ;
            while (start<=end)
            {
                mid = (start + end) / 2;
                if (arr[mid]==element)
                {
                    return mid;
                }
                else if (arr[mid]<element)
                {
                    start = mid+1;
                }
                else
                {
                    end = mid-1;
                }
            }
            return -1;
        }
    }
}
