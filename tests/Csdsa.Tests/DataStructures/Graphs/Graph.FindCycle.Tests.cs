using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphFindCycleTests
{
    private static Graph<int> MakeDirectedCycleGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddEdge(0, 1, 1);
        g.AddEdge(1, 2, 1);
        g.AddEdge(2, 0, 1);
        return g;
    }

    [Fact]
    public void FindCycle_ReturnsCycle()
    {
        Graph<int> g = MakeDirectedCycleGraph();

        var cycle = g.FindCycle();

        Assert.True(cycle.Count > 0);
        Assert.True(g.IsConnected(cycle[^1], cycle[0]));
    }
}
