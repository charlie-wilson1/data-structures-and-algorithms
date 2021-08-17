using Xunit;
using CodeChallenge26.Main;

namespace Challenge26Tests
{
  public class UnitTest1
    {
        [Fact]
        public void ReturnsOneNum()
        {
          int[] test = { 15 };
          Insert ins = new Insert();
          int[] res = ins.InsertionSort(test);

          Assert.Equal(15, res[0]);
        }

        [Fact]
        public void ReturnsSorted()
    {
      int[] test = { 8, 4, 23, 42, 16, 15 };
      Insert ins = new Insert();

      int[] res = ins.InsertionSort(test);
      int[] sorted = { 4, 8, 15, 16, 23, 42 };

      Assert.Equal(sorted, res);
    }

        [Fact]
        public void ReturnsNullWhenEmpty()
    {
      int[] test = { };
      Insert ins = new Insert();
      int[] res = ins.InsertionSort(test);
      Assert.Null(res);
    }
    }
}
