using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 2, 9, 6, 4 };
            Traverse(array);
            BubbleSort(array);
            Traverse(array);
        }
        // Bubble Sort
        static void BubbleSort(int [] arr)
        {
            for (int k = 0; k < arr.Length - 1; k++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                    }
                }
            }
        }
        static void Swap(ref int val1, ref int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }
        static void Traverse(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+", ");
            }
            Console.WriteLine();
        }
    }
}
