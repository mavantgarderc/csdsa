using System;
using System.Collections.Generic;
using System.Linq;

using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class BfsTests
{
    [Fact]
    public void GraphBfs_Works()
    {
        Graph<int> graph = CreateSimpleGraph();

        IReadOnlyList<int> traversal = graph.BFS(0);

        Assert.Equal(4, traversal.Count);
        Assert.Equal(0, traversal[0]);
        Assert.Contains(1, traversal);
        Assert.Contains(2, traversal);
        Assert.Contains(3, traversal);
    }

    [Fact]
    public void ShortestPathBfs_Works()
    {
        Graph<int> graph = CreateSimpleGraph();

        IReadOnlyList<int> path = graph.ShortestPathBFS(0, 2);

        Assert.Equal(3, path.Count);
        Assert.Equal(0, path[0]);
        Assert.Equal(2, path[2]);

        // Path should be either [0,1,2] or [0,3,2]
        Assert.True(
            path.SequenceEqual(new[] { 0, 1, 2 })
            || path.SequenceEqual(new[] { 0, 3, 2 }));
    }

    [Fact]
    public void ConnectedComponents_GraphMethod_Works()
    {
        Graph<int> graph = new Graph<int>(isDirected: false);
        graph.AddEdge(0, 1);
        graph.AddEdge(2, 3);

        IReadOnlyList<IReadOnlyList<int>> components = graph.ConnectedComponents();

        Assert.Equal(2, components.Count);
        Assert.Contains(components, c => c.Contains(0) && c.Contains(1));
        Assert.Contains(components, c => c.Contains(2) && c.Contains(3));
    }

    [Fact]
    public void IsGraphConnected_Works()
    {
        Graph<int> connectedGraph = CreateSimpleGraph();
        Assert.True(connectedGraph.IsGraphConnected());

        Graph<int> disconnectedGraph = new Graph<int>(isDirected: false);
        disconnectedGraph.AddEdge(0, 1);
        disconnectedGraph.AddEdge(2, 3);

        Assert.False(disconnectedGraph.IsGraphConnected());
    }

    [Fact]
    public void StringGraph_Bfs_Works()
    {
        Graph<string> graph = new Graph<string>(isDirected: false);
        graph.AddEdge("A", "B");
        graph.AddEdge("B", "C");
        graph.AddEdge("A", "D");
        graph.AddEdge("D", "C");

        IReadOnlyList<string> traversal = graph.BFS("A");
        Assert.Equal(4, traversal.Count);
        Assert.Equal("A", traversal[0]);
        Assert.Contains("B", traversal);
        Assert.Contains("C", traversal);
        Assert.Contains("D", traversal);

        IReadOnlyList<string> path = graph.ShortestPathBFS("A", "C");
        Assert.Equal(3, path.Count);
        Assert.Equal("A", path[0]);
        Assert.Equal("C", path[2]);
    }
}
