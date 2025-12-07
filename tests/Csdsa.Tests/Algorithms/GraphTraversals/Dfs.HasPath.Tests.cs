using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class DfsTests
{
    [Fact]
    public void HasPath_ReturnsTrue_WhenPathExists()
    {
        Graph<int> graph = CreateSimpleGraph();

        bool hasPath = Dfs.HasPath(graph, 0, 2);

        Assert.True(hasPath);
    }

    [Fact]
    public void HasPath_ReturnsFalse_WhenPathDoesNotExist()
    {
        Graph<int> graph = CreateSimpleGraph();

        bool hasPath = Dfs.HasPath(graph, 0, 99);

        Assert.False(hasPath);
    }
}
