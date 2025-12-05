using System.Linq;
using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphConnectivityTests
{
    private static Graph<int> MakeSimplePathGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddEdge(0, 1, 2);
        g.AddEdge(1, 2, 3);
        g.AddEdge(2, 3, 4);
        return g;
    }

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
    public void IsGraphConnected_TrueForConnected()
    {
        Graph<int> g = MakeSimplePathGraph();

        Assert.True(g.IsGraphConnected());
    }

    [Fact]
    public void IsGraphConnected_FalseForDisconnected()
    {
        Graph<int> g = MakeDisconnectedGraph();

        Assert.False(g.IsGraphConnected());
    }

    [Fact]
    public void ConnectedComponents_FindsAll()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(0, 1);
        g.AddEdge(2, 3);

        var comps = g.ConnectedComponents();

        Assert.Equal(2, comps.Count);
        Assert.All(comps, c => Assert.True(c.Count >= 2));
    }

    [Fact]
    public void CountConnectedComponents_CorrectCount()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(0, 1);
        g.AddEdge(2, 3);
        g.AddVertex(4);

        int count = g.CountConnectedComponents();

        Assert.Equal(3, count);
    }
}
