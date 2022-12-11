using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 2, 9, 6, 4 };
            Console.WriteLine("Before Sorting:");
            Traverse(array);
            Console.WriteLine("After Sorting:");
            //BubbleSort(array);
            //InsertionSort(array);
            //SelectionSort(array);
            MergeSort(array,0,4);
            Traverse(array);
        }
        // 1. Bubble Sort Complexity of O(n^2)
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
        // 2. Insertion Sort Complexity of O(n^2)
        static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    Swap(ref arr[j - 1], ref arr[j]);
                    j--;
                }
            }
        }

        // 3. Selection Sort Complexity of O(n^2)
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int iMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[iMin])
                    {
                        iMin = j;
                    }
                }
                Swap(ref arr[i], ref arr[iMin]);
            }
        }
        // 4. Merge Sort Complexity of O(nLog(n))  *** Divide & Conquer ***
        static public void MergeSort(int[] arr, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                // recursion on left handside
                MergeSort(arr, left, mid);
                // recursion on right handside
                MergeSort(arr, (mid + 1), right);
                // Merging Operation
                Merge(arr, left, (mid + 1), right);
            }
        }
        static public void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (arr[left] <= arr[mid])
                    temp[pos++] = arr[left++];
                else
                    temp[pos++] = arr[mid++];
            }
            while (left <= eol)
                temp[pos++] = arr[left++];
            while (mid <= right)
                temp[pos++] = arr[mid++];
            for (i = 0; i < num; i++)
            {
                arr[right] = temp[right];
                right--;
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
