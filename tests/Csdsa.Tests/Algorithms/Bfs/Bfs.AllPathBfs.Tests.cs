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
    public void AllPathsBfs_Works()
    {
        // 0 -> 1 -> 3
        //   \> 2 -/
        Graph<int> graph = new Graph<int>(isDirected: true);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 3);
        graph.AddEdge(0, 2);
        graph.AddEdge(2, 3);

        IReadOnlyList<IReadOnlyList<int>> paths = Bfs.AllPathsBfs(graph, 0, 3, maxDepth: 4);

        List<List<int>> expected =
        [
            new List<int> { 0, 1, 3 },
            new List<int> { 0, 2, 3 },
        ];

        Assert.Equal(2, paths.Count);
        Assert.All(
            expected,
            p => Assert.Contains(paths, x => x.SequenceEqual(p)));
    }
}
