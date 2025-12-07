using System;
using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.GraphTraversal;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class BfsTests
{
    [Fact]
    public void ShortestPathInGrid_Works()
    {
        int[,] grid =
        {
            { 0, 0, 1 },
            { 1, 0, 1 },
            { 1, 0, 0 },
        };

        Point start = new Point(0, 0);
        Point end = new Point(2, 2);

        int distance = Bfs.ShortestPathInGrid(grid, start, end);
        Assert.Equal(4, distance);

        int[,] blocked =
        {
            { 0, 1 },
            { 1, 0 },
        };

        int blockedDistance = Bfs.ShortestPathInGrid(blocked, new Point(0, 0), new Point(1, 1));
        Assert.Equal(-1, blockedDistance);
    }
}
