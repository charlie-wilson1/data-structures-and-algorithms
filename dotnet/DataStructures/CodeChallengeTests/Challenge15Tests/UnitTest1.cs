using System;
using Xunit;
using stackandqueue;
using stackandqueue.Classes;

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

    }
    }
}
