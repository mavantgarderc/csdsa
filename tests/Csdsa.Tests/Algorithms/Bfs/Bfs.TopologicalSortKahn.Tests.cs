using System;
using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class BfsTests
{
    [Fact]
    public void TopologicalSortKahn_WorksOnDag()
    {
        Graph<int> graph = new Graph<int>(isDirected: true);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 3);

        IReadOnlyList<int> topo = Bfs.TopologicalSortKahn(graph);
        List<int> topoList = topo.ToList();

        Assert.Equal(4, topoList.Count);
        Assert.True(topoList.IndexOf(0) < topoList.IndexOf(1));
        Assert.True(topoList.IndexOf(0) < topoList.IndexOf(2));
        Assert.True(topoList.IndexOf(1) < topoList.IndexOf(3));
        Assert.True(topoList.IndexOf(2) < topoList.IndexOf(3));
    }
}
