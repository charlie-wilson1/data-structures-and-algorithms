using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackandqueue.Classes
{
  public class Node<T> // very similar to c++ classes. can assign values as well as a constructor.
  {
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value) // constructor for node that allows you to set the value.
    {
      Value = value;
    }
    // example: Node mynode = new Node(5); this can be used in other class definitions.
  }
}
