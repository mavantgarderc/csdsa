using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphToDotTests
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
    public void ToDot_CorrectFormat()
    {
        Graph<int> g = MakeSimplePathGraph();

        string dot = g.ToDot();

        Assert.Contains("digraph G", dot);
        Assert.Contains("0 -> 1", dot);
        Assert.Contains("1 -> 2", dot);
        Assert.Contains("2 -> 3", dot);
        Assert.Contains("}", dot);
    }
}
