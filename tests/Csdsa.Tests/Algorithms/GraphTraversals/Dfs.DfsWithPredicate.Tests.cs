using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class DfsTests
{
    [Fact]
    public void DfsWithPredicate_ReturnsDepth_WhenMatchExists()
    {
        Graph<int> graph = CreateSimpleGraph();

        int depth = Dfs.DFSWithPredicate(graph, 0, u => u == 2);

        // In the simple graph, a DFS from 0 will reach 2 with depth 2.
        Assert.Equal(2, depth);
    }

    [Fact]
    public void DfsWithPredicate_ReturnsMinusOne_WhenNoMatchExists()
    {
        Graph<int> graph = CreateSimpleGraph();

        int depth = Dfs.DFSWithPredicate(graph, 0, u => u == 99);

        Assert.Equal(-1, depth);
    }
}
