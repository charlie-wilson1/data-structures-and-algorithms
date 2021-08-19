using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{

  public class MergeAndSort
  {
  public static void Main(string[] args)
  {

  }
    public int[] MergeSort(int[] arr)
    {
      int length = arr.Length;
      int mid = length / 2;
      int[] left;
      int[] right;
      int[] result = new int[length];

      if (length <= 1) { return arr; }

      left = new int[mid];

      if (length % 2 == 0) { right = new int[mid]; }

      else { right = new int[mid + 1]; }

      for (int i = 0; i < mid; i++) { left[i] = arr[i]; }

      int x = 0;
      for (int k = mid; k < length; k++)
      {
        right[x] = arr[k];
        x++;
      }

      left = MergeSort(left);
      right = MergeSort(right);

      result = Merge(left, right);

      return result;
    }

    private int[] Merge(int[] left, int[] right)
    {
      int[] result = new int[left.Length + right.Length];
      int i = 0;
      int j = 0;
      int k = 0;

      while (i < left.Length || j < right.Length)
      {
        if (i < left.Length && j < right.Length)
        {
          if (left[i] <= right[j])
          {
            result[k] = left[i];
            i++;
            k++;
          }
          else
          {
            result[k] = right[j];
            j++;
            k++;
          }
        }
        else if (i < left.Length)
        {
          result[k] = left[i];
          i++;
          k++;
        }
        else if (j < right.Length)
        {
          result[k] = right[j];
          j++;
          k++;
        }

      }
      return result;
    }
  }
}
