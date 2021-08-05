using CodeChallenge18.Classes;
using CodeChallenge18;
using System;
using Xunit;
using System.Collections.Generic;

namespace CodeChallenge18
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          KaryTree<int> k = new KaryTree<int>(10);
          KaryTree<string> s = new KaryTree<string>("");

          k.Root.Value = 10;
          k.Root.Children.Add(new Node<int>(10));
          k.Root.Children.Add(new Node<int>(3));
          k.Root.Children.Add(new Node<int>(15));

          KaryTree<string> res = FizzBuzz(k, s);
          Assert.Equal("buzz", res.Root.Value);
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
