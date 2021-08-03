using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stackandqueue.Classes;

namespace stackandqueue
{
    class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
    //Make a node out of that value
    // `1. If we do not have root, make that node root and be finished
    // If the value is < than node you're looking at
        // Try and add value to the left
        // If we don't have a left, add and be done.
        // If we do have a left, call method recursively with left node.
    // If the value is > than node you're looking at, same as above

    public void Add(Node<T> node, T value)
    {
      Node<T> newNode = new Node<T>(value);
      if (Root == null)
      {
        Root = newNode;
        return;
      }

      if (newNode.Value.CompareTo(node.Value) < 0)
      {
        if (node.Left == null) { node.Left = newNode; }
        else { Add(node.Left, value); }
      }
      else if (newNode.Value.CompareTo(node.Value) > 0)
      {
        if (node.Right == null) { node.Right = newNode; }
        else { Add(node.Right, value); }
      }
    }

    public bool Contains(T val)
    {
      Node<T> target = Root;
      while (target != null)
      {
        if (target.Value.CompareTo(val) == 0) return true;
        if (target.Value.CompareTo(val) < 0)
        {
          target = target.Left;
        }
        else if (target.Value.CompareTo(val) > 0)
        {
          target = target.Right;
        }
      }
        return false;
    }
  }
}
