using System;
using Xunit;
using stackandqueue.Classes;
using stackandqueue;

namespace stack_and_queue_tests
{
  public class UnitTest1
  {

    // ----- STACKS -----
    [Fact]
    public void StackIsOrIsNotEmptyAndCanPush()
    {
      Stack<int> stack = new Stack<int>();
      Assert.True(stack.IsEmpty());
      stack.Push(1);
      Assert.False(stack.IsEmpty());
    }

    [Fact]
    public void StackCanPop()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(5);
      stack.Push(10);
      Assert.Equal(10, stack.Pop());
    }
    [Fact]
    public void PopAndPeekWhenEmpty()
    {
      Stack<int> stack = new Stack<int>();
      Assert.Throws<NullReferenceException>(() => stack.Peek());
      Assert.Throws<NullReferenceException>(() => stack.Pop());
    }

    //  ------ QUEUES ------
    [Fact]
    public void CanEnqueueMultipleVals()
    {
      Queue<int> q = new Queue<int>();
      q.Enqueue(10);
      q.Enqueue(5);
      q.Enqueue(6);
      Assert.Equal(10, q.Peek());
      Assert.Equal(6, q.Back.Value);
    }

    [Fact]
    public void CanDequeueAndEmpty()
    {
      Queue<int> q = new Queue<int>();
      q.Enqueue(6);
      Assert.Equal(6, q.Dequeue());
      Assert.True(q.IsEmpty());
    }

    [Fact]
    public void CannotPeekOrDequeueEmptyQueue()
    {
      Queue<int> q = new Queue<int>();
      Assert.Throws<NullReferenceException>(() => q.Peek());
    }

    // VALID BRACKET CODE CHALLENGE 12
    [Fact]
    public void ReturnsValidBracket()
    {
      string str = "{[()]}";
      Assert.True(isValidBracket(str));
    }

    [Fact] void ReturnsInvalidBracket()
    {
      string str = "{[}]";
      Assert.False(isValidBracket(str));
    }
      static bool isValidBracket(string str)
      {
        // Creating
        Stack<char> stack = new Stack<char>();
        if (str == "" || str == null) return false; 
        foreach(char c in str)
        {
          if (c == '{' || c == '(' || c == '[')
          {
            stack.Push(c);
          }
          else if (c == '}')
          {
          char temp = stack.Peek();
            if ( temp == '{')
            {
              stack.Pop();
            }
            else return false;
          }
          else if (c == ')')
          {
          char temp = stack.Peek();
            if (temp == '(')
            {
              stack.Pop();
            }
            else return false;
          }
          else if (c == ']')
          {
          char temp = stack.Peek();
            if (temp == '[')
            {
              stack.Pop();
            }
            else return false;
          }
        }
      if (stack.IsEmpty() == true) return true;
      else return false;
      }
  }
}

