using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph.Classes
{
  public class Vertex<T>
  {
    public T Value { get; set; }
    public Vertex(T value)
    {
      //Constructor
      Value = value;
    }
  }
    public class Edge<T>
    {
      public int Weight { get; set; }
      public Vertex<T> Vertex { get; set; }

      public Edge(Vertex<T> vertex, int weight)
      {
        Vertex = vertex;
        Weight = weight;
      }
    }

    public class Graph<T>
    {
      private int _size;

      public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyLists { get; set; }

      // Graph constructor. Creates new adjacency lists as well as the size of the graph.
      public Graph()
      {
        AdjacencyLists = new Dictionary<Vertex<T>, List<Edge<T>>>();
        _size = 0;
      }

      public Vertex<T> AddNode(T value)
      {
        Vertex<T> Vertex = new(value);
        AdjacencyLists.Add(Vertex, new List<Edge<T>>());
        _size++;
        return Vertex;
      }

      public void AddEdge(Vertex<T> sourceVertex, Vertex<T> destVertex, int weight)
      {
        AddDirectionalEdge(sourceVertex, destVertex, weight);
        AddDirectionalEdge(destVertex,sourceVertex, weight);
      }
     public void AddDirectionalEdge(Vertex<T> sourceVertex, Vertex<T> destVertex, int weight)
      {
        List<Edge<T>> edges = AdjacencyLists[sourceVertex];
        edges.Add(
          new Edge<T>(destVertex, weight)
          );
      }

      public List<Vertex<T>> GetNodes()
      {
        int listNum = 1;

        // shorthand instance constructor 
        List<Vertex<T>> allVertices = new();

        foreach(Vertex<T> vertex in AdjacencyLists.Keys)
        {
          Console.WriteLine($"Vertex {listNum}: {vertex.Value} => ");
          allVertices.Add(vertex);
          listNum++;
        }
        // if no values exist within the adjacency list key, return null.
        if (allVertices.Count <= 0) { return null; }

        else return allVertices;
      }

      public List<Vertex<T>> GetNeighbors(Vertex<T> vertex)
      {
        var neighborAdjacencyList = AdjacencyLists[vertex];
        List<Vertex<T>> neighborList = new();

        foreach(Edge<T> edge in neighborAdjacencyList)
        {
          neighborList.Add(edge.Vertex);
        }
        return neighborList;
      }

      public int GetSize()
      {
        return _size;
      }

      public void Print()
      {
        foreach (var key in AdjacencyLists)
        {
          Console.Out.Write($"{key.Key.Value} ->");
          var adjacencyList = AdjacencyLists[key.Key];

          foreach (Edge<T> edge in adjacencyList)
          {
            Console.Out.Write($"{edge.Vertex.Value}, {edge.Weight} ->");
          }
          Console.Out.WriteLine("null");
        }
      }

    }
  }

