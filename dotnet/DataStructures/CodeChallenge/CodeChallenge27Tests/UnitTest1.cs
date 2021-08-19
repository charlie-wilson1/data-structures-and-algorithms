using System;
using Xunit;


namespace DataStructures
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortArray()
        {
            
      int[] arr = { 7, 2, 1, 6, 8, 5, 3, 4 };
      int[] sorted = { 1, 2, 3, 4, 5, 6, 7, 8 };
      MergeAndSort merge = new();
      int[] thing = merge.MergeSort(arr);
      Assert.Equal(sorted, thing);
        }

        [Fact]
        public void ReturnsSingleArr()
        {
            int[] arr = { 2 };
      MergeAndSort merge = new();
            var thing = merge.MergeSort(arr);
            Assert.Equal(2, thing[0]);
        }

        [Fact]
        public void ReturnsVoid()
        {
      int[] arr = { };
      MergeAndSort merge = new();
            var thing = merge.MergeSort(arr);
            Assert.Equal(arr, thing);
        }
    }
}
