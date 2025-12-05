using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphAddVertexTests
{
    [Fact]
    public void AddVertex_Idempotent()
    {
        Graph<int> g = new Graph<int>();

        g.AddVertex(1);
        g.AddVertex(1);

        Assert.Empty(g.GetNeighbors(1));
    }

    [Fact]
    public void VertexCount_ReturnsCorrectCount()
    {
        Graph<int> g = new Graph<int>();

        Assert.Equal(0, g.VertexCount);

        g.AddVertex(1);
        g.AddVertex(2);

        Assert.Equal(2, g.VertexCount);
    }
}
