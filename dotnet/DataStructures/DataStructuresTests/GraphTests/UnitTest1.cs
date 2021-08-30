using System;
using Xunit;
using Graph;
using Graph.Classes;
using System.Collections.Generic;

namespace GraphTests
{
    public class UnitTest1
    {
    [Fact]
    static void CanGraphAndGetNodesTest()
    {

      Graph<string> graph = new Graph<string>();

      var aNode = graph.AddNode("A");
      var bNode = graph.AddNode("B");
      var cNode = graph.AddNode("C");
      var dNode = graph.AddNode("D");
      var eNode = graph.AddNode("E");

      graph.AddEdge(aNode, bNode, 2);
      graph.AddEdge(aNode, cNode, 4);
      graph.AddEdge(bNode, cNode, 5);
      graph.AddEdge(dNode, eNode, 8);
      graph.AddEdge(aNode, eNode, 3);

      List<Vertex<string>> allVertex = new();
      allVertex.Add(aNode);
      allVertex.Add(bNode);
      allVertex.Add(cNode);
      allVertex.Add(dNode);
      allVertex.Add(eNode);

      Assert.Equal(allVertex, graph.GetNodes());
    }

    [Fact]
    static void CanGraphOneTest()
    {
      Graph<string> graph = new Graph<string>();

      var aNode = graph.AddNode("A");

      List<Vertex<string>> allVertex = new();
      allVertex.Add(aNode);

      Assert.Equal(allVertex, graph.GetNodes());
    }

    [Fact]
    static void CanCatchNull()
    {
      Graph<string> graph = new Graph<string>();

      Assert.Null(graph.GetNodes());
    }
  }
}
