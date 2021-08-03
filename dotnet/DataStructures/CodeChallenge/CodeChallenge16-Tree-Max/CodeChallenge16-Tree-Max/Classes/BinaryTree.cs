using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge16_Tree_Max.Classes
{
  class BinaryTree
  {
    Node<int> Root { get; set; }

    int GetMax(Node<int> root)
    {
      int CurrentMax = root.Value;
      if (root.Left != null)
      {
        int temp = GetMax(root.Left);
        if (temp > CurrentMax)
        {
          CurrentMax = temp;
        }
      }
      if (root.Right != null)
      {
        int temp = GetMax(root.Right);
        if (temp > CurrentMax)
        {
          CurrentMax = temp;
        }
      }
      // send back to local max.
      return CurrentMax;
    }
  }
}
