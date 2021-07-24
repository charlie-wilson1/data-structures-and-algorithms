using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackandqueue.Classes
{
  class Queue<T>
  {
    public Node<T> Front { get; set; }

    public Node<T> Back { get; set; }

    //where the front is.

    public Node<T> Peek()
    {
      if (Front.Equals(null)) throw new NullReferenceException();
      return Front;
    }

    public bool IsEmpty()
    {
      return Front != null;
    }

    public void Enqueue(T val)
    {
      Node<T> node = new Node<T>(val);
      if (Front.Equals(null))
      {
        Front = node;
      }
      else
      {
        // The back node's next is now the new node.
        Back.Next = node;
      }
      Back = node;
    }

    public Node<T> Dequeue()
    {
      Node<T> currentFront = Front;

      // move the queue back one node (similar to pop)

      Front = Front.Next;

      return currentFront;
    }
  }
}
