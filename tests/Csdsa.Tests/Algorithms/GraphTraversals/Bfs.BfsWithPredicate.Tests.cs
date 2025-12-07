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
    public void BfsWithPredicate_Works()
    {
        Graph<int> graph = CreateSimpleGraph();

        int distanceToTwo = Bfs.BfsWithPredicate(graph, 0, u => u == 2);
        Assert.Equal(2, distanceToTwo);

        int distanceToMissing = Bfs.BfsWithPredicate(graph, 0, u => u == 99);
        Assert.Equal(-1, distanceToMissing);
    }
}
