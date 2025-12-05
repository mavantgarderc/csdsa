using System;
using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphTopologicalSortTests
{
    private static Graph<int> MakeSimplePathGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddEdge(0, 1, 2);
        g.AddEdge(1, 2, 3);
        g.AddEdge(2, 3, 4);
        return g;
    }

    private static Graph<int> MakeDirectedCycleGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddEdge(0, 1, 1);
        g.AddEdge(1, 2, 1);
        g.AddEdge(2, 0, 1);
        return g;
    }

    [Fact]
    public void TopologicalSort_ThrowsOnCycle()
    {
        Graph<int> g = MakeDirectedCycleGraph();

        Assert.Throws<Exception>(() => g.TopologicalSort());
    }

    [Fact]
    public void TopologicalSort_RespectsOrder()
    {
        Graph<int> g = MakeSimplePathGraph();

        var order = g.TopologicalSort();

        Assert.True(order.IndexOf(0) < order.IndexOf(1));
        Assert.True(order.IndexOf(1) < order.IndexOf(2));
        Assert.True(order.IndexOf(2) < order.IndexOf(3));
    }
}
