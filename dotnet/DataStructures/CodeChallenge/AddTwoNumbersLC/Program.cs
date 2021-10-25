using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge18.Classes;

namespace AddTwoNumbersLC
{
  class Node<T>
  {
    public T Value { get; set; }

    public Node<T> Next { get; set; }

    public Node(T val)
    {
      Value = val;
    }
  }
    class Program
    {
        static void Main(string[] args)
        {

        }

    // NAIVE SOLUTION
      static int AddTwoNumbers(Node<int> node, Node<int> node2)
      {
        List<int> l1 = new List<int>();
        List<int> l2 = new List<int>();

        while (node != null)
        {
          l1.Add(node.Value);
          node = node.Next;
        }

      return 1;
    }
  }
}
