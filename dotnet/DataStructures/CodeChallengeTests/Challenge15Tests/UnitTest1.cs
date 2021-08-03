using System;
using Xunit;
using stackandqueue;
using stackandqueue.Classes;
using System.Collections.Generic;

namespace CodeChallenge15
{
    public class UnitTest1
    {
        [Fact]
        public void CanMakeEmptyTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(1);
            Assert.Equal(1, tree.Root.Value);
        }

    [Fact]
    public void CanAddLeftAndRightNode()
    {
        BinaryTree<int> tree = new BinaryTree<int>();
        tree.Root = new Node<int>(1);
        tree.Root.Left = new Node<int>(6);
        tree.Root.Right = new Node<int>(10);
        Assert.Equal(6, tree.Root.Left.Value);
        Assert.Equal(10, tree.Root.Right.Value);
    }

    [Fact]

    public void CanTraverseInThreeWays()
      {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Root = new Node<int>(1);
        List<int> list = new List<int>(tree.Root.Value);
        
      tree.Add(tree.Root, 1);
      tree.Add(tree.Root, 2);
      tree.Add(tree.Root, 5);
      tree.Add(tree.Root, 4);
      tree.Add(tree.Root, 7);
      tree.Add(tree.Root, 8);

      //List<int> InOrder = tree.InOrderTraversal(tree.Root, list);
      List<int> PreOrder = tree.PreOrderTraversal(tree.Root, list);
      List<int> PostOrder = tree.PostOrderTraversal(tree.Root, list);

      //Assert.NotEmpty(InOrder);
      Assert.NotEmpty(PreOrder);
      Assert.NotEmpty(PostOrder);
      }

    [Fact]
    public void CanLevelOrderTraverse()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        Node<int> node = new Node<int>(2);
        tree.Root = node;
        tree.Add(node, 2);
        tree.Add(node, 1);
        tree.Add(node, 5);
        tree.Add(node, 9);
      Assert.NotEmpty(tree.LevelOrderTraversal(tree.Root));
    }
  }
}
