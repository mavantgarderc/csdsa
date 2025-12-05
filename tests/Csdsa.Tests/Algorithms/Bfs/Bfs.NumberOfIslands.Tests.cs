using System;
using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.GraphTraversal;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class BfsTests
{
    [Fact]
    public void NumberOfIslands_Works()
    {
        int[,] grid =
        {
            { 1, 1, 0, 0 },
            { 1, 0, 0, 1 },
            { 0, 0, 1, 1 },
            { 0, 0, 0, 0 },
        };

        int count = Bfs.NumberOfIslands(grid);

        Assert.Equal(2, count);
    }
}
