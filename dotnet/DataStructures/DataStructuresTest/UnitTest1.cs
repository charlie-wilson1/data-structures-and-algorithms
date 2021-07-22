using System;
using Xunit;
using DataStructures.Classes;
using DataStructures;

namespace DataStructuresTest
{
	public class UnitTest1 : Program
	{
    [Fact]
    public void ZipperTests()
    {
      LinkedList list1 = new LinkedList();
      list1.Insert(9);
      list1.Insert(7);
      list1.Insert(5);
      list1.Insert(3);
      list1.Insert(1);
      list1.Print();

      LinkedList list2 = new LinkedList();
      list2.Insert(8);
      list2.Insert(6);
      list2.Insert(4);
      list2.Insert(2);
      list2.Print();

      Assert.Equal(
        "(1) -> (2) -> (3) -> (4) -> (5) -> (6) -> (7) -> (8) -> (9) -> NULL",
        ZipLists(list1, list2)
        );
    }
  }
}
