using System;

namespace CodeChallenge28
{
    class Program
    {
        static void Main(string[] args)
        {
      int[] arr = { 5, 7, 8, 3, 6, 2 };
      int[] ans = (QuickSort(arr, arr[0], arr[arr.Length - 1]));
      foreach(int num in ans)
      {
        Console.WriteLine(num);
      }
        }

        public static int[] QuickSort(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                int pivotIndex = Partition(arr, start, end);
                QuickSort(arr, start, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, end);
            }
      return arr;
        }

        public static int Partition(int[] arr, int start, int end)
    {
      int pivot = arr[end];
      int swapIndex = start;

      for(int i = start; i < end; i++)
      {
        if (arr[i] <= pivot)
        {
          swap(arr, arr[i], arr[swapIndex]);
          swapIndex++;
        }
      }
      swap(arr, arr[swapIndex], pivot);
      return swapIndex;
    }
        public static void swap(int[] arr, int a, int b)
        {
          int temp = arr[a];
          arr[a] = arr[b];
          arr[b] = temp;
        }
    }
}
