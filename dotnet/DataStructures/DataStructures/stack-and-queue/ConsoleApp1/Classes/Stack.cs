using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackandqueue.Classes
{
  public class Stack<T>
  {
    public Node<T> Top { get; set; }

    public bool IsEmpty()
    {
      return !Top.Equals(null);
    }

    public void Push(T val)
    {
      // Create a new node, with type T.
      Node<T> node = new Node<T>(val);

      // pushing that node to the top.
      node.Next = Top;

      Top = node;
    }

    public Node<T> Pop()
    {
      // Creating a reference node to the top value in the stack.
      Node<T> currentTop = Top;

      if (currentTop == null) throw new NullReferenceException("Empty stack. Cannot pop.");
      // Setting the Top of the stack to the next value.
      Top = currentTop.Next;


      // get back the new value.
      return currentTop;
    }

    public Node<T> Peek()
    {
      if (Top == null) throw new NullReferenceException("Empty stack. Cannot pop.");
      return Top;
    }
  }
}
