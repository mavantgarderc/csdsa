using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphHasCycleTests
{
    private static Graph<int> MakeDirectedCycleGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddEdge(0, 1, 1);
        g.AddEdge(1, 2, 1);
        g.AddEdge(2, 0, 1);
        return g;
    }

    private static Graph<int> MakeSimplePathGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddEdge(0, 1, 2);
        g.AddEdge(1, 2, 3);
        g.AddEdge(2, 3, 4);
        return g;
    }

    [Fact]
    public void HasCycle_TrueForCycle()
    {
        Graph<int> g = MakeDirectedCycleGraph();

        Assert.True(g.HasCycle());
    }

    [Fact]
    public void HasCycle_FalseForAcyclic()
    {
        Graph<int> g = MakeSimplePathGraph();

        Assert.False(g.HasCycle());
    }

    [Fact]
    public void HasCycle_UndirectedGraph()
    {
        Graph<int> g = new Graph<int>(isDirected: false);

        g.AddEdge(0, 1);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);

        Assert.True(g.HasCycle());
    }
}
