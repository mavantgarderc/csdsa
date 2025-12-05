using System;
using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphBellmanFordTests
{
    [Fact]
    public void BellmanFord_NegativeCycleThrows()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(0, 1, 1);
        g.AddEdge(1, 2, -2);
        g.AddEdge(2, 0, -2);

        Assert.Throws<Exception>(() => g.BellmanFord(0, 2));
    }

    [Fact]
    public void BellmanFord_FindsPath()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(0, 1, 1);
        g.AddEdge(1, 2, 1);

        var path = g.BellmanFord(0, 2);

        Assert.Equal(new[] { 0, 1, 2 }, path);
    }
}
