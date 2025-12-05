using System.Linq;
using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphFindAllPathsTests
{
    [Fact]
    public void FindAllPaths_FindsAllPaths()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(2, 3);

        var paths = g.FindAllPaths(0, 3);

        Assert.Equal(2, paths.Count);
        Assert.Contains(paths, p => p.SequenceEqual(new[] { 0, 1, 3 }));
        Assert.Contains(paths, p => p.SequenceEqual(new[] { 0, 2, 3 }));
    }
}
