using System;
using System.Collections.Generic;

namespace MaxDepthBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
          TreeNode node = new();

        }

        public static int MaxDepthBinaryTree(TreeNode root)
        {
          if (root == null) return 0;
          return Math.Max(MaxDepthBinaryTree(root.left), MaxDepthBinaryTree(root.right)) + 1;
        }

    }

  // class being used with MaxDepthBinaryTree
    class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;

    // Constructor for treenode class
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }
}
