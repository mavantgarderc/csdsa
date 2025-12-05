using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphShortestPathBfsTests
{
    [Fact]
    public void ShortestPathBFS_FindsShortest()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(0, 1);
        g.AddEdge(1, 2);
        g.AddEdge(0, 2);

        var path = g.ShortestPathBFS(0, 2);

        Assert.Equal(new[] { 0, 2 }, path);
    }
}
