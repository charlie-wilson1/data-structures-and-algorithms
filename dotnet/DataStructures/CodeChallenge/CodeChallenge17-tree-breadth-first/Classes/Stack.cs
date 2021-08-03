using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge17_tree_breadth_first
{
  public class Queue<T>
  {
    public Node<T> Front { get; set; }

    public Node<T> Back { get; set; }

    public T Peek()
    {
      if (Front == null) throw new NullReferenceException();
      return Front.Value;
    }

    public bool IsEmpty()
    {
      if (Front == null) return true;
      else return false;
    }

    public void Enqueue(T val)
    {
      Node<T> node = new Node<T>(val);
      if (Front == null)
      {
        Front = node;
      }
      else
      {
        // The back node's next is now the new node.
        Back.Next = node;
      }
      // The back will be the node that is enqueued no matter what.
      Back = node;
    }

    public T Dequeue()
    {
      if (Front == null) throw new NullReferenceException();

      Node<T> currentFront = Front;

      // move the queue back one node (similar to pop)
      Front = Front.Next;

      // return the value of the node that we dequeued.
      return currentFront.Value;
    }
  }
}

