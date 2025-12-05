using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphReverseGraphTests
{
    private static Graph<int> MakeSimplePathGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddEdge(0, 1, 2);
        g.AddEdge(1, 2, 3);
        g.AddEdge(2, 3, 4);
        return g;
    }

    [Fact]
    public void ReverseGraph_ReversesAllEdges()
    {
        Graph<int> g = MakeSimplePathGraph();

        g.ReverseGraph();

        Assert.Empty(g.GetNeighbors(0));
        Assert.Equal(new[] { 0 }, g.GetNeighbors(1));
        Assert.Equal(new[] { 1 }, g.GetNeighbors(2));
        Assert.Equal(new[] { 2 }, g.GetNeighbors(3));
    }
}
