using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphAStarTests
{
    private static Graph<int> MakeDisconnectedGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddVertex(0);
        g.AddVertex(1);
        g.AddVertex(2);
        g.AddVertex(3);
        return g;
    }

    [Fact]
    public void AStar_HandlesUnreachable()
    {
        Graph<int> g = MakeDisconnectedGraph();

        var path = g.AStar(0, 1, (a, b) => 0);

        Assert.Empty(path);
    }

    [Fact]
    public void AStar_FindsOptimalPath()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(0, 1, 1);
        g.AddEdge(1, 2, 1);
        g.AddEdge(0, 2, 10);

        var path = g.AStar(0, 2, (a, b) => 0);

        Assert.Equal(new[] { 0, 1, 2 }, path);
    }
}
