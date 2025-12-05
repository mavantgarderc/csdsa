using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphCountPathsTests
{
    [Fact]
    public void CountPaths_CorrectCount()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 3);

        int count = g.CountPaths(0, 3);

        Assert.Equal(2, count);
    }
}
