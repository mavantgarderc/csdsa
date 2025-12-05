using System.Linq;
using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphKruskalMstTests
{
    [Fact]
    public void KruskalMST_IncludesAllNodes()
    {
        Graph<int> g = new Graph<int>(isDirected: false);

        g.AddEdge(0, 1, 1);
        g.AddEdge(1, 2, 2);
        g.AddEdge(2, 3, 3);
        g.AddEdge(0, 3, 4);

        var mst = g.KruskalMST();
        var vertices = mst.SelectMany(e => new[] { e.src, e.dst }).Distinct().ToList();

        Assert.True(vertices.Count >= 4);
        Assert.Equal(3, mst.Count);
    }
}
