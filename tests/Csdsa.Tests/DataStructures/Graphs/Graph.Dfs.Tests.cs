using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphDfsTests
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
    public void DFS_HandlesDisconnected()
    {
        Graph<int> g = MakeDisconnectedGraph();

        var dfs = g.DFS(2);

        Assert.Single(dfs);
    }

    [Fact]
    public void DFS_Recursive_HandlesCycles()
    {
        Graph<int> g = MakeDirectedCycleGraph();

        var dfs = g.DFS_Recursive(0);

        Assert.Equal(3, dfs.Count);
    }
}
