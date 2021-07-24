using System;
using Xunit;
using stackandqueue.Classes;
using System.Collections.Generic;

namespace stack_and_queue_tests
{
  public class UnitTest1
  {

    // ----- STACKS -----
    [Fact]
    public void StackIsOrIsNotEmptyAndCanPush()
    {
      stackandqueue.Classes.Stack<int> stack = new stackandqueue.Classes.Stack<int>();
      Assert.True(stack.IsEmpty());
      stack.Push(1);
      Assert.False(stack.IsEmpty());
    }

    [Fact]
    public void StackCanPop()
    {
      stackandqueue.Classes.Stack<int> stack = new stackandqueue.Classes.Stack<int>();
      stack.Push(5);
      stack.Push(10);
      Assert.Equal(10, stack.Pop());
    }
    [Fact]
    public void PopAndPeekWhenEmpty()
    {
      stackandqueue.Classes.Stack<int> stack = new stackandqueue.Classes.Stack<int>();
      Assert.Throws<NullReferenceException>(() => stack.Peek());
      Assert.Throws<NullReferenceException>(() => stack.Pop());
    }

    //  ------ QUEUES ------
    [Fact]
    public void CanEnqueueMultipleVals()
    {
      stackandqueue.Classes.Queue<int> q = new stackandqueue.Classes.Queue<int>();
      q.Enqueue(10);
      q.Enqueue(5);
      q.Enqueue(6);
      Assert.Equal(10, q.Peek());
      Assert.Equal(6, q.Back.Value);
    }

    [Fact]
    public void CanDequeueAndEmpty()
    {
      stackandqueue.Classes.Queue<int> q = new stackandqueue.Classes.Queue<int>();
      q.Enqueue(6);
      Assert.Equal(6, q.Dequeue());
      Assert.True(q.IsEmpty());
    }

    [Fact]
    public void CannotPeekOrDequeueEmptyQueue()
    {
      stackandqueue.Classes.Queue<int> q = new stackandqueue.Classes.Queue<int>();
      Assert.Throws<NullReferenceException>(() => q.Peek());
    }
  }
}

