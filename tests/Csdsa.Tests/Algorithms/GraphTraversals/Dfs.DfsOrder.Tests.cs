using System.Collections.Generic;

using Csdsa.Algorithms.GraphTraversal;
using Csdsa.DataStructures.Graphs;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class DfsTests
{
    private static Graph<int> CreateSimpleGraph()
    {
        // 0 -- 1 -- 2
        // |         |
        // +----3----+
        Graph<int> graph = new Graph<int>(isDirected: false);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(0, 3);
        graph.AddEdge(3, 2);
        return graph;
    }

    private static Graph<int> CreateDag()
    {
        // 0 -> 1 -> 3
        //   \> 2 -/
        Graph<int> graph = new Graph<int>(isDirected: true);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 3);
        graph.AddEdge(0, 2);
        graph.AddEdge(2, 3);
        return graph;
    }

    [Fact]
    public void DfsOrder_Works_OnSimpleGraph()
    {
        Graph<int> graph = CreateSimpleGraph();

        IReadOnlyList<int> order = Dfs.DfsOrder(graph, 0);

        Assert.Equal(4, order.Count);
        Assert.Equal(0, order[0]);
        Assert.Contains(1, order);
        Assert.Contains(2, order);
        Assert.Contains(3, order);
    }

    [Fact]
    public void DfsOrder_Works_OnSingleVertex()
    {
        Graph<int> graph = new Graph<int>(isDirected: false);
        graph.AddVertex(0);

        IReadOnlyList<int> order = Dfs.DfsOrder(graph, 0);

        Assert.Single(order);
        Assert.Equal(0, order[0]);
    }
}
