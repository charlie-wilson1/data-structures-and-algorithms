using stackandqueue;
using stackandqueue.Classes;
using System;

namespace CodeChallenge15
{
    class Program
    {
        static void Main(string[] args)
        {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      Node<int> node = new Node<int>(2);
      tree.Root = node;
      tree.Add(node, 2);
      tree.Add(node, 3);
      tree.Add(node, 5);
      tree.Add(node, 9);

      Console.WriteLine(tree.LevelOrderTraversal(node));
        }
    }
}
