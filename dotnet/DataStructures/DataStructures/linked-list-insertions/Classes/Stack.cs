using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Classes
{
  class Stack<T>
  {
    public Node<T> Top { get; set; }

    public bool IsEmpty()
    {
      return (Top != null);
    }

    public void Push(T val)
    {

      Node<T> node = new Node<T>(val);

      node.Next = Top;

      Top = node;
    }

    public Node<T> Pop()
    {
      // creating a reference node to the top value in the stack.
      Node<T> currentTop = Top;

      // Setting the Top of the stack to the next value.
      Top = currentTop.Next;

      // get back the new value.
      return currentTop;
    }


  }
}
