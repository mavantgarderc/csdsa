using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class DfsTests
{
    [Fact]
    public void HasCycleUnidirected_ReturnsFalse_ForAcyclicUndirectedGraph()
    {
        Graph<int> graph = new Graph<int>(isDirected: false);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);

        bool hasCycle = Dfs.HasCycleUndirected(graph);

        Assert.False(hasCycle);
    }

    [Fact]
    public void HasCycleUnidirected_ReturnsTrue_ForUndirectedCycle()
    {
        Graph<int> graph = CreateSimpleGraph();

        bool hasCycle = Dfs.HasCycleUndirected(graph);

        Assert.True(hasCycle);
    }
}
