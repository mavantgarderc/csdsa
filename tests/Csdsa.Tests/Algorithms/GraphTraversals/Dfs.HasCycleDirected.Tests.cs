using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class DfsTests
{
    [Fact]
    public void HasCycleDirected_ReturnsFalse_ForAcyclicDirectedGraph()
    {
        Graph<int> graph = CreateDag();

        bool hasCycle = Dfs.HasCycleDirected(graph);

        Assert.False(hasCycle);
    }

    [Fact]
    public void HasCycleDirected_ReturnsTrue_ForDirectedCycle()
    {
        Graph<int> graph = new Graph<int>(isDirected: true);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 0);

        bool hasCycle = Dfs.HasCycleDirected(graph);

        Assert.True(hasCycle);
    }
}
