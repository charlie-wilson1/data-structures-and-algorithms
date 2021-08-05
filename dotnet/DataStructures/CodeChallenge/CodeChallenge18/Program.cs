using CodeChallenge18.Classes;
using System;
using System.Collections.Generic;

namespace CodeChallenge18
{
  class Program
  {
    static void Main(string[] args)
    {
      KaryTree<int> IntTree = new KaryTree<int>(10);

      IntTree.Root.Value = 10;
      IntTree.Root.Children.Add(new Node<int>(10));
      IntTree.Root.Children.Add(new Node<int>(3));
      IntTree.Root.Children.Add(new Node<int>(15));

      KaryTree<string> StringTree = IntTree.FizzBuzz(IntTree);

      foreach (Node<string> val in StringTree.Root.Children)
      {
        Console.WriteLine($"{val.Value} ");
      }
    }

  }
}
