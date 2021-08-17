using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stackandqueue.Classes;

namespace stackandqueue
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public List<T> PreOrderTraversal(Node<T> root, List<T> vals)
        {
            if (root.Value != null)
            {
              vals.Add(root.Value);
              vals = PreOrderTraversal(root.Left, vals);
              vals = PreOrderTraversal(root.Right, vals);
            }
        return vals;
        }

        public List<T> InOrderTraversal(Node<T> root, List<T> vals)
        {
            if (root.Value != null)
            {
              vals = InOrderTraversal(root.Left, vals);
              vals.Add(root.Value);
              vals = InOrderTraversal(root.Right, vals);
            }
        return vals;
        }

        public List<T> PostOrderTraversal(Node<T> root, List<T> vals)
        {
            if (root.Value != null)
            {
              vals = PostOrderTraversal(root.Left, vals);
              vals = PostOrderTraversal(root.Right, vals);
              vals.Add(root.Value);
            }
            else
            {
                
            }
        return vals;
        }
    public List<Node<int>> LevelOrderTraversal(Node<int> root)
    {
      // Create a new list.
      List<Node<int>> list = new List<Node<int>>();
      Queue<Node<int>> q = new Queue<Node<int>>();
      q.Enqueue(root);
      
      while (q.Count > 0)
      {
        Node<int> current = q.Dequeue();
        if (current == null) continue; // negates the value from being created if null.
        q.Enqueue(current.Left);
        q.Enqueue(current.Right);

        list.Add(current);
      }
      return list;
    }
    }
}
