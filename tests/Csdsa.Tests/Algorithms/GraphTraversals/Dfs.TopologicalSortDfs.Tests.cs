using System.Collections.Generic;

using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class DfsTests
{
    [Fact]
    public void TopologicalSortDfs_Works_OnDag()
    {
        Graph<int> graph = CreateDag();

        IReadOnlyList<int> topo = Dfs.TopologicalSortDFS(graph);

        Assert.Equal(4, topo.Count);
        Assert.True(topo.IndexOf(0) < topo.IndexOf(1));
        Assert.True(topo.IndexOf(0) < topo.IndexOf(2));
        Assert.True(topo.IndexOf(1) < topo.IndexOf(3));
        Assert.True(topo.IndexOf(2) < topo.IndexOf(3));
    }
}
