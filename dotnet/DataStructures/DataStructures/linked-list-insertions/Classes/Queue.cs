using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Classes
{
  class Queue<T>
  {
      // Where the front is.
    public Node<T> Front { get; set; }

    public Node<T> Back { get; set; }


    // Dequeue
    public bool Peek()
    {
      return Front != null;
    }

    public void Enqueue(T val)
    {
      Node<T> node = new Node<T>(val);
      if (Front == null)
      {
        // We are making the current node both the front and the back.
        Front = node;
      }
      else
      {
        // The back node's next is now the new node.
        Back.Next = node;
        // The back node is NOW the new node.
      }
      Back = node;
    }

    public Node<T> Dequeue()
    {
      Node<T> currentFront = Front;

      // move the queue back one node (Similar to pop)
      Front = Front.Next;
      return currentFront;
    }

  }
}
