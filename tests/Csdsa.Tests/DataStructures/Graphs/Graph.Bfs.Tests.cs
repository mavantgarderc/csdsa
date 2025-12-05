using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphBfsTests
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

    private static Graph<int> MakeDirectedCycleGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddEdge(0, 1, 1);
        g.AddEdge(1, 2, 1);
        g.AddEdge(2, 0, 1);
        return g;
    }

    [Fact]
    public void BFS_HandlesDisconnected()
    {
        Graph<int> g = MakeDisconnectedGraph();

        var bfs = g.BFS(0);

        Assert.Single(bfs);
    }

    [Fact]
    public void BFS_HandlesCycles()
    {
        Graph<int> g = MakeDirectedCycleGraph();

        var bfs = g.BFS(0);

        Assert.Equal(3, bfs.Count);
        Assert.Contains(0, bfs);
        Assert.Contains(1, bfs);
        Assert.Contains(2, bfs);
    }
}
