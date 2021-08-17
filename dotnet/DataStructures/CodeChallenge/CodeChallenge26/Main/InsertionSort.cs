using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge26.Main
{
  public class Insert
  {
    int[] thing { get; set; }

    public int[] InsertionSort(int[] arr)
    {
      if (arr == null || arr.Length == 0)
      {
        return null;
      }
      for (int i = 0; i < arr.Length; i++)
      {
        int j = i - 1;
        int temp = arr[i];

        while (j >= 0 && temp < arr[j])
        {
          arr[j + 1] = arr[j];
          j--;
        }

        arr[j + 1] = temp;
      }
      return arr;
    }
  }
}
