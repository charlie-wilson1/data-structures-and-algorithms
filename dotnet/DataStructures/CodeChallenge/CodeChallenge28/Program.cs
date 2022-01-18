using System;

namespace _3Sum
{
    public class ProgramTwo
    {
        static void Main(string[] args)
        {
      int[] arr = { 7, 2, 1, 6, 8, 5, 3, 4 };
      var sorted = QuickSort(arr, 0, arr.Length);
      foreach(int num in sorted)
      {
        Console.WriteLine(num);
      }
        }

        public static int[] QuickSort(int[] arr, int start, int end)
        {
            if (arr.Length == 0)
            {
               return null;
            }
            else if (arr.Length == 1)
            {
              return arr;
            }

            // When there are more than two ints in the arr..
            if (start < end)
            {
                int pivotIndex = Partition(arr, start, end);
                QuickSort(arr, start, pivotIndex);
                QuickSort(arr, pivotIndex + 1, end);
            }
          return arr;
        }

        public static int Partition(int[] arr, int start, int end)
        {
          int pivot = arr[start];
          int swapIndex = start;

          for(int i = start + 1; i < end; i++)
          {
            if (arr[i] < pivot)
            {
              swapIndex++;
              Swap(arr, i, swapIndex);
            }
          }
          Swap(arr, swapIndex, start);
          return swapIndex;
        }

        public static void Swap( int[] arr, int i, int j)
        {
          int temp = arr[i];
          arr[i] = arr[j];
          arr[j] = temp;
        }
    }
}
