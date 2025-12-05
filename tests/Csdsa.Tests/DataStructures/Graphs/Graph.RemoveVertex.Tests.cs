using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphRemoveVertexTests
{
    [Fact]
    public void RemoveVertex_RemovesAllIncidentEdges()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(1, 2);
        g.AddEdge(2, 1);

        g.RemoveVertex(2);

        Assert.False(g.IsConnected(1, 2));
        Assert.False(g.IsConnected(2, 1));
    }

    [Fact]
    public void RemoveVertex_NonexistentVertexDoesNotThrow()
    {
        Graph<int> g = new Graph<int>();

        g.AddVertex(1);

        g.RemoveVertex(999);

        Assert.True(g.GetNeighbors(1) is System.Collections.Generic.List<int>);
    }
}
