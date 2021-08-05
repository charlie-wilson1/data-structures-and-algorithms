using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge18.Classes;

namespace CodeChallenge18
{
  public class KaryTree<T>
  {
    public Node<T> Root { get; set; }

    public KaryTree(T root)
    {
      Root = new Node<T>(root);
      Root.Children = new List<Node<T>>();
    }

    public KaryTree<string> FizzBuzz(KaryTree<int> IntTree)
    {
      KaryTree<string> StringTree = new KaryTree<string>("");
      if (IntTree.Root != null)
      {
      addValues(IntTree.Root, StringTree.Root);
      }
      return StringTree;
    }

      public void addValues(Node<int> IntTarget, Node<string> StringTarget)
      {
        Node<string> n = Convert(IntTarget);
        StringTarget.Value = n.Value;
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
        Node<string> val = new Node<string>(node.Value.ToString("buzz"));
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
