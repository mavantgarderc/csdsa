using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class DfsTests
{
    [Fact]
    public void AllPathsDfs_FindsAllSimplePaths_InDag()
    {
        Graph<int> graph = CreateDag();

        IReadOnlyList<IReadOnlyList<int>> paths = Dfs.AllPathsDFS(graph, 0, 3, maxDepth: 4);

        Assert.Equal(2, paths.Count);

        List<int>[] expectedPaths =
        {
            new List<int> { 0, 1, 3 },
            new List<int> { 0, 2, 3 },
        };

        Assert.All(
            expectedPaths,
            expected => Assert.Contains(paths, p => p.SequenceEqual(expected)));
    }

    [Fact]
    public void AllPathsDfs_RespectsMaxDepth()
    {
        Graph<int> graph = CreateDag();

        // With maxDepth = 2, no path from 0 to 3 fits (paths are length 3).
        IReadOnlyList<IReadOnlyList<int>> paths = Dfs.AllPathsDFS(graph, 0, 3, maxDepth: 2);

        Assert.Empty(paths);
    }
}
