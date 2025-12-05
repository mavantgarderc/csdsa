using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphAddEdgeTests
{
    [Fact]
    public void AddAndRemoveEdge()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(1, 2);

        Assert.True(g.IsConnected(1, 2));

        g.RemoveEdge(1, 2);

        Assert.False(g.IsConnected(1, 2));
    }

    [Fact]
    public void RemoveEdge_NonexistentEdgeDoesNotThrow()
    {
        Graph<int> g = new Graph<int>();

        g.AddVertex(1);
        g.AddVertex(2);

        g.RemoveEdge(1, 2);

        Assert.True(g.GetNeighbors(1) is System.Collections.Generic.List<int>);
    }

    [Fact]
    public void EdgeCount_ReturnsCorrectCount()
    {
        Graph<int> g = new Graph<int>();

        Assert.Equal(0, g.EdgeCount);

        g.AddEdge(1, 2);

        Assert.Equal(1, g.EdgeCount);
    }

    [Fact]
    public void EdgeCount_UndirectedGraph()
    {
        Graph<int> g = new Graph<int>(isDirected: false);

        g.AddEdge(1, 2);

        Assert.Equal(1, g.EdgeCount);
    }

    [Fact]
    public void HasEdge_DetectsEdgeExistence()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(1, 2);

        Assert.True(g.HasEdge(1, 2));
        Assert.False(g.HasEdge(2, 1));
    }
}
