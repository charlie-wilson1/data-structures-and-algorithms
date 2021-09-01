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
   
    [Fact]
     static void CanAddNodesAndEdges()
    {
      Graph<int> testGraph = new();
      Vertex<int> node1 = testGraph.AddNode(7);
      Vertex<int> node2 = testGraph.AddNode(9);
      Vertex<int> node3 = testGraph.AddNode(3);
      testGraph.AddEdge(node1, node2, 12);
      testGraph.AddEdge(node2, node3, 36);
      testGraph.AddEdge(node3, node1, 24);
      List<Vertex<int>> nodeNeighbors = testGraph.GetNeighbors(node1);
      Assert.Equal(node2, nodeNeighbors[0]);
      List<Vertex<int>> allNodes = testGraph.GetNodes();
      Assert.Equal(node1, allNodes[0]);
      Assert.Equal(node2, allNodes[1]);
      Assert.Equal(node3, allNodes[2]);
    }

    [Fact]
    public void CanTrackSize()
    {
      Graph<int> testGraph = new();
      Assert.Equal(0, testGraph.GetSize());
      testGraph.AddNode(7);
      testGraph.AddNode(9);
      testGraph.AddNode(3);
      Assert.Equal(3, testGraph.GetSize());

     
  }
}
