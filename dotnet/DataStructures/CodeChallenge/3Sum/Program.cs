using System;
using System.Collections.Generic;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Test");
        }

    public static List<List<int>>  ThreeSum(int[] arr, int target)
    {

      QuickSort(arr, 0, arr.Length);
      List<List<int>> ans = new List<List<int>>();

      for(int i = 0; i < arr.Length; i++)
      {
        /* If not at first index within input array and the index minus 1
         * is same as index, skip it (in order to prevent duplicates).
        */

        if (i > 0 && arr[i] == arr[i - 1])
        {
          continue;
        }
        else
        {

          int l = i + 1;
          int r = arr.Length;

          while (l < r)
          {
            // if sum of l, r and i greater than target, move r backwards 1.
            int tempSum = arr[i] + arr[l] + arr[r];
            if (tempSum > target)
            {
              r--;
            }
            // if sum of l, r and i lesser than target, move r backwards 1.
            else if (tempSum < target)
            {
              l++;
            }
            else
            {
              // Create list, add all numbers that sum to target.
              List<int> solutionSet = new List<int>();
              solutionSet.Add(arr[i]);
              solutionSet.Add(arr[l]);
              solutionSet.Add(arr[r]);

              // add solutionSet to ans
              ans.Add(solutionSet);
              // increment left pointer by 1. continue checking for cases even after finding a solution set.
              l++;
              while ((arr[l] == arr[l - 1]) && (l < r))
              {
                l++;
              }
            }
          }
        }
      }

      return ans;
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
            else if (start < end)
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
