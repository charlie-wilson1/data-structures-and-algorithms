using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge16_Tree_Max.Classes
{
  public class Node<T> // very similar to c++ classes. can assign values as well as a constructor.
  {
    public T Value { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }

    // K-Ary tree has list of child nodes that you could loop over

    public Node(T value) // constructor for node that allows you to set the value.
    {
      Value = value;
    }
    // example: Node mynode = new Node(5); this can be used in other class definitions.
  }
}
