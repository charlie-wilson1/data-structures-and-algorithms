using CodeChallenge18.Classes;
using CodeChallenge18;
using System;
using Xunit;
using System.Collections.Generic;

namespace CodeChallenge18
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          KaryTree<int> k = new KaryTree<int>(10);

          k.Root.Value = 10;
          k.Root.Children.Add(new Node<int>(10));
          k.Root.Children.Add(new Node<int>(3));
          k.Root.Children.Add(new Node<int>(15));

          KaryTree<string> res = k.FizzBuzz(k);

          Assert.Equal("buzz", res.Root.Value);
        }

  }
}
