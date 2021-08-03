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
      // Set current max to the value of the root.
      int CurrentMax = root.Value;
      // If the left root is not equal to null..
      if (root.Left != null)
      {
        // set temp variable to root.left value (recursive)
        int temp = GetMax(root.Left);
        // if that temp value is greater than the current max ("root" val)
        if (temp > CurrentMax)
        {
          // set that num to the new current max.
          CurrentMax = temp;
        }
      }
      // Do the same for the other side.
      if (root.Right != null)
      {
        int temp = GetMax(root.Right);
        if (temp > CurrentMax)
        {
          CurrentMax = temp;
        }
      }
      // send back to local max. This returns the call stack to the "temp" value.
      return CurrentMax;
    }
  }
}
