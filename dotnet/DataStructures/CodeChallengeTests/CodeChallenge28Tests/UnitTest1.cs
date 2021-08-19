using System;
using Xunit;


namespace CodeChallenge28
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortArray()
        {
            
      int[] arr = { 7, 2, 1, 6, 8, 5, 3, 4 };
      int[] sorted = { 1, 2, 3, 4, 5, 6, 7, 8 };
      var thing = Program.QuickSort(arr, 0, arr.Length);
      Assert.Equal(sorted, thing);
        }

        [Fact]
        public void ReturnsSingleArr()
        {
            int[] arr = { 2 };
            var thing = Program.QuickSort(arr, 0, arr.Length);
            Assert.Equal(2, thing[0]);
        }

        [Fact]
        public void ReturnsVoid()
        {
      int[] arr = { };
            var thing = Program.QuickSort(arr, 0, arr.Length);
            Assert.Null(thing);
        }
    }
}
