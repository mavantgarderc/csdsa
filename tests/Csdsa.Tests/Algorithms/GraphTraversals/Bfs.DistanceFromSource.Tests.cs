using System;
using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class BfsTests
{
    private static Graph<int> CreateSimpleGraph()
    {
        // 0 -- 1 -- 2
        // |         |
        // +----3----+
        Graph<int> graph = new Graph<int>(isDirected: false);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(0, 3);
        graph.AddEdge(3, 2);
        return graph;
    }

    [Fact]
    public void DistanceFromSource_Works()
    {
        Graph<int> graph = CreateSimpleGraph();

        int[] distances = Bfs.DistanceFromSource(graph, 0);

        // 0:0, 1:1, 2:2, 3:1
        Assert.Equal(0, distances[0]);
        Assert.Equal(1, distances[1]);
        Assert.Equal(2, distances[2]);
        Assert.Equal(1, distances[3]);
    }
}
