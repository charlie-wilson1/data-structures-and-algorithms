using CodeChallenge18.Classes;
using System;
using System.Collections.Generic;

namespace CodeChallenge18
{
  class Program
  {
    static void Main(string[] args)
    {
    }

    public KaryTree<string> FizzBuzz(KaryTree<int> IntTree, KaryTree<string> StringTree)
    {
      if (IntTree.Root != null)
      {
      addValues(IntTree.Root, StringTree.Root);
      }
      return StringTree;
    }

      public void addValues(Node<int> IntTarget, Node<string> StringTarget)
      {
        Node<string> n = Convert(IntTarget);
        StringTarget = n;
        if (IntTarget.Children == null) return;

        foreach(Node<int> intChild in IntTarget.Children)
        {
          Node<string> stringChild = new Node<string>("");
          StringTarget.Children.Add(stringChild);
          addValues(intChild, stringChild);
        }
      }

    public Node<string> Convert(Node<int> node)
    {
      if ((node.Value % 3 == 0) && (node.Value % 5 == 0))
      {
        Node<string> val = new Node<string>(node.Value.ToString("fizzbuzz"));
        return val;
      }
      else if (node.Value % 3 == 0)
      {
        Node<string> val = new Node<string>(node.Value.ToString("fizz"));
        return val;
      }
      else if (node.Value % 5 == 0)
      {
        Node<string> val = new Node<string>(node.Value.ToString("fizz"));
        return val;
      }
      else
      {
        Node<string> val = new Node<string>(node.Value.ToString());
        return val;
      }
    }
  }
}
