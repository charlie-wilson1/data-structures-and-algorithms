using System;
using DataStructures.Classes;
using Xunit;

namespace DataStructuresTest
{

  public class UnitTest1
  {
    public Node node = new Node(10);
    [Fact]
    public void ProofOfLife()
    {
      LinkedList list = new LinkedList();
      Assert.NotNull(list);
    }
    [Fact]
    public void ProofOfHeadAndNext()
    {
      LinkedList list = new LinkedList();
      list.Insert(3);
      list.Insert(6);
      list.Insert(9);
      Assert.Equal(9, list.Head.Value);
      Assert.Equal(6, list.Head.Next.Value);
    }
    [Fact]
    public void ProofOfInsertAndList()
    {
      LinkedList list = new LinkedList();
      list.Insert(3);
      list.Insert(6);
      list.Insert(9);
      Assert.True(list.Includes(6));
      Assert.False(list.Includes(12));
    }
    [Fact]
    public void ProofOflistAndPrint()
    {
      LinkedList list = new LinkedList();
      list.Insert(3);
      list.Insert(6);
      list.Insert(9);
      Assert.Equal("(9) -> (6) -> (3) -> NULL", list.Print());
    }
    [Fact]
    public void ProofOfInsertBefore()
    {
      LinkedList list = new LinkedList();
      list.Insert(3);
      list.Insert(6);
      list.Insert(9);
      // Test's inserting at middle of list
      list.InsertBefore(6, 12);
      // Test's inserting at Head of list
      list.InsertBefore(9, 15);
      Assert.Equal("(15) -> (9) -> (12) -> (6) -> (3) -> NULL", list.Print());
    }
  }
}
