using System;
using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class BfsTests
{
    [Fact]
    public void DetectCycleUndirected_ReturnsFalseForAcyclic()
    {
        Graph<int> graph = new Graph<int>(isDirected: false);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);

        bool hasCycle = Bfs.DetectCycleUndirected(graph);

        Assert.False(hasCycle);
    }

    [Fact]
    public void DetectCycleUndirected_ReturnsTrueForCycle()
    {
        Graph<int> graph = new Graph<int>(isDirected: false);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 0);

        bool hasCycle = Bfs.DetectCycleUndirected(graph);

        Assert.True(hasCycle);
    }
}
