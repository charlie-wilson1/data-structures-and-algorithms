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
        return vals;
          
        }
    }
}
