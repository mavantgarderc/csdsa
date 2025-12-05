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
    public void MultiSourceBfs_Works()
    {
        Graph<int> graph = CreateSimpleGraph();
        List<int> sources = new List<int> { 0, 2 };

        int[] distances = Bfs.MultiSourceBfs(graph, sources);

        Assert.Equal(0, distances[0]);
        Assert.Equal(1, distances[1]);
        Assert.Equal(0, distances[2]);
        Assert.Equal(1, distances[3]);
    }
}
