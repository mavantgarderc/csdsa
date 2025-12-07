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
    public void ConnectedComponents_Module_Works()
    {
        Graph<int> graph = new Graph<int>(isDirected: false);
        graph.AddEdge(0, 1);
        graph.AddEdge(2, 3);

        IReadOnlyList<IReadOnlyList<int>> components = Bfs.ConnectedComponents(graph);

        Assert.Equal(2, components.Count);
        Assert.Contains(components, c => c.Contains(0) && c.Contains(1));
        Assert.Contains(components, c => c.Contains(2) && c.Contains(3));
    }
}
